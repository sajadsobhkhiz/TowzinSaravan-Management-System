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

namespace TowzinSaravan.App.Drivers
{
    public partial class frmDrivers : Form
    {
        public int driverId = 0;
        public bool fromInvoice = false;
        bool done = false;
        public frmDrivers()
        {
            InitializeComponent();
        }

        void BindGrid()
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                dgvDrivers.AutoGenerateColumns = false;
                dgvDrivers.DataSource = db.DriverRepository.GetAllDrivers();
            }
            txtFirstname.ResetText();
            txtLastname.ResetText();
            txtMobile.ResetText();
            lblStar1.Visible = false;
            lblStar2.Visible = false;
            btnDelete.Enabled = false;
            btnSave.Text = "ثبت";
            txtFirstname.Focus();
            done = false;
        }
        private void frmDrivers_Load(object sender, EventArgs e)
        {
            BindGrid();
            txtFirstname.ResetText();
            txtLastname.ResetText();
            txtMobile.ResetText();
            lblStar1.Visible = false;
            lblStar2.Visible = false;
            btnDelete.Enabled = false;
            btnSave.Text = "ثبت";
            txtFirstname.Focus();
            done = false;
        }

        private void txtMobile_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                //System.Media.SystemSounds.Beep.Play();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFirstname.Text))
            {
                lblStar1.Visible = true;
                txtFirstname.Focus();
            }
            else if (string.IsNullOrEmpty(txtLastname.Text))
            {
                lblStar2.Visible = true;
                txtLastname.Focus();
            }
            else
            {
                DataLayer.Drivers driver = new DataLayer.Drivers()
                {
                    Firstname = txtFirstname.Text.Trim(),
                    Lastname = txtLastname.Text.Trim(),
                    Mobile = txtMobile.Text
                };
                using (UnitOfWork db = new UnitOfWork())
                {
                    if (driverId == 0)
                    {
                        if (db.DriverRepository.GetDriverByDriverFullname(txtFirstname.Text.ToLower().Trim(), txtLastname.Text.ToLower().Trim()) == null)
                        {
                            db.DriverRepository.InsertDriver(driver);
                            done = true;
                        }
                        else
                        {
                            RtlMessageBox.Show("نام وارد شده تکراری است.");
                            txtFirstname.SelectAll();
                            txtFirstname.Focus();
                        }
                    }
                    else
                    {
                        driver.Id = driverId;
                        if (db.DriverRepository.CheckDriverForUpdate(driverId, txtFirstname.Text.ToLower().Trim(), txtLastname.Text.ToLower().Trim()) == null)
                        {
                            db.DriverRepository.UpdateDriver(driver);
                            done = true;
                        }
                        else
                        {
                            RtlMessageBox.Show("نام وارد شده تکراری است.");
                            txtFirstname.SelectAll();
                            txtFirstname.Focus();
                        }
                    }
                    db.Save();

                    if (done)
                        frmDrivers_Load(null, null);
                }
            }

        }

        private void dgvDrivers_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            driverId = int.Parse(dgvDrivers.CurrentRow.Cells[0].Value.ToString());
            txtFirstname.Text = dgvDrivers.CurrentRow.Cells[1].Value.ToString();
            txtLastname.Text = dgvDrivers.CurrentRow.Cells[2].Value.ToString();
            txtMobile.Text = dgvDrivers.CurrentRow.Cells[3].Value.ToString();
            btnDelete.Enabled = true;
            btnSave.Text = "ویرایش";
            txtFirstname.SelectAll();
            txtFirstname.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvDrivers.CurrentRow != null)
            {
                using (UnitOfWork db = new UnitOfWork())
                {
                    string fullname = dgvDrivers.CurrentRow.Cells[1].Value.ToString() + " " + dgvDrivers.CurrentRow.Cells[2].Value.ToString();
                    if (RtlMessageBox.Show($"آیا از حذف {fullname} مطمئن هستید؟", "هشدار!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        driverId = int.Parse(dgvDrivers.CurrentRow.Cells[0].Value.ToString());
                        db.DriverRepository.DeleteDriver(driverId);
                        db.Save();
                        frmDrivers_Load(null, null);
                    }
                    else
                    {
                        frmDrivers_Load(null, null);
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
                frmDrivers_Load(null, null);
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void frmDrivers_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (fromInvoice)
                DialogResult = DialogResult.OK;
        }
    }
}
