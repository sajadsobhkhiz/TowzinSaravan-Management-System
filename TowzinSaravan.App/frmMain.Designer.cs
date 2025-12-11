
namespace TowzinSaravan.App
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.menuSelectScalingType = new System.Windows.Forms.ToolStripDropDownButton();
            this.cmbScalingType = new System.Windows.Forms.ToolStripComboBox();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.btnUsers = new System.Windows.Forms.ToolStripButton();
            this.btnDrivers = new System.Windows.Forms.ToolStripButton();
            this.btnCustomers = new System.Windows.Forms.ToolStripButton();
            this.btnWheatOrders = new System.Windows.Forms.ToolStripButton();
            this.btnDustOrders = new System.Windows.Forms.ToolStripButton();
            this.btnEmptyWeight = new System.Windows.Forms.ToolStripButton();
            this.btnFullWeight = new System.Windows.Forms.ToolStripButton();
            this.btnNewScaling = new System.Windows.Forms.ToolStripButton();
            this.lblWeight = new System.Windows.Forms.Label();
            this.dgvInvoices = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InvoiceNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CarNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DriverName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstScaleDateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SecondScaleDateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullWeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmptyWeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NetWeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblDate = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOrderNumber = new System.Windows.Forms.TextBox();
            this.txtCustomer = new System.Windows.Forms.TextBox();
            this.txtNetWeight = new System.Windows.Forms.TextBox();
            this.txtEmptyWeight = new System.Windows.Forms.TextBox();
            this.txtFullWeight = new System.Windows.Forms.TextBox();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoices)).BeginInit();
            this.panel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSelectScalingType});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStrip1.Size = new System.Drawing.Size(911, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // menuSelectScalingType
            // 
            this.menuSelectScalingType.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.menuSelectScalingType.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmbScalingType});
            this.menuSelectScalingType.Image = ((System.Drawing.Image)(resources.GetObject("menuSelectScalingType.Image")));
            this.menuSelectScalingType.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuSelectScalingType.Name = "menuSelectScalingType";
            this.menuSelectScalingType.Size = new System.Drawing.Size(118, 22);
            this.menuSelectScalingType.Text = "انتخاب نحوه باسکول";
            // 
            // cmbScalingType
            // 
            this.cmbScalingType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbScalingType.Items.AddRange(new object[] {
            "خودکار",
            "دستی"});
            this.cmbScalingType.Name = "cmbScalingType";
            this.cmbScalingType.Size = new System.Drawing.Size(121, 23);
            this.cmbScalingType.SelectedIndexChanged += new System.EventHandler(this.cmbScalingType_SelectedIndexChanged);
            // 
            // toolStrip2
            // 
            this.toolStrip2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnUsers,
            this.btnDrivers,
            this.btnCustomers,
            this.btnWheatOrders,
            this.btnDustOrders,
            this.btnEmptyWeight,
            this.btnFullWeight,
            this.btnNewScaling});
            this.toolStrip2.Location = new System.Drawing.Point(0, 25);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStrip2.Size = new System.Drawing.Size(911, 86);
            this.toolStrip2.TabIndex = 1;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // btnUsers
            // 
            this.btnUsers.Image = ((System.Drawing.Image)(resources.GetObject("btnUsers.Image")));
            this.btnUsers.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnUsers.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(68, 83);
            this.btnUsers.Text = "کاربران";
            this.btnUsers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // btnDrivers
            // 
            this.btnDrivers.Image = global::TowzinSaravan.App.Properties.Resources.drivers;
            this.btnDrivers.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnDrivers.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDrivers.Name = "btnDrivers";
            this.btnDrivers.Size = new System.Drawing.Size(68, 83);
            this.btnDrivers.Text = "رانندگان";
            this.btnDrivers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDrivers.Click += new System.EventHandler(this.btnDrivers_Click);
            // 
            // btnCustomers
            // 
            this.btnCustomers.Image = global::TowzinSaravan.App.Properties.Resources.customers;
            this.btnCustomers.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnCustomers.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(68, 83);
            this.btnCustomers.Text = "خریداران";
            this.btnCustomers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
            // 
            // btnWheatOrders
            // 
            this.btnWheatOrders.Image = global::TowzinSaravan.App.Properties.Resources.wheat_orders;
            this.btnWheatOrders.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnWheatOrders.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnWheatOrders.Name = "btnWheatOrders";
            this.btnWheatOrders.Size = new System.Drawing.Size(81, 83);
            this.btnWheatOrders.Text = "مجوزهای گندم";
            this.btnWheatOrders.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnWheatOrders.Click += new System.EventHandler(this.btnWheatOrders_Click);
            // 
            // btnDustOrders
            // 
            this.btnDustOrders.Image = global::TowzinSaravan.App.Properties.Resources.dust_orders;
            this.btnDustOrders.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnDustOrders.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDustOrders.Name = "btnDustOrders";
            this.btnDustOrders.Size = new System.Drawing.Size(79, 83);
            this.btnDustOrders.Text = "مجوزهای خاک";
            this.btnDustOrders.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDustOrders.Click += new System.EventHandler(this.btnDustOrders_Click);
            // 
            // btnEmptyWeight
            // 
            this.btnEmptyWeight.Image = global::TowzinSaravan.App.Properties.Resources.empty_truck;
            this.btnEmptyWeight.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnEmptyWeight.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEmptyWeight.Name = "btnEmptyWeight";
            this.btnEmptyWeight.Size = new System.Drawing.Size(68, 83);
            this.btnEmptyWeight.Text = "وزن خالی";
            this.btnEmptyWeight.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btnFullWeight
            // 
            this.btnFullWeight.Image = global::TowzinSaravan.App.Properties.Resources.full_truck;
            this.btnFullWeight.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnFullWeight.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFullWeight.Name = "btnFullWeight";
            this.btnFullWeight.Size = new System.Drawing.Size(68, 83);
            this.btnFullWeight.Text = "وزن پر";
            this.btnFullWeight.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btnNewScaling
            // 
            this.btnNewScaling.Image = global::TowzinSaravan.App.Properties.Resources.scaling;
            this.btnNewScaling.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnNewScaling.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNewScaling.Name = "btnNewScaling";
            this.btnNewScaling.Size = new System.Drawing.Size(68, 83);
            this.btnNewScaling.Text = "توزین جدید";
            this.btnNewScaling.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNewScaling.Click += new System.EventHandler(this.btnScaling_Click);
            // 
            // lblWeight
            // 
            this.lblWeight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblWeight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblWeight.Font = new System.Drawing.Font("Tahoma", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeight.ForeColor = System.Drawing.Color.Black;
            this.lblWeight.Location = new System.Drawing.Point(13, 28);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(220, 75);
            this.lblWeight.TabIndex = 5;
            this.lblWeight.Text = "00000";
            this.lblWeight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvInvoices
            // 
            this.dgvInvoices.AllowUserToAddRows = false;
            this.dgvInvoices.AllowUserToDeleteRows = false;
            this.dgvInvoices.AllowUserToResizeColumns = false;
            this.dgvInvoices.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvInvoices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("B Koodak", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInvoices.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvInvoices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInvoices.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.InvoiceNumber,
            this.CarNumber,
            this.DriverName,
            this.ProductType,
            this.FirstScaleDateTime,
            this.SecondScaleDateTime,
            this.FullWeight,
            this.EmptyWeight,
            this.NetWeight,
            this.CustomerName,
            this.OrderNumber});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("B Koodak", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInvoices.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvInvoices.Location = new System.Drawing.Point(3, 0);
            this.dgvInvoices.Name = "dgvInvoices";
            this.dgvInvoices.ReadOnly = true;
            this.dgvInvoices.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvInvoices.RowTemplate.Height = 30;
            this.dgvInvoices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInvoices.Size = new System.Drawing.Size(687, 403);
            this.dgvInvoices.TabIndex = 2;
            this.dgvInvoices.SelectionChanged += new System.EventHandler(this.dgvInvoices_SelectionChanged);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "شناسه";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // InvoiceNumber
            // 
            this.InvoiceNumber.DataPropertyName = "InvoiceNumber";
            this.InvoiceNumber.HeaderText = "شماره ورودی";
            this.InvoiceNumber.Name = "InvoiceNumber";
            this.InvoiceNumber.ReadOnly = true;
            // 
            // CarNumber
            // 
            this.CarNumber.DataPropertyName = "CarNumber";
            this.CarNumber.HeaderText = "شماره ماشین";
            this.CarNumber.Name = "CarNumber";
            this.CarNumber.ReadOnly = true;
            // 
            // DriverName
            // 
            this.DriverName.DataPropertyName = "DriverName";
            this.DriverName.HeaderText = "راننده";
            this.DriverName.Name = "DriverName";
            this.DriverName.ReadOnly = true;
            // 
            // ProductType
            // 
            this.ProductType.DataPropertyName = "ProductType";
            this.ProductType.HeaderText = "نوع کالا";
            this.ProductType.Name = "ProductType";
            this.ProductType.ReadOnly = true;
            // 
            // FirstScaleDateTime
            // 
            this.FirstScaleDateTime.HeaderText = "تاریخ و زمان توزین اول";
            this.FirstScaleDateTime.Name = "FirstScaleDateTime";
            this.FirstScaleDateTime.ReadOnly = true;
            // 
            // SecondScaleDateTime
            // 
            this.SecondScaleDateTime.HeaderText = "تاریخ و زمان توزین دوم";
            this.SecondScaleDateTime.Name = "SecondScaleDateTime";
            this.SecondScaleDateTime.ReadOnly = true;
            // 
            // FullWeight
            // 
            this.FullWeight.DataPropertyName = "FullWeight";
            this.FullWeight.HeaderText = "وزن پر";
            this.FullWeight.Name = "FullWeight";
            this.FullWeight.ReadOnly = true;
            this.FullWeight.Visible = false;
            // 
            // EmptyWeight
            // 
            this.EmptyWeight.DataPropertyName = "EmptyWeight";
            this.EmptyWeight.HeaderText = "وزن خالی";
            this.EmptyWeight.Name = "EmptyWeight";
            this.EmptyWeight.ReadOnly = true;
            this.EmptyWeight.Visible = false;
            // 
            // NetWeight
            // 
            this.NetWeight.DataPropertyName = "NetWeight";
            this.NetWeight.HeaderText = "وزن خالص";
            this.NetWeight.Name = "NetWeight";
            this.NetWeight.ReadOnly = true;
            this.NetWeight.Visible = false;
            // 
            // CustomerName
            // 
            this.CustomerName.DataPropertyName = "CustomerName";
            this.CustomerName.HeaderText = "خریدار";
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.ReadOnly = true;
            this.CustomerName.Visible = false;
            // 
            // OrderNumber
            // 
            this.OrderNumber.DataPropertyName = "OrderNumber";
            this.OrderNumber.HeaderText = "شماره حواله";
            this.OrderNumber.Name = "OrderNumber";
            this.OrderNumber.ReadOnly = true;
            this.OrderNumber.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.dgvInvoices);
            this.panel1.Font = new System.Drawing.Font("B Koodak", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.panel1.Location = new System.Drawing.Point(224, 114);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(687, 403);
            this.panel1.TabIndex = 6;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblTime,
            this.lblDate});
            this.statusStrip1.Location = new System.Drawing.Point(0, 465);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(911, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblTime
            // 
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(38, 17);
            this.lblTime.Text = "ساعت";
            // 
            // lblDate
            // 
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(31, 17);
            this.lblDate.Text = "تاریخ";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtOrderNumber);
            this.panel2.Controls.Add(this.txtCustomer);
            this.panel2.Controls.Add(this.txtNetWeight);
            this.panel2.Controls.Add(this.txtEmptyWeight);
            this.panel2.Controls.Add(this.txtFullWeight);
            this.panel2.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.panel2.Location = new System.Drawing.Point(0, 114);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(218, 269);
            this.panel2.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(131, 181);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(82, 26);
            this.label5.TabIndex = 1;
            this.label5.Text = "شماره حواله:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(131, 142);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(53, 26);
            this.label4.TabIndex = 1;
            this.label4.Text = "خریدار:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(131, 103);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(73, 26);
            this.label3.TabIndex = 1;
            this.label3.Text = "وزن خالص:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(131, 64);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(68, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "وزن خالی:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(131, 25);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(51, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "وزن پر:";
            // 
            // txtOrderNumber
            // 
            this.txtOrderNumber.BackColor = System.Drawing.SystemColors.Window;
            this.txtOrderNumber.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtOrderNumber.Location = new System.Drawing.Point(12, 178);
            this.txtOrderNumber.Name = "txtOrderNumber";
            this.txtOrderNumber.ReadOnly = true;
            this.txtOrderNumber.Size = new System.Drawing.Size(100, 33);
            this.txtOrderNumber.TabIndex = 0;
            this.txtOrderNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCustomer
            // 
            this.txtCustomer.BackColor = System.Drawing.SystemColors.Window;
            this.txtCustomer.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtCustomer.Location = new System.Drawing.Point(13, 139);
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.ReadOnly = true;
            this.txtCustomer.Size = new System.Drawing.Size(100, 33);
            this.txtCustomer.TabIndex = 0;
            this.txtCustomer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNetWeight
            // 
            this.txtNetWeight.BackColor = System.Drawing.SystemColors.Window;
            this.txtNetWeight.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtNetWeight.Location = new System.Drawing.Point(12, 100);
            this.txtNetWeight.Name = "txtNetWeight";
            this.txtNetWeight.ReadOnly = true;
            this.txtNetWeight.Size = new System.Drawing.Size(100, 33);
            this.txtNetWeight.TabIndex = 0;
            this.txtNetWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtEmptyWeight
            // 
            this.txtEmptyWeight.BackColor = System.Drawing.SystemColors.Window;
            this.txtEmptyWeight.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtEmptyWeight.Location = new System.Drawing.Point(12, 61);
            this.txtEmptyWeight.Name = "txtEmptyWeight";
            this.txtEmptyWeight.ReadOnly = true;
            this.txtEmptyWeight.Size = new System.Drawing.Size(100, 33);
            this.txtEmptyWeight.TabIndex = 0;
            this.txtEmptyWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtFullWeight
            // 
            this.txtFullWeight.BackColor = System.Drawing.SystemColors.Window;
            this.txtFullWeight.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtFullWeight.Location = new System.Drawing.Point(12, 22);
            this.txtFullWeight.Name = "txtFullWeight";
            this.txtFullWeight.ReadOnly = true;
            this.txtFullWeight.Size = new System.Drawing.Size(100, 33);
            this.txtFullWeight.TabIndex = 0;
            this.txtFullWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 487);
            this.Controls.Add(this.lblWeight);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "توزین سراوان";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoices)).EndInit();
            this.panel1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton menuSelectScalingType;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton btnUsers;
        private System.Windows.Forms.ToolStripButton btnCustomers;
        private System.Windows.Forms.ToolStripButton btnWheatOrders;
        private System.Windows.Forms.ToolStripButton btnEmptyWeight;
        private System.Windows.Forms.ToolStripButton btnFullWeight;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.ToolStripButton btnDustOrders;
        private System.Windows.Forms.ToolStripButton btnDrivers;
        private System.Windows.Forms.ToolStripButton btnNewScaling;
        private System.Windows.Forms.DataGridView dgvInvoices;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOrderNumber;
        private System.Windows.Forms.TextBox txtCustomer;
        private System.Windows.Forms.TextBox txtNetWeight;
        private System.Windows.Forms.TextBox txtEmptyWeight;
        private System.Windows.Forms.TextBox txtFullWeight;
        private System.Windows.Forms.ToolStripStatusLabel lblTime;
        private System.Windows.Forms.ToolStripStatusLabel lblDate;
        private System.Windows.Forms.ToolStripComboBox cmbScalingType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvoiceNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn DriverName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductType;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstScaleDateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn SecondScaleDateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullWeight;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmptyWeight;
        private System.Windows.Forms.DataGridViewTextBoxColumn NetWeight;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderNumber;
    }
}

