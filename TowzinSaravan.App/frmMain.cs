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
using TowzinSaravan.Utility.Convertor;

namespace TowzinSaravan.App
{
    public partial class frmMain : Form
    {
        public static bool loginClosing = false;
        public static int userId;
        public static bool isAutomatic = true;
        public frmMain()
        {
            InitializeComponent();
        }

        private void BindGrid()
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                dgvInvoices.AutoGenerateColumns = false;
                var result = db.invoiceRepository.GetTotalInvoices();

                dgvInvoices.Rows.Clear();
                foreach (var invoice in result)
                {
                    string firstScaleDateTime = DateTime.Parse(invoice.FirstScaleDate.ToString()).ToShamsi() + " - " + DateTime.Parse(invoice.FirstScaleTime.ToString()).ToString("HH:mm");
                    string secondScaleDateTime = invoice.SecondScaleDate != null ? DateTime.Parse(invoice.SecondScaleDate.ToString()).ToShamsi() + " - " + DateTime.Parse(invoice.SecondScaleTime.ToString()).ToString("HH:mm") : "-";

                    dgvInvoices.Rows.Add(invoice.Id, invoice.InvoiceNumber, invoice.CarNumber, (invoice.DriverName != null ? invoice.DriverName : "-"), invoice.ProductType, firstScaleDateTime, secondScaleDateTime,
                      invoice.FullWeight, invoice.EmptyWeight, invoice.NetWeight, (invoice.CustomerName != null ? invoice.CustomerName : "-"), (invoice.OrderNumber != null ? invoice.OrderNumber : 0));
                }
            }

            for (int i = 0; i < 7; i++)
            {
                dgvInvoices.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            dgvInvoices.ClearSelection();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin frmLogin = new frmLogin();
            if (frmLogin.ShowDialog() == DialogResult.OK)
            {
                this.Show();
                loginClosing = false;
                if (isAutomatic)
                    cmbScalingType.SelectedIndex = 0;
                else
                    cmbScalingType.SelectedIndex = 1;
                //lblDate.Text = DateConvertor.ToShamsi(DateTime.Now);
                //lblTime.Text = DateTime.Now.ToString("HH:mm:ss");
                BindGrid();
            }
            else
            {
                Application.Exit();
            }
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            Users.frmUsers frmUsers = new Users.frmUsers();
            frmUsers.ShowDialog();
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            Customers.frmCustomers frmCustomers = new Customers.frmCustomers();
            frmCustomers.ShowDialog();
        }


        private void btnWheatOrders_Click(object sender, EventArgs e)
        {
            Orders.frmOrders frmWheatOrders = new Orders.frmOrders();
            frmWheatOrders.ShowDialog();
        }

        private void btnDustOrders_Click(object sender, EventArgs e)
        {
            Orders.frmOrders frmDustOrders = new Orders.frmOrders();
            frmDustOrders.isDust = true;
            frmDustOrders.ShowDialog();
        }

        private void btnDrivers_Click(object sender, EventArgs e)
        {
            Drivers.frmDrivers frmDCrivers = new Drivers.frmDrivers();
            frmDCrivers.ShowDialog();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!loginClosing)
            {
                if (RtlMessageBox.Show("آیا برای خروج از برنامه اطمینان دارید؟", "هشدار!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }


        private void btnScaling_Click(object sender, EventArgs e)
        {

            Invoices.frmInvoices frmInvoices = new Invoices.frmInvoices();
            frmInvoices.isNew = true;
            if (frmInvoices.ShowDialog() == DialogResult.OK)
            {
                BindGrid();
            }
        }

        private void cmbScalingType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbScalingType.SelectedIndex == 0)
                isAutomatic = true;
            else if (cmbScalingType.SelectedIndex == 1)
                isAutomatic = false;
        }

        private void dgvInvoices_SelectionChanged(object sender, EventArgs e)
        {
            txtFullWeight.Text = dgvInvoices.CurrentRow.Cells[7].Value.ToString();
            txtEmptyWeight.Text = dgvInvoices.CurrentRow.Cells[8].Value.ToString();
            txtNetWeight.Text = dgvInvoices.CurrentRow.Cells[9].Value.ToString();
            txtCustomer.Text = dgvInvoices.CurrentRow.Cells[10].Value.ToString();
            txtOrderNumber.Text = dgvInvoices.CurrentRow.Cells[11].Value.ToString();
        }
    }
}
