using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TowzinSaravan.DataLayer.Context;
using System.Windows.Forms;
using TowzinSaravan.Utility.Convertor;
using TowzinSaravan.ViewModel.Customers;
using TowzinSaravan.ViewModel.ProductTypes;

namespace TowzinSaravan.App.Orders
{
    public partial class frmAddOrEditOrder : Form
    {
        public int orderId = 0;
        public bool isDust = false;
        bool done = false;
        public frmAddOrEditOrder()
        {
            InitializeComponent();
        }

        private void frmAddOrEditOrder_Load(object sender, EventArgs e)
        {

            BindComboBox(isDust);

            if (orderId != 0)
            {
                if (isDust)
                {
                    this.Text = "ویرایش مجوز خاک گندم";
                    chkIsSpecial.Visible = false;
                }
                else
                {
                    this.Text = "ویرایش مجوز گندم";
                }
                btnSave.Text = "ویرایش";
                using (UnitOfWork db = new UnitOfWork())
                {
                    var order = db.OrderRepository.GetOrderById(orderId);
                    txtDate.Text = order.OrderDate.ToShamsi();
                    cmbCustomers.SelectedValue = order.CustomerId;
                    cmbProductTypes.SelectedValue = order.ProductTypeId;
                    txtOrderNumber.Text = order.OrderNumber.ToString();
                    txtAmount.Text=order.Amount.ToString("#,#");
                    if (order.IsSpecial) chkIsSpecial.CheckState=CheckState.Checked;
                }

            }
            else
            {
                if (isDust)
                {
                    this.Text = "افزودن مجوز خاک گندم";
                    chkIsSpecial.Visible = false;
                }
                else
                {
                    this.Text = "افزودن مجوز گندم";
                }
            }
            txtDate.Focus();
            txtDate.SelectAll();
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

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {
            NumberFormat.ThousandSeparator(txtAmount);
        }

        private void txtOrderNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtOrderNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                //System.Media.SystemSounds.Beep.Play();
            }

        }

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                //System.Media.SystemSounds.Beep.Play();
            }
        }
        private bool CheckFields()
        {
            if (!txtDate.MaskCompleted)
            {
                RtlMessageBox.Show("فیلد تاریخ را بطور کامل پر نمائید.");
                txtDate.Focus();
                txtDate.SelectAll();
                return false;
            }
            else if ((int)(cmbCustomers.SelectedValue) == 0)
            {
                RtlMessageBox.Show("خریدار را انتخاب نمائید.");
                cmbCustomers.Focus();
                return false;
            }
            else if ((int)(cmbProductTypes.SelectedValue) == 0)
            {
                RtlMessageBox.Show("نوع کالا را انتخاب نمائید.");
                cmbProductTypes.Focus();
                return false;
            }
            else if (string.IsNullOrEmpty(txtOrderNumber.Text))
            {
                RtlMessageBox.Show("شماره مجوز را وارد نمائید.");
                txtOrderNumber.SelectAll();
                txtOrderNumber.Focus();
                return false;
            }
            else if (string.IsNullOrEmpty(txtAmount.Text))
            {
                RtlMessageBox.Show("مقدار مجوز را وارد نمائید.");
                txtAmount.SelectAll();
                txtAmount.Focus();
                return false;
            }
            else
            {
                return true;
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (CheckFields())
            {
                DataLayer.Orders order = new DataLayer.Orders()
                {
                    OrderDate = DateConvertor.ToMiladi(Convert.ToDateTime(txtDate.Text)),
                    CustomerId = int.Parse(cmbCustomers.SelectedValue.ToString()),
                    ProductTypeId = int.Parse(cmbProductTypes.SelectedValue.ToString()),
                    OrderNumber = int.Parse(txtOrderNumber.Text),
                    Amount = int.Parse(txtAmount.Text.Replace(",","")),
                    IsSpecial = (chkIsSpecial.Checked) ? true : false,
                    IsDust = isDust

                };
                using (UnitOfWork db = new UnitOfWork())
                {
                    int orNumber = int.Parse(txtOrderNumber.Text);
                    DateTime orDate = DateConvertor.ToMiladi(Convert.ToDateTime(txtDate.Text));
                    if (orderId == 0)
                    {
                        if (db.OrderRepository.GetOrderByOrderNumberAndOrderDate(orNumber, orDate.Year.ToString()) == null)
                        {
                            db.OrderRepository.InsertOrder(order);
                            done = true;
                        }
                        else
                        {
                            RtlMessageBox.Show("شماره مجوز وارد شده تکراری است." + Environment.NewLine + "لطفاً دوباره امتحان کنید.");
                        }
                    }
                    else
                    {
                        order.Id = orderId;
                        if (db.OrderRepository.CheckOrderForUpdate(orderId, orNumber, orDate.Year.ToString()) == null)
                        {
                            db.OrderRepository.UpdateOrder(order);
                            done = true;
                        }
                        else
                        {
                            RtlMessageBox.Show("شماره مجوز وارد شده در سال جاری موجود می‌باشد." + Environment.NewLine + "لطفاً دوباره امتحان کنید.");
                            txtDate.SelectAll();
                            txtDate.Focus();
                        }
                    }
                    db.Save();
                }


                if (done == true)
                    DialogResult = DialogResult.OK;
            }

        }

        private void btnToday_Click(object sender, EventArgs e)
        {
            txtDate.Text = DateTime.Now.ToShamsi();
            txtDate.Focus();
            txtDate.SelectAll();
        }

        private void frmAddOrEditOrder_Shown(object sender, EventArgs e)
        {
            txtDate.Focus();
            txtDate.SelectAll();
        }
    }
}


