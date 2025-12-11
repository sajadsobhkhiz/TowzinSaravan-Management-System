using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TowzinSaravan.DataLayer.Context;
using TowzinSaravan.DataLayer.Services;
using TowzinSaravan.DataLayer.Repositories;
using TowzinSaravan.Utility.Convertor;
using TowzinSaravan.ViewModel.Customers;
using TowzinSaravan.ViewModel.ProductTypes;


namespace TowzinSaravan.App.Orders
{
    public partial class frmOrders : Form
    {
        public bool isDust = false;
        public frmOrders()
        {
            InitializeComponent();
        }

        private void BindGird(bool value)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                dgvOrders.AutoGenerateColumns = false;
                var result = value ? db.OrderRepository.GetDustOrders() : db.OrderRepository.GetWheatOrders();

                dgvOrders.Rows.Clear();
                foreach (var orders in result)
                {
                    string customerName = db.CustomerRepository.GetCustomerNameById(orders.CustomerId);
                    string productType = db.productTypeRepository.GetProductTypeById(orders.ProductTypeId);
                    if (value)
                    {
                        dgvOrders.Columns["IsSpecial"].Visible = false;
                    }
                    dgvOrders.Rows.Add(orders.Id, orders.OrderNumber, orders.OrderDate.ToShamsi(), customerName, (value) ? "خاک " + productType : productType, orders.IsSpecial, orders.Amount.ToString("#,#"), (orders.Amount - db.invoiceRepository.GetSumOfOrder(orders.Id) == 0 ? "0" : (orders.Amount - db.invoiceRepository.GetSumOfOrder(orders.Id)).ToString("#,#")));

                }
            }
        }

        private void BindComboBox(bool value)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                List<ListCustomerViewModel> list = new List<ListCustomerViewModel>();
                list.Add(new ListCustomerViewModel()
                {
                    Id = 0,
                    Name = "انتخاب کنید"
                });
                var result = value ? db.CustomerRepository.GetDustCustomerName() : db.CustomerRepository.GetWheatCustomerName();
                list.AddRange(result);
                cmbCustomers.DataSource = list;
                cmbCustomers.DisplayMember = "Name";
                cmbCustomers.ValueMember = "Id";

                List<ListProductTypeViewModel> list2 = new List<ListProductTypeViewModel>();
                list2.Add(new ListProductTypeViewModel()
                {
                    Id = 0,
                    Type = "انتخاب کنید"
                });
                list2.AddRange(db.productTypeRepository.GetProductType());
                cmbProductTypes.DataSource = list2;
                cmbProductTypes.DisplayMember = "Type";
                cmbProductTypes.ValueMember = "Id";
            }
        }

        private void SelectAllWhenFocused(object sender, EventArgs e)
        {
            txtFromDate.SelectAll();
            txtToDate.SelectAll();
            txtOrderNumber.SelectAll();
        }

        private void frmOrders_Load(object sender, EventArgs e)
        {
            if (isDust)
            {
                this.Text = "مجوزهای خاک گندم";
                chkIsNormal.Visible = false;
                chkIsSpecial.Visible = false;
                btnSearch.Location = new Point(145, 23);
            }
            BindGird(isDust);
            BindComboBox(isDust);
            txtOrderNumber.ResetText();
            txtFromDate.ResetText();
            txtToDate.ResetText();
            txtOrderNumber.Focus();
            txtOrderNumber.GotFocus += SelectAllWhenFocused;
            txtFromDate.GotFocus += SelectAllWhenFocused;
            txtToDate.GotFocus += SelectAllWhenFocused;
        }


        private void btnNew_Click(object sender, EventArgs e)
        {
            frmAddOrEditOrder frmAddOrEditOrder = new frmAddOrEditOrder();
            if (isDust)
            {
                frmAddOrEditOrder.isDust = isDust;
            }
            if (frmAddOrEditOrder.ShowDialog() == DialogResult.OK)
            {
                BindGird(isDust);
            }
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {

                List<DataLayer.Orders> result = new List<DataLayer.Orders>();
                DateTime? startDate;
                DateTime? endDate;
                var query = isDust ? db.OrderRepository.GetDustOrders() : db.OrderRepository.GetWheatOrders();
                if (!string.IsNullOrEmpty(txtOrderNumber.Text))
                {
                    query = db.OrderRepository.GetOrdersByNumber(int.Parse(txtOrderNumber.Text), isDust);
                }

                if (int.Parse(cmbProductTypes.SelectedValue.ToString()) != 0)
                {
                    query = query.Where(q => q.ProductTypeId == int.Parse(cmbProductTypes.SelectedValue.ToString())).OrderByDescending(q => q.OrderDate).ThenByDescending(q => q.OrderNumber).ToList();
                }

                if (int.Parse(cmbCustomers.SelectedValue.ToString()) != 0)
                {
                    query = query.Where(q => q.CustomerId == int.Parse(cmbCustomers.SelectedValue.ToString())).OrderByDescending(q => q.OrderDate).ThenByDescending(q => q.OrderNumber).ToList();
                }
                try
                {
                    if (txtFromDate.Text != "    /  /" && txtFromDate.MaskCompleted)
                    {
                        startDate = Convert.ToDateTime(txtFromDate.Text);
                        startDate = DateConvertor.ToMiladi(startDate.Value);
                        query = query.Where(q => q.OrderDate >= startDate.Value).ToList();
                    }
                    if (txtToDate.Text != "    /  /" && txtToDate.MaskCompleted)
                    {
                        endDate = Convert.ToDateTime(txtToDate.Text);
                        endDate = DateConvertor.ToMiladi(endDate.Value);
                        query = query.Where(q => q.OrderDate <= endDate.Value).ToList();
                    }
                }
                catch (Exception)
                {
                    RtlMessageBox.Show("تاریخ را بدرستی وارد نمائید.", "هشدار!", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                    return;
                }

                if (!isDust)
                {
                    if (chkIsSpecial.Checked && chkIsNormal.Checked)
                    {
                        goto done;
                    }
                    else
                    {
                        if (chkIsSpecial.Checked)
                        {
                            query = query.Where(q => q.IsSpecial == true).OrderByDescending(q => q.OrderDate).ThenByDescending(q => q.OrderNumber).ToList();
                        }
                        if (chkIsNormal.Checked)
                        {
                            query = query.Where(q => q.IsSpecial == false).OrderByDescending(q => q.OrderDate).ThenByDescending(q => q.OrderNumber).ToList();
                        }
                    }

                }



            done:
                result.AddRange(query);
                dgvOrders.Rows.Clear();

                foreach (var orders in result)
                {
                    string customerName = db.CustomerRepository.GetCustomerNameById(orders.CustomerId);
                    string productType = db.productTypeRepository.GetProductTypeById(orders.ProductTypeId);
                    if (isDust)
                    {
                        dgvOrders.Columns["IsSpecial"].Visible = false;
                    }
                    dgvOrders.Rows.Add(orders.Id, orders.OrderNumber, orders.OrderDate.ToShamsi(), customerName, (isDust) ? "خاک " + productType : productType, orders.IsSpecial, orders.Amount.ToString("#,#"), (orders.Amount - db.invoiceRepository.GetSumOfOrder(orders.Id)).ToString("#,#"));

                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvOrders.CurrentRow != null)
            {
                int orderId = int.Parse(dgvOrders.CurrentRow.Cells[0].Value.ToString());
                frmAddOrEditOrder frmAddOrEditOrder = new frmAddOrEditOrder();
                frmAddOrEditOrder.orderId = orderId;
                frmAddOrEditOrder.isDust = isDust;
                if (frmAddOrEditOrder.ShowDialog() == DialogResult.OK)
                {
                    BindGird(isDust);
                }
            }
            else
            {
                RtlMessageBox.Show("یک ردیف را جهت حذف انتخاب کنید");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvOrders.CurrentRow != null)
            {
                using (UnitOfWork db = new UnitOfWork())
                {
                    string orderNumber = dgvOrders.CurrentRow.Cells[1].Value.ToString();
                    if (RtlMessageBox.Show($"آیا از حذف مجوز شماره {orderNumber} مطمئن هستید؟", "هشدار!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        int orderId = int.Parse(dgvOrders.CurrentRow.Cells[0].Value.ToString());
                        db.OrderRepository.DeleteOrder(orderId);
                        db.Save();
                        BindGird(isDust);
                    }
                }
            }
            else
            {
                RtlMessageBox.Show("یک ردیف را جهت حذف انتخاب کنید");
            }
        }

        private void txtOrderNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                //System.Media.SystemSounds.Beep.Play();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            frmOrders_Load(null, null);
        }

    }
}
