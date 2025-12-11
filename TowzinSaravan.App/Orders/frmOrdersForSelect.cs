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

namespace TowzinSaravan.App.Orders
{
    public partial class frmOrdersForSelect : Form
    {
        public int productTypeId = 0;
        public frmOrdersForSelect()
        {
            InitializeComponent();
        }

        private void BindGrid(int productTypeId)
        {

            using (UnitOfWork db = new UnitOfWork())
            {
                dgvOrders.AutoGenerateColumns = false;
                string productType = db.productTypeRepository.GetProductTypeById(productTypeId);
                var result = db.OrderRepository.GetOrderByProductTypeId(productTypeId);

                dgvOrders.Rows.Clear();
                foreach (var orders in result)
                {
                    if ((orders.Amount - db.invoiceRepository.GetSumOfOrder(orders.Id)) <= 0) continue;
                    string customerName = db.CustomerRepository.GetCustomerNameById(orders.CustomerId);
                    bool isDust = orders.IsDust;
                    bool isSpecial = orders.IsSpecial;
                    dgvOrders.Rows.Add(orders.Id, orders.OrderNumber, customerName, ((isDust) ? "خاک " + productType : productType) + ((isSpecial) ? " - آزاد " : ""), (orders.Amount - db.invoiceRepository.GetSumOfOrder(orders.Id)).ToString("#,#"));

                }
            }
        }

        private void frmOrdersForSelect_Load(object sender, EventArgs e)
        {
            BindGrid(productTypeId);
            //RtlMessageBox.Show(productTypeId.ToString());
        }

        private void dgvOrders_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Invoices.frmInvoices.orderId = int.Parse(dgvOrders.CurrentRow.Cells[0].Value.ToString());
            Invoices.frmInvoices.orderNumber = int.Parse(dgvOrders.CurrentRow.Cells[1].Value.ToString());
            Invoices.frmInvoices.customer = dgvOrders.CurrentRow.Cells[2].Value.ToString();
            Invoices.frmInvoices.product = dgvOrders.CurrentRow.Cells[4].Value.ToString();
            DialogResult = DialogResult.OK;
        }
    }
}
