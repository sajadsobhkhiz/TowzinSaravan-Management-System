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

namespace TowzinSaravan.App.Users
{
    public partial class frmUsers : Form
    {
        public frmUsers()
        {
            InitializeComponent();
        }

        private void frmUsers_Load(object sender, EventArgs e)
        {
            BindGird();
        }

        void BindGird()
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                dgvUsers.AutoGenerateColumns = false;
                dgvUsers.DataSource = db.UserRepository.GetAllUsers();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            BindGird();
            txtFilter.Text = null;
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                dgvUsers.DataSource = db.UserRepository.GetUsersByFilter(txtFilter.Text.Trim());
            }
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            if (dgvUsers.CurrentRow != null)
            {
                using (UnitOfWork db = new UnitOfWork())
                {
                    string Fullname = dgvUsers.CurrentRow.Cells[2].Value.ToString() + " " + dgvUsers.CurrentRow.Cells[3].Value.ToString();
                    if (RtlMessageBox.Show($"آیا از حذف {Fullname} مطمئن هستید؟", "هشدار!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        int userId = int.Parse(dgvUsers.CurrentRow.Cells[0].Value.ToString());
                        db.UserRepository.DeleteUser(userId);
                        db.Save();
                        BindGird();
                    }
                }
            }
            else
            {
                RtlMessageBox.Show("یک ردیف را جهت حذف انتخاب کنید");
            }
        }

        private void btnAddNewUser_Click(object sender, EventArgs e)
        {
            frmAddOrEditUser frmAddOrEditUser = new frmAddOrEditUser();
            if (frmAddOrEditUser.ShowDialog() == DialogResult.OK)
            {
                BindGird();
            }
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            if (dgvUsers.CurrentRow != null)
            {
                int userId = int.Parse(dgvUsers.CurrentRow.Cells[0].Value.ToString());
                frmAddOrEditUser frmAddOrEditUser = new frmAddOrEditUser();
                frmAddOrEditUser.userId = userId;
                if (frmAddOrEditUser.ShowDialog() == DialogResult.OK)
                {
                    BindGird();
                }
            }
            else
            {
                RtlMessageBox.Show("یک ردیف را جهت ویرایش انتخاب کنید");
            }
        }
    }
}
