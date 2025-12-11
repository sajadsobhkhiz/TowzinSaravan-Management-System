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

namespace TowzinSaravan.App
{
    public partial class frmLogin : Form
    {
        int wrongCount = 0;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtUsername.Focus();

            lblUser.Visible = false;
            lblPass.Visible = false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsername.Text))
            {
                lblUser.Visible = true;
                txtUsername.Focus();
            }
            else if (string.IsNullOrEmpty(txtPassword.Text))
            {
                lblPass.Visible = true;
                txtPassword.Focus();
            }
            else
            {
                if (wrongCount == 3)
                {
                    RtlMessageBox.Show("تعداد دفعات وارد کردن گذرواژه بیش از حد مجاز است!", "خطا!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    frmMain.loginClosing = true;
                    Application.Exit();
                }
                else
                {
                    using (UnitOfWork db = new UnitOfWork())
                    {
                        if (db.UserRepository.CheckUserForLogin(txtUsername.Text.ToLower().Trim(), txtPassword.Text.ToLower().Trim()))
                        {
                            frmMain.userId = db.UserRepository.GetUserId(txtUsername.Text.ToLower().Trim());
                            DialogResult = DialogResult.OK;
                        }
                        else
                        {
                            RtlMessageBox.Show("نام کاربری یا گذرواژه اشتباه است!");
                            wrongCount += 1;
                        }
                    }
                }

            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            frmMain.loginClosing = true;
            Application.Exit();
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmMain.loginClosing = true;
        }
    }
}
