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
using ValidationComponents;

namespace TowzinSaravan.App.Customers
{
    public partial class frmCustomers : Form
    {
        public int customerId = 0;
        bool done = false;
        public frmCustomers()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtName.Text))
            {

                DataLayer.Customers customer = new DataLayer.Customers()
                {
                    Name = txtName.Text.Trim(),
                    IsDust = chkIsDust.Checked ? true : false
                };
                using (UnitOfWork db = new UnitOfWork())
                {
                    if (customerId == 0)
                    {
                        if (db.CustomerRepository.GetCustomerByCustomerName(txtName.Text.ToLower().Trim()) == null)
                        {
                            db.CustomerRepository.InsertCustomer(customer);
                            done = true;
                        }
                        else
                        {
                            RtlMessageBox.Show("نام وارد شده تکراری است.");
                            txtName.SelectAll();
                            txtName.Focus();
                        }
                    }
                    else
                    {
                        customer.Id = customerId;
                        if (db.CustomerRepository.CheckCustomerForUpdate(customerId, txtName.Text.ToLower().Trim()) == null)
                        {
                            db.CustomerRepository.UpdateCustomer(customer);
                            done = true;
                        }
                        else
                        {
                            RtlMessageBox.Show("نام وارد شده تکراری است.");
                            txtName.SelectAll();
                            txtName.Focus();
                        }
                    }
                    db.Save();

                    if(done)
                        frmCustomers_Load(null, null);
                }


                //if (done == true)
                //    DialogResult = DialogResult.OK;
            }
            else
            {
                label2.Visible = true;
                txtName.Focus();
            }
        }


        void BindGrid()
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                dgvCustomers.AutoGenerateColumns = false;
                dgvCustomers.DataSource = db.CustomerRepository.GetAllCustomers();
            }
        }

        private void frmCustomers_Load(object sender, EventArgs e)
        {
            BindGrid();
            txtName.ResetText();
            chkIsDust.Checked = false;
            label2.Visible = false;
            btnDelete.Enabled = false;
            btnSave.Text = "ثبت";
            txtName.Focus();
            done = false;

        }

        private void dgvCustomers_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            customerId = int.Parse(dgvCustomers.CurrentRow.Cells[0].Value.ToString());
            txtName.Text = dgvCustomers.CurrentRow.Cells[1].Value.ToString();
            chkIsDust.Checked = (bool)dgvCustomers.CurrentRow.Cells[2].Value;
            btnDelete.Enabled = true;
            btnSave.Text = "ویرایش";
            txtName.SelectAll();
            txtName.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvCustomers.CurrentRow != null)
            {
                using (UnitOfWork db = new UnitOfWork())
                {
                    string name = dgvCustomers.CurrentRow.Cells[1].Value.ToString();
                    if (RtlMessageBox.Show($"آیا از حذف {name} مطمئن هستید؟", "هشدار!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        customerId = int.Parse(dgvCustomers.CurrentRow.Cells[0].Value.ToString());
                        db.CustomerRepository.DeleteCustomer(customerId);
                        db.Save();
                        frmCustomers_Load(null, null);
                    }
                    else
                    {
                        frmCustomers_Load(null, null);
                    }
                }
            }
            else
            {
                RtlMessageBox.Show("یک ردیف را جهت حذف انتخاب کنید");
            }
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                frmCustomers_Load(null, null);
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}