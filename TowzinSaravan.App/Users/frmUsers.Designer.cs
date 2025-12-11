
namespace TowzinSaravan.App.Users
{
    partial class frmUsers
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnAddNewUser = new System.Windows.Forms.ToolStripButton();
            this.btnEditUser = new System.Windows.Forms.ToolStripButton();
            this.btnDeleteUser = new System.Windows.Forms.ToolStripButton();
            this.btnRefresh = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.txtFilter = new System.Windows.Forms.ToolStripTextBox();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.UserId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Firstname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lastname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddNewUser,
            this.btnEditUser,
            this.btnDeleteUser,
            this.btnRefresh,
            this.toolStripLabel1,
            this.txtFilter});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStrip1.Size = new System.Drawing.Size(584, 62);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnAddNewUser
            // 
            this.btnAddNewUser.Image = global::TowzinSaravan.App.Properties.Resources._new;
            this.btnAddNewUser.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnAddNewUser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddNewUser.Name = "btnAddNewUser";
            this.btnAddNewUser.Size = new System.Drawing.Size(60, 59);
            this.btnAddNewUser.Text = "کاربر جدید";
            this.btnAddNewUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAddNewUser.Click += new System.EventHandler(this.btnAddNewUser_Click);
            // 
            // btnEditUser
            // 
            this.btnEditUser.Image = global::TowzinSaravan.App.Properties.Resources.edit;
            this.btnEditUser.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnEditUser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditUser.Name = "btnEditUser";
            this.btnEditUser.Size = new System.Drawing.Size(73, 59);
            this.btnEditUser.Text = "ویرایش کاربر";
            this.btnEditUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEditUser.Click += new System.EventHandler(this.btnEditUser_Click);
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.Image = global::TowzinSaravan.App.Properties.Resources.remove;
            this.btnDeleteUser.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnDeleteUser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(62, 59);
            this.btnDeleteUser.Text = "حذف کاربر";
            this.btnDeleteUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Image = global::TowzinSaravan.App.Properties.Resources.refresh;
            this.btnRefresh.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(60, 59);
            this.btnRefresh.Text = "بروزرسانی";
            this.btnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(44, 59);
            this.toolStripLabel1.Text = "جسنجو:";
            // 
            // txtFilter
            // 
            this.txtFilter.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(100, 62);
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            // 
            // dgvUsers
            // 
            this.dgvUsers.AllowUserToAddRows = false;
            this.dgvUsers.AllowUserToDeleteRows = false;
            this.dgvUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserId,
            this.Username,
            this.Firstname,
            this.Lastname});
            this.dgvUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUsers.Location = new System.Drawing.Point(0, 62);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.ReadOnly = true;
            this.dgvUsers.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvUsers.Size = new System.Drawing.Size(584, 299);
            this.dgvUsers.TabIndex = 1;
            // 
            // UserId
            // 
            this.UserId.DataPropertyName = "Id";
            this.UserId.HeaderText = "شناسه";
            this.UserId.Name = "UserId";
            this.UserId.ReadOnly = true;
            this.UserId.Visible = false;
            // 
            // Username
            // 
            this.Username.DataPropertyName = "Username";
            this.Username.HeaderText = "نام کاربری";
            this.Username.Name = "Username";
            this.Username.ReadOnly = true;
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
            // frmUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.dgvUsers);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmUsers";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "کاربران";
            this.Load += new System.EventHandler(this.frmUsers_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnAddNewUser;
        private System.Windows.Forms.ToolStripButton btnEditUser;
        private System.Windows.Forms.ToolStripButton btnDeleteUser;
        private System.Windows.Forms.ToolStripButton btnRefresh;
        private System.Windows.Forms.ToolStripTextBox txtFilter;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn Firstname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lastname;
    }
}