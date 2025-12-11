using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TowzinSaravan.App.Invoices
{
    public partial class frmFullOrEmpty : Form
    {
        public static bool isExport, isFirstWeight;

        public frmFullOrEmpty()
        {
            InitializeComponent();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                this.Close();
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        private void frmFullOrEmpty_Load(object sender, EventArgs e)
        {
            frmInvoices.fullWeight = 0;
            frmInvoices.emptyWeight = 0;
            if (isExport)
            {
                if (isFirstWeight)
                    btnEmptyWeight.Focus();
                else
                    btnFullWeight.Focus();
            }
            else
            {
                if (isFirstWeight)
                    btnFullWeight.Focus();
                else
                    btnEmptyWeight.Focus();
            }
        }

        private void btnEmptyWeight_Click(object sender, EventArgs e)
        {
            if (!isExport && isFirstWeight)
                RtlMessageBox.Show("ابتدا باید وزن پر را ثبت نمائید.");
            else
            {
                frmInvoices.emptyWeight = 10000;
                DialogResult = DialogResult.Yes;
            }
        }

        private void btnFullWeight_Click(object sender, EventArgs e)
        {
            if (isExport && isFirstWeight)
                RtlMessageBox.Show("ابتدا باید وزن خالی را ثبت نمائید.");
            else
            {
                frmInvoices.fullWeight = 20000;
                DialogResult = DialogResult.Yes;
            }
        }

    }
}
