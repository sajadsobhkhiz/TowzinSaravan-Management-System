
namespace TowzinSaravan.App.Orders
{
    partial class frmOrders
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnNew = new System.Windows.Forms.ToolStripButton();
            this.btnEdit = new System.Windows.Forms.ToolStripButton();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.btnRefresh = new System.Windows.Forms.ToolStripButton();
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsSpecial = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remain = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chkIsNormal = new System.Windows.Forms.CheckBox();
            this.chkIsSpecial = new System.Windows.Forms.CheckBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtFromDate = new System.Windows.Forms.MaskedTextBox();
            this.txtToDate = new System.Windows.Forms.MaskedTextBox();
            this.txtOrderNumber = new System.Windows.Forms.TextBox();
            this.cmbCustomers = new System.Windows.Forms.ComboBox();
            this.cmbProductTypes = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNew,
            this.btnEdit,
            this.btnDelete,
            this.btnRefresh});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStrip1.Size = new System.Drawing.Size(1059, 62);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnNew
            // 
            this.btnNew.Image = global::TowzinSaravan.App.Properties.Resources._new;
            this.btnNew.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(62, 59);
            this.btnNew.Text = "مجوز جدید";
            this.btnNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Image = global::TowzinSaravan.App.Properties.Resources.edit;
            this.btnEdit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 59);
            this.btnEdit.Text = "ویرایش مجوز";
            this.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Image = global::TowzinSaravan.App.Properties.Resources.remove;
            this.btnDelete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(64, 59);
            this.btnDelete.Text = "حذف مجوز";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
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
            // dgvOrders
            // 
            this.dgvOrders.AllowUserToAddRows = false;
            this.dgvOrders.AllowUserToDeleteRows = false;
            this.dgvOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.OrderNumber,
            this.OrderDate,
            this.CustomerId,
            this.ProductId,
            this.IsSpecial,
            this.Amount,
            this.Remain});
            this.dgvOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOrders.Location = new System.Drawing.Point(3, 17);
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.ReadOnly = true;
            this.dgvOrders.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvOrders.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvOrders.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrders.Size = new System.Drawing.Size(1029, 277);
            this.dgvOrders.TabIndex = 1;
            this.dgvOrders.TabStop = false;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "شناسه";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // OrderNumber
            // 
            this.OrderNumber.DataPropertyName = "OrderNumber";
            this.OrderNumber.HeaderText = "شماره مجوز";
            this.OrderNumber.Name = "OrderNumber";
            this.OrderNumber.ReadOnly = true;
            // 
            // OrderDate
            // 
            this.OrderDate.DataPropertyName = "OrderDate";
            this.OrderDate.HeaderText = "تاریخ";
            this.OrderDate.Name = "OrderDate";
            this.OrderDate.ReadOnly = true;
            // 
            // CustomerId
            // 
            this.CustomerId.DataPropertyName = "CustomerId";
            this.CustomerId.HeaderText = "خریدار";
            this.CustomerId.Name = "CustomerId";
            this.CustomerId.ReadOnly = true;
            // 
            // ProductId
            // 
            this.ProductId.DataPropertyName = "ProductId";
            this.ProductId.HeaderText = "نوع کالا";
            this.ProductId.Name = "ProductId";
            this.ProductId.ReadOnly = true;
            // 
            // IsSpecial
            // 
            this.IsSpecial.DataPropertyName = "IsSpecial";
            this.IsSpecial.HeaderText = "آزاد";
            this.IsSpecial.Name = "IsSpecial";
            this.IsSpecial.ReadOnly = true;
            this.IsSpecial.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IsSpecial.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Amount
            // 
            this.Amount.DataPropertyName = "Amount";
            this.Amount.HeaderText = "مقدار مجوز";
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            // 
            // Remain
            // 
            this.Remain.HeaderText = "باقیمانده";
            this.Remain.Name = "Remain";
            this.Remain.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.chkIsNormal);
            this.groupBox1.Controls.Add(this.chkIsSpecial);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.txtFromDate);
            this.groupBox1.Controls.Add(this.txtToDate);
            this.groupBox1.Controls.Add(this.txtOrderNumber);
            this.groupBox1.Controls.Add(this.cmbCustomers);
            this.groupBox1.Controls.Add(this.cmbProductTypes);
            this.groupBox1.Location = new System.Drawing.Point(12, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(1035, 59);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "فیلترگذاری براساس";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(363, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "خریدار:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(514, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "نوع کالا:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(818, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "از تاریخ:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(667, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "تا تاریخ:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(966, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "شماره مجوز:";
            // 
            // chkIsNormal
            // 
            this.chkIsNormal.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.chkIsNormal.AutoSize = true;
            this.chkIsNormal.Checked = true;
            this.chkIsNormal.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkIsNormal.Location = new System.Drawing.Point(124, 25);
            this.chkIsNormal.Name = "chkIsNormal";
            this.chkIsNormal.Size = new System.Drawing.Size(64, 17);
            this.chkIsNormal.TabIndex = 6;
            this.chkIsNormal.Text = "معمولی";
            this.chkIsNormal.UseVisualStyleBackColor = true;
            // 
            // chkIsSpecial
            // 
            this.chkIsSpecial.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.chkIsSpecial.AutoSize = true;
            this.chkIsSpecial.Checked = true;
            this.chkIsSpecial.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkIsSpecial.Location = new System.Drawing.Point(205, 25);
            this.chkIsSpecial.Name = "chkIsSpecial";
            this.chkIsSpecial.Size = new System.Drawing.Size(41, 17);
            this.chkIsSpecial.TabIndex = 5;
            this.chkIsSpecial.Text = "آزاد";
            this.chkIsSpecial.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSearch.Location = new System.Drawing.Point(15, 22);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(101, 23);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "جستجو";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtFromDate
            // 
            this.txtFromDate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtFromDate.Location = new System.Drawing.Point(717, 23);
            this.txtFromDate.Mask = "0000/00/00";
            this.txtFromDate.Name = "txtFromDate";
            this.txtFromDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtFromDate.Size = new System.Drawing.Size(100, 21);
            this.txtFromDate.TabIndex = 1;
            this.txtFromDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFromDate.ValidatingType = typeof(System.DateTime);
            // 
            // txtToDate
            // 
            this.txtToDate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtToDate.Location = new System.Drawing.Point(564, 23);
            this.txtToDate.Mask = "0000/00/00";
            this.txtToDate.Name = "txtToDate";
            this.txtToDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtToDate.Size = new System.Drawing.Size(100, 21);
            this.txtToDate.TabIndex = 2;
            this.txtToDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtToDate.ValidatingType = typeof(System.DateTime);
            // 
            // txtOrderNumber
            // 
            this.txtOrderNumber.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtOrderNumber.Location = new System.Drawing.Point(866, 23);
            this.txtOrderNumber.Name = "txtOrderNumber";
            this.txtOrderNumber.Size = new System.Drawing.Size(100, 21);
            this.txtOrderNumber.TabIndex = 0;
            this.txtOrderNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtOrderNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOrderNumber_KeyPress);
            // 
            // cmbCustomers
            // 
            this.cmbCustomers.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cmbCustomers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCustomers.FormattingEnabled = true;
            this.cmbCustomers.Location = new System.Drawing.Point(261, 23);
            this.cmbCustomers.Name = "cmbCustomers";
            this.cmbCustomers.Size = new System.Drawing.Size(100, 21);
            this.cmbCustomers.TabIndex = 4;
            // 
            // cmbProductTypes
            // 
            this.cmbProductTypes.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cmbProductTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProductTypes.FormattingEnabled = true;
            this.cmbProductTypes.Location = new System.Drawing.Point(408, 23);
            this.cmbProductTypes.Name = "cmbProductTypes";
            this.cmbProductTypes.Size = new System.Drawing.Size(100, 21);
            this.cmbProductTypes.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dgvOrders);
            this.groupBox2.Location = new System.Drawing.Point(12, 130);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1035, 297);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // frmOrders
            // 
            this.AcceptButton = this.btnSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 439);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmOrders";
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "مجوزهای گندم";
            this.Load += new System.EventHandler(this.frmOrders_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnNew;
        private System.Windows.Forms.ToolStripButton btnEdit;
        private System.Windows.Forms.ToolStripButton btnDelete;
        private System.Windows.Forms.ToolStripButton btnRefresh;
        private System.Windows.Forms.DataGridView dgvOrders;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox txtToDate;
        private System.Windows.Forms.TextBox txtOrderNumber;
        private System.Windows.Forms.ComboBox cmbProductTypes;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.CheckBox chkIsSpecial;
        private System.Windows.Forms.ComboBox cmbCustomers;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkIsNormal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductId;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsSpecial;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remain;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox txtFromDate;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}