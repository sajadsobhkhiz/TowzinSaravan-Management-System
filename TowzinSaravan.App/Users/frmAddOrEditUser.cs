using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TowzinSaravan.DataLayer;
using TowzinSaravan.DataLayer.Context;
using ValidationComponents;


namespace TowzinSaravan.App
{
    public partial class frmAddOrEditUser : Form
    {
        public int userId = 0;
        bool done = false;

        public frmAddOrEditUser()
        {
            InitializeComponent();
        }

        private void frmAddOrEditUser_Load(object sender, EventArgs e)
        {
            if (userId != 0)
            {
                this.Text = "ویرایش کاربر";
                btnSave.Text = "ویرایش";
                txtUsername.Enabled = false;
                using (UnitOfWork db = new UnitOfWork())
                {
                    var user = db.UserRepository.GetUserById(userId);
                    txtFirstname.Text = user.Firstname;
                    txtLastname.Text = user.Lastname;
                    txtUsername.Text = user.Username;
                    txtPassword.Text = user.Password;
                    if (user.UserImage != "no-image.jpg")
                    {
                        pcbUser.ImageLocation = Application.StartupPath + "/Images/" + user.UserImage;
                    }
                }

            }
        }

        private void btnSelectImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                pcbUser.ImageLocation = openFile.FileName;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (BaseValidator.IsFormValid(this.components))
            {
                string imageName = "no-image.jpg";
                if (pcbUser.ImageLocation != null)
                {
                    imageName = Guid.NewGuid().ToString() + Path.GetExtension(pcbUser.ImageLocation);
                    string path = Application.StartupPath + "/Images/";
                    if (!Directory.Exists(path))
                    {
                        Directory.CreateDirectory(path);
                    }
                    pcbUser.Image.Save(path + imageName);
                }

                DataLayer.Users user = new DataLayer.Users()
                {
                    Firstname = txtFirstname.Text,
                    Lastname = txtLastname.Text,
                    Username = txtUsername.Text,
                    Password = txtPassword.Text,
                    UserImage = imageName
                };
                using (UnitOfWork db = new UnitOfWork())
                {
                    if (userId == 0)
                    {
                        if (db.UserRepository.GetUserByUsername(txtUsername.Text.ToLower().Trim()) == null)
                        {
                            db.UserRepository.InsertUser(user);
                            done = true;
                        }
                        else
                        {
                            RtlMessageBox.Show("نام کاربری وارد شده تکراری است." + Environment.NewLine + "لطفاً نام کاربری را تغییر دهید.");
                        }
                    }
                    else
                    {
                        user.Id = userId;
                        db.UserRepository.UpdateUser(user);
                        done = true;
                    }
                    db.Save();
                }


                if (done == true)
                    DialogResult = DialogResult.OK;

            }
        }
    }
}
