
namespace TowzinSaravan.App
{
    partial class frmAddOrEditUser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddOrEditUser));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtLastname = new System.Windows.Forms.TextBox();
            this.txtFirstname = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSelectImage = new System.Windows.Forms.Button();
            this.pcbUser = new System.Windows.Forms.PictureBox();
            this.requiredFieldValidator1 = new ValidationComponents.RequiredFieldValidator(this.components);
            this.requiredFieldValidator2 = new ValidationComponents.RequiredFieldValidator(this.components);
            this.requiredFieldValidator3 = new ValidationComponents.RequiredFieldValidator(this.components);
            this.requiredFieldValidator4 = new ValidationComponents.RequiredFieldValidator(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbUser)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.txtUsername);
            this.groupBox1.Controls.Add(this.txtLastname);
            this.groupBox1.Controls.Add(this.txtFirstname);
            this.groupBox1.Location = new System.Drawing.Point(184, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(243, 208);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "اطلاعات کاربر";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(165, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "گذرواژه:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(165, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "نام کاربری:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(165, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "نام خانوادگی:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(165, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "نام:";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(144, 170);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "ثبت";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(25, 116);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(125, 21);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(25, 89);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(125, 21);
            this.txtUsername.TabIndex = 2;
            // 
            // txtLastname
            // 
            this.txtLastname.Location = new System.Drawing.Point(25, 62);
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Size = new System.Drawing.Size(125, 21);
            this.txtLastname.TabIndex = 1;
            // 
            // txtFirstname
            // 
            this.txtFirstname.Location = new System.Drawing.Point(25, 35);
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.Size = new System.Drawing.Size(125, 21);
            this.txtFirstname.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSelectImage);
            this.groupBox2.Controls.Add(this.pcbUser);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(166, 208);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "تصویر";
            // 
            // btnSelectImage
            // 
            this.btnSelectImage.Location = new System.Drawing.Point(17, 170);
            this.btnSelectImage.Name = "btnSelectImage";
            this.btnSelectImage.Size = new System.Drawing.Size(130, 23);
            this.btnSelectImage.TabIndex = 0;
            this.btnSelectImage.Text = "انتخاب تصویر";
            this.btnSelectImage.UseVisualStyleBackColor = true;
            this.btnSelectImage.Click += new System.EventHandler(this.btnSelectImage_Click);
            // 
            // pcbUser
            // 
            this.pcbUser.Image = global::TowzinSaravan.App.Properties.Resources.no_image;
            this.pcbUser.Location = new System.Drawing.Point(17, 20);
            this.pcbUser.Name = "pcbUser";
            this.pcbUser.Size = new System.Drawing.Size(130, 144);
            this.pcbUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbUser.TabIndex = 2;
            this.pcbUser.TabStop = false;
            // 
            // requiredFieldValidator1
            // 
            this.requiredFieldValidator1.CancelFocusChangeWhenInvalid = false;
            this.requiredFieldValidator1.ControlToValidate = this.txtFirstname;
            this.requiredFieldValidator1.ErrorMessage = "وارد کردن نام الزامی است.";
            this.requiredFieldValidator1.Icon = ((System.Drawing.Icon)(resources.GetObject("requiredFieldValidator1.Icon")));
            // 
            // requiredFieldValidator2
            // 
            this.requiredFieldValidator2.CancelFocusChangeWhenInvalid = false;
            this.requiredFieldValidator2.ControlToValidate = this.txtLastname;
            this.requiredFieldValidator2.ErrorMessage = "وارد کردن نام خانوادگی الزامی است.";
            this.requiredFieldValidator2.Icon = ((System.Drawing.Icon)(resources.GetObject("requiredFieldValidator2.Icon")));
            // 
            // requiredFieldValidator3
            // 
            this.requiredFieldValidator3.CancelFocusChangeWhenInvalid = false;
            this.requiredFieldValidator3.ControlToValidate = this.txtUsername;
            this.requiredFieldValidator3.ErrorMessage = "وارد کردن نام کاربری الزامی است.";
            this.requiredFieldValidator3.Icon = ((System.Drawing.Icon)(resources.GetObject("requiredFieldValidator3.Icon")));
            // 
            // requiredFieldValidator4
            // 
            this.requiredFieldValidator4.CancelFocusChangeWhenInvalid = false;
            this.requiredFieldValidator4.ControlToValidate = this.txtPassword;
            this.requiredFieldValidator4.ErrorMessage = "وارد کردن گذرواژه الزامی است.";
            this.requiredFieldValidator4.Icon = ((System.Drawing.Icon)(resources.GetObject("requiredFieldValidator4.Icon")));
            // 
            // frmAddOrEditUser
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 241);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAddOrEditUser";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "افزودن کاربر جدید";
            this.Load += new System.EventHandler(this.frmAddOrEditUser_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtLastname;
        private System.Windows.Forms.TextBox txtFirstname;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSelectImage;
        private System.Windows.Forms.PictureBox pcbUser;
        private ValidationComponents.RequiredFieldValidator requiredFieldValidator1;
        private ValidationComponents.RequiredFieldValidator requiredFieldValidator2;
        private ValidationComponents.RequiredFieldValidator requiredFieldValidator3;
        private ValidationComponents.RequiredFieldValidator requiredFieldValidator4;
    }
}