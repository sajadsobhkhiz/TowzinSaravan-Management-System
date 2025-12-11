
namespace TowzinSaravan.App.Drivers
{
    partial class frmDrivers
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblStar2 = new System.Windows.Forms.Label();
            this.lblStar1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMobile = new System.Windows.Forms.TextBox();
            this.txtLastname = new System.Windows.Forms.TextBox();
            this.txtFirstname = new System.Windows.Forms.TextBox();
            this.dgvDrivers = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Firstname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lastname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mobile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDrivers)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblStar2);
            this.groupBox1.Controls.Add(this.lblStar1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtMobile);
            this.groupBox1.Controls.Add(this.txtLastname);
            this.groupBox1.Controls.Add(this.txtFirstname);
            this.groupBox1.Location = new System.Drawing.Point(377, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(260, 169);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "اطلاعات راننده";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(41, 123);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "حذف";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(141, 123);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "ثبت";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(147, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "شماره موبایل:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(147, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "نام خانوادگی:";
            // 
            // lblStar2
            // 
            this.lblStar2.AutoSize = true;
            this.lblStar2.ForeColor = System.Drawing.Color.Red;
            this.lblStar2.Location = new System.Drawing.Point(22, 64);
            this.lblStar2.Name = "lblStar2";
            this.lblStar2.Size = new System.Drawing.Size(13, 13);
            this.lblStar2.TabIndex = 1;
            this.lblStar2.Text = "*";
            this.lblStar2.Visible = false;
            // 
            // lblStar1
            // 
            this.lblStar1.AutoSize = true;
            this.lblStar1.ForeColor = System.Drawing.Color.Red;
            this.lblStar1.Location = new System.Drawing.Point(22, 37);
            this.lblStar1.Name = "lblStar1";
            this.lblStar1.Size = new System.Drawing.Size(13, 13);
            this.lblStar1.TabIndex = 1;
            this.lblStar1.Text = "*";
            this.lblStar1.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(147, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "نام:";
            // 
            // txtMobile
            // 
            this.txtMobile.Location = new System.Drawing.Point(41, 88);
            this.txtMobile.MaxLength = 11;
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(100, 21);
            this.txtMobile.TabIndex = 2;
            this.txtMobile.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMobile_KeyPress);
            // 
            // txtLastname
            // 
            this.txtLastname.Location = new System.Drawing.Point(41, 61);
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Size = new System.Drawing.Size(100, 21);
            this.txtLastname.TabIndex = 1;
            // 
            // txtFirstname
            // 
            this.txtFirstname.Location = new System.Drawing.Point(41, 34);
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.Size = new System.Drawing.Size(100, 21);
            this.txtFirstname.TabIndex = 0;
            // 
            // dgvDrivers
            // 
            this.dgvDrivers.AllowUserToAddRows = false;
            this.dgvDrivers.AllowUserToDeleteRows = false;
            this.dgvDrivers.AllowUserToResizeColumns = false;
            this.dgvDrivers.AllowUserToResizeRows = false;
            this.dgvDrivers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDrivers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDrivers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Firstname,
            this.Lastname,
            this.Mobile});
            this.dgvDrivers.Location = new System.Drawing.Point(12, 22);
            this.dgvDrivers.Name = "dgvDrivers";
            this.dgvDrivers.ReadOnly = true;
            this.dgvDrivers.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvDrivers.Size = new System.Drawing.Size(347, 169);
            this.dgvDrivers.TabIndex = 1;
            this.dgvDrivers.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvDrivers_RowHeaderMouseDoubleClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "شناسه";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // Firstname
            // 
            this.Firstname.DataPropertyName = "Firstname";
            this.Firstname.HeaderText = "نام";
            this.Firstname.Name = "Firstname";
            this.Firstname.ReadOnly = true;
            // 
            // Lastname
            // 
            this.Lastname.DataPropertyName = "Lastname";
            this.Lastname.HeaderText = "نام خانوادگی";
            this.Lastname.Name = "Lastname";
            this.Lastname.ReadOnly = true;
            // 
            // Mobile
            // 
            this.Mobile.DataPropertyName = "Mobile";
            this.Mobile.HeaderText = "شماره موبایل";
            this.Mobile.Name = "Mobile";
            this.Mobile.ReadOnly = true;
            // 
            // frmDrivers
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 212);
            this.Controls.Add(this.dgvDrivers);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmDrivers";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "رانندگان";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDrivers_FormClosing);
            this.Load += new System.EventHandler(this.frmDrivers_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDrivers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblStar2;
        private System.Windows.Forms.Label lblStar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMobile;
        private System.Windows.Forms.TextBox txtLastname;
        private System.Windows.Forms.TextBox txtFirstname;
        private System.Windows.Forms.DataGridView dgvDrivers;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Firstname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lastname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mobile;
    }
}