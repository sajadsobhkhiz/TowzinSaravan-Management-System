using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TowzinSaravan.Utility.Convertor;
using TowzinSaravan.DataLayer.Context;
using TowzinSaravan.ViewModel.ProductTypes;
using TowzinSaravan.ViewModel.Drivers;


namespace TowzinSaravan.App.Invoices
{
    public partial class frmInvoices : Form
    {
        public static int? orderId, orderNumber;
        public static string customer;
        public static string product;
        public int invoicenumber = 0;
        public bool done = false;
        public bool edit = false;
        public bool isNew = false;
        int? driverId = null;
        public static int fullWeight = 0, emptyWeight = 0;
        public frmInvoices()
        {
            InitializeComponent();
        }



        private void frmInvoices_Load(object sender, EventArgs e)
        {
            BindDriverComboBox();
            BindProductComboBox();
            rbExport.Checked = true;
            cmbLetters.SelectedIndex = 20;
            txtDate.Text = DateTime.Now.ToShamsi();
            txtDate.Focus();
            txtDate.SelectAll();
            if (frmMain.isAutomatic)
            {
                txtFullWeight.ReadOnly = true;
                txtFullWeight.BackColor = Color.Yellow;
                txtEmptyWeight.ReadOnly = true;
                txtEmptyWeight.BackColor = Color.Yellow;

            }
            if (invoicenumber == 0)
            {
                using (UnitOfWork db = new UnitOfWork())
                {
                    txtInvoiceNumber.Text = (db.invoiceRepository.MakeNewInvoiceNumber() + 1).ToString();
                }
            }
            else
            {

            }
        }

        private void btnToday_Click(object sender, EventArgs e)
        {
            txtDate.Text = DateTime.Now.ToShamsi();
            txtDate.Focus();
            txtDate.SelectAll();
        }

        private void rbExport_CheckedChanged(object sender, EventArgs e)
        {
            if (rbExport.Checked)
            {
                groupBox2.Enabled = false;
                btnSelectOrder.Enabled = true;
                txtOrderDetails.Enabled = true;
            }
            rbExport.TabStop = false;
            rbImport.TabStop = false;
            rbThrowAway.TabStop = false;
        }


        private void rbImport_CheckedChanged(object sender, EventArgs e)
        {
            if (rbImport.Checked)
            {
                groupBox2.Enabled = true;
                btnSelectOrder.Enabled = false;
                txtOrderDetails.Enabled = false;

            }
            rbExport.TabStop = false;
            rbImport.TabStop = false;
            rbThrowAway.TabStop = false;
        }

        private void rbThrowAway_CheckedChanged(object sender, EventArgs e)
        {
            if (rbThrowAway.Checked)
            {
                groupBox2.Enabled = false;

            }
            rbExport.TabStop = false;
            rbImport.TabStop = false;
            rbThrowAway.TabStop = false;
        }


        private void groupBox2_EnabledChanged(object sender, EventArgs e)
        {
            if (!groupBox2.Enabled)
            {
                txtSourceEmptyWeight.Text = "0";
                txtSourceFullWeight.Text = "0";
                txtSourceNetWeight.Text = "0";
            }
        }


        private void txtInvoiceNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                //System.Media.SystemSounds.Beep.Play();
            }
        }


        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.F1)
            {
                rbExport.Select();
            }
            if (keyData == Keys.F2)
            {
                rbImport.Select();
            }
            if (keyData == Keys.F3)
            {
                rbThrowAway.Select();
            }
            if (keyData == Keys.F4)
            {
                if (frmMain.isAutomatic)
                {
                    Invoices.frmFullOrEmpty frmFullOrEmpty = new Invoices.frmFullOrEmpty();
                    frmFullOrEmpty.isExport = rbExport.Checked ? true : false;
                    frmFullOrEmpty.isFirstWeight = isNew;
                    if (frmFullOrEmpty.ShowDialog() == DialogResult.Yes)
                    {
                        txtFullWeight.Text = fullWeight.ToString();
                        txtEmptyWeight.Text = emptyWeight.ToString();
                    }
                }
                else
                {
                    RtlMessageBox.Show("باسکول در وضعیت اتوماتیک قرار ندارد.");
                }
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
        }

        private void txtSourceFullWeight_TextChanged(object sender, EventArgs e)
        {
            NumberFormat.ThousandSeparator(txtSourceFullWeight);
            if (string.IsNullOrEmpty(txtSourceFullWeight.Text))
            {
                txtSourceFullWeight.Text = "0";
                txtSourceFullWeight.SelectAll();
                txtSourceFullWeight.Focus();
            }
            int fullweight = int.Parse(txtSourceFullWeight.Text.Replace(",", ""));
            int emptyweight = int.Parse(txtSourceEmptyWeight.Text.Replace(",", ""));
            txtSourceNetWeight.Text = (fullweight - emptyweight).ToString();
        }


        private void txtSourceEmptyWeight_TextChanged(object sender, EventArgs e)
        {
            NumberFormat.ThousandSeparator(txtSourceEmptyWeight);
            if (string.IsNullOrEmpty(txtSourceEmptyWeight.Text))
            {
                txtSourceEmptyWeight.Text = "0";
                txtSourceEmptyWeight.SelectAll();
                txtSourceEmptyWeight.Focus();
            }
            int fullweight = int.Parse(txtSourceFullWeight.Text.Replace(",", ""));
            int emptyweight = int.Parse(txtSourceEmptyWeight.Text.Replace(",", ""));
            txtSourceNetWeight.Text = (fullweight - emptyweight).ToString();
        }

        private void txtSourceNetWeight_TextChanged(object sender, EventArgs e)
        {
            NumberFormat.ThousandSeparator(txtSourceNetWeight);
        }

        private void txtFullWeight_TextChanged(object sender, EventArgs e)
        {
            NumberFormat.ThousandSeparator(txtFullWeight);
            if (string.IsNullOrEmpty(txtFullWeight.Text))
            {
                txtFullWeight.Text = "0";
                txtFullWeight.SelectAll();
                txtFullWeight.Focus();
            }
            int fullweight = int.Parse(txtFullWeight.Text.Replace(",", ""));
            int emptyweight = int.Parse(txtEmptyWeight.Text.Replace(",", ""));
            txtNetWeight.Text = (fullweight - emptyweight).ToString();
        }

        private void txtEmptyWeight_TextChanged(object sender, EventArgs e)
        {
            NumberFormat.ThousandSeparator(txtEmptyWeight);
            if (string.IsNullOrEmpty(txtEmptyWeight.Text))
            {
                txtEmptyWeight.Text = "0";
                txtEmptyWeight.SelectAll();
                txtEmptyWeight.Focus();
            }
            int fullweight = int.Parse(txtFullWeight.Text.Replace(",", ""));
            int emptyweight = int.Parse(txtEmptyWeight.Text.Replace(",", ""));
            txtNetWeight.Text = (fullweight - emptyweight).ToString();
        }

        private void txtNetWeight_TextChanged(object sender, EventArgs e)
        {
            NumberFormat.ThousandSeparator(txtNetWeight);
        }


        private void txtSourceFullWeight_Enter(object sender, EventArgs e)
        {
            (sender as TextBox).SelectAll();
        }

        private void frmInvoices_Shown(object sender, EventArgs e)
        {
            txtDate.Focus();
            txtDate.SelectAll();
        }

        private void txtDigit1_TextChanged(object sender, EventArgs e)
        {
            if (txtDigit1.TextLength == 2)
            {
                txtDigit2.Focus();
                txtDigit2.SelectAll();
            }
        }

        private void txtDigit2_TextChanged(object sender, EventArgs e)
        {
            if (txtDigit2.TextLength == 3)
            {
                txtDigit3.Focus();
                txtDigit3.SelectAll();
            }
        }

        private void btnAddDriver_Click(object sender, EventArgs e)
        {
            Drivers.frmDrivers frmAddDriver = new Drivers.frmDrivers();
            frmAddDriver.fromInvoice = true;
            if (frmAddDriver.ShowDialog() == DialogResult.OK)
            {
                BindDriverComboBox();
            }
        }

        private void BindDriverComboBox()
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                List<ListDriverViewModel> list = new List<ListDriverViewModel>();
                list.Add(new ListDriverViewModel()
                {
                    Id = 0,
                    Fullname = "انتخاب کنید"
                });
                list.AddRange(db.DriverRepository.GetDriverFullnames());
                cmbDrivers.DataSource = list;
                cmbDrivers.DisplayMember = "Fullname";
                cmbDrivers.ValueMember = "Id";
            }
        }
        private void BindProductComboBox()
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                List<ListProductTypeViewModel> list = new List<ListProductTypeViewModel>();
                list.Add(new ListProductTypeViewModel()
                {
                    Id = 0,
                    Type = "انتخاب کنید"
                });
                list.AddRange(db.productTypeRepository.GetProductType());
                cmbProductTypes.DataSource = list;
                cmbProductTypes.DisplayMember = "Type";
                cmbProductTypes.ValueMember = "Id";
            }
        }

        private void groupBox4_EnabledChanged(object sender, EventArgs e)
        {
            if (!groupBox4.Enabled)
            {
                cmbProductTypes.SelectedIndex = 0;
                txtOrderDetails.ResetText();
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
            else if (txtDigit1.TextLength != txtDigit1.MaxLength || txtDigit2.TextLength != txtDigit2.MaxLength || txtDigit3.TextLength != txtDigit3.MaxLength)
            {
                RtlMessageBox.Show("لطفاً شماره پلاک را بطور صحیح نمائید.");
                txtDigit1.Focus();
                txtDigit1.SelectAll();
                return false;
            }
            else if (txtNetWeight.Text == "0")
            {
                RtlMessageBox.Show("وزن محموله به درستی وارد نشده است!");
                txtFullWeight.Focus();
                txtFullWeight.SelectAll();
                return false;
            }
            else if ((int)(cmbProductTypes.SelectedValue) == 0)
            {
                RtlMessageBox.Show("لطفاً نوع کالا را انتخاب نمائید.");
                cmbProductTypes.Focus();
                return false;
            }
            else if (rbExport.Checked && string.IsNullOrEmpty(txtOrderDetails.Text))
            {
                RtlMessageBox.Show("با توجه به انتخاب عملیات بارگیری، لطفاً حواله موردنظر را انتخاب نمائید.");
                btnSelectOrder.Focus();
                return false;
            }
            else
            {
                if ((int)(cmbDrivers.SelectedValue) == 0)
                {
                    driverId = null;
                }
                else if ((int)(cmbDrivers.SelectedValue) != 0)
                {
                    driverId = (int)(cmbDrivers.SelectedValue);
                }
            }
            return true;
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            //if (frmMain.isAutomatic)
            //{

            //}
            //else
            //{

            if (isNew)
            {
                if (CheckFields())
                {
                    DataLayer.Invoices invoice = new DataLayer.Invoices()
                    {
                        InvoiceTypeId = rbExport.Checked ? 1 : 2,
                        InvoiceNumber = int.Parse(txtInvoiceNumber.Text),
                        OrderId = rbExport.Checked ? orderId : null,
                        ProductTypeId = (int)(cmbProductTypes.SelectedValue),
                        CarDigit1 = txtDigit1.Text,
                        CarLetter = cmbLetters.SelectedItem.ToString(),
                        CarDigit2 = txtDigit2.Text,
                        CarDigit3 = txtDigit3.Text,
                        DriverId = driverId,
                        SourceFullWeight = rbImport.Checked ? int.Parse(txtSourceFullWeight.Text.Replace(",", "")) : 0,
                        SourceEmptyWeight = rbImport.Checked ? int.Parse(txtSourceEmptyWeight.Text.Replace(",", "")) : 0,
                        SourceNetWeight = rbImport.Checked ? int.Parse(txtSourceNetWeight.Text.Replace(",", "")) : 0,
                        FullWeight = int.Parse(txtFullWeight.Text.Replace(",", "")),
                        EmptyWeight = int.Parse(txtEmptyWeight.Text.Replace(",", "")),
                        NetWeight = int.Parse(txtNetWeight.Text.Replace(",", "")),
                        FirstScale = isNew ? true : false,
                        FirstScaleDate = DateConvertor.ToMiladi(Convert.ToDateTime(txtDate.Text)),
                        FirstScaleTime = TimeSpan.Parse(DateTime.Now.ToString("HH:mm")),
                        UserIdForFirstScale = frmMain.userId
                        //SecondScale = !isNew ? true : false,
                        //SecondScaleDateTime = DateTime.Now,
                        //Done = false

                    };
                    using (UnitOfWork db = new UnitOfWork())
                    {
                        db.invoiceRepository.InsertInvoice(invoice);
                        db.Save();
                    }


                    DialogResult = DialogResult.OK;
                }
            }
            else
            {

            }
            //   }


        }



        private void btnSelectOrder_Click(object sender, EventArgs e)
        {
            if ((int)(cmbProductTypes.SelectedValue) == 0)
            {
                RtlMessageBox.Show("لطفاً نوع کالا را انتخاب نمائید.");
                cmbProductTypes.Focus();
            }
            else
            {
                Orders.frmOrdersForSelect frmOrdersForSelect = new Orders.frmOrdersForSelect();
                frmOrdersForSelect.productTypeId = int.Parse(cmbProductTypes.SelectedValue.ToString());
                if (frmOrdersForSelect.ShowDialog() == DialogResult.OK)
                {
                    txtOrderDetails.Text = orderNumber + " - " + customer + " - " + product;
                }
            }


        }
    }
}
