
namespace TowzinSaravan.App.Orders
{
    partial class frmAddOrEditOrder
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
            this.txtOrderNumber = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.MaskedTextBox();
            this.cmbCustomers = new System.Windows.Forms.ComboBox();
            this.chkIsSpecial = new System.Windows.Forms.CheckBox();
            this.cmbProductTypes = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnToday = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtOrderNumber
            // 
            this.txtOrderNumber.Location = new System.Drawing.Point(54, 125);
            this.txtOrderNumber.MaxLength = 6;
            this.txtOrderNumber.Name = "txtOrderNumber";
            this.txtOrderNumber.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtOrderNumber.Size = new System.Drawing.Size(121, 21);
            this.txtOrderNumber.TabIndex = 3;
            this.txtOrderNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOrderNumber_KeyPress);
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(54, 156);
            this.txtAmount.MaxLength = 10;
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtAmount.Size = new System.Drawing.Size(121, 21);
            this.txtAmount.TabIndex = 4;
            this.txtAmount.TextChanged += new System.EventHandler(this.txtAmount_TextChanged);
            this.txtAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmount_KeyPress);
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(54, 32);
            this.txtDate.Mask = "0000/00/00";
            this.txtDate.Name = "txtDate";
            this.txtDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtDate.Size = new System.Drawing.Size(121, 21);
            this.txtDate.TabIndex = 0;
            this.txtDate.ValidatingType = typeof(System.DateTime);
            // 
            // cmbCustomers
            // 
            this.cmbCustomers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCustomers.FormattingEnabled = true;
            this.cmbCustomers.Location = new System.Drawing.Point(54, 63);
            this.cmbCustomers.Name = "cmbCustomers";
            this.cmbCustomers.Size = new System.Drawing.Size(121, 21);
            this.cmbCustomers.TabIndex = 1;
            // 
            // chkIsSpecial
            // 
            this.chkIsSpecial.AutoSize = true;
            this.chkIsSpecial.Location = new System.Drawing.Point(134, 183);
            this.chkIsSpecial.Name = "chkIsSpecial";
            this.chkIsSpecial.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkIsSpecial.Size = new System.Drawing.Size(41, 17);
            this.chkIsSpecial.TabIndex = 5;
            this.chkIsSpecial.Text = "آزاد";
            this.chkIsSpecial.UseVisualStyleBackColor = true;
            // 
            // cmbProductTypes
            // 
            this.cmbProductTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProductTypes.FormattingEnabled = true;
            this.cmbProductTypes.Location = new System.Drawing.Point(54, 94);
            this.cmbProductTypes.Name = "cmbProductTypes";
            this.cmbProductTypes.Size = new System.Drawing.Size(121, 21);
            this.cmbProductTypes.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(192, 35);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "تاریخ مجوز:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(192, 66);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "خریدار:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(192, 97);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "نوع کالا:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(192, 128);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "شماره مجوز:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(192, 159);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "مقدار مجوز:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnToday);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.txtDate);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtOrderNumber);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtAmount);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbCustomers);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbProductTypes);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.chkIsSpecial);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(270, 253);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "مشخصات مجوز";
            // 
            // btnToday
            // 
            this.btnToday.Location = new System.Drawing.Point(14, 31);
            this.btnToday.Name = "btnToday";
            this.btnToday.Size = new System.Drawing.Size(40, 23);
            this.btnToday.TabIndex = 8;
            this.btnToday.Text = "امروز";
            this.btnToday.UseVisualStyleBackColor = true;
            this.btnToday.Click += new System.EventHandler(this.btnToday_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(54, 206);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(121, 32);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "ثبت";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmAddOrEditOrder
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 283);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAddOrEditOrder";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "افزودن مجوز جدید";
            this.Load += new System.EventHandler(this.frmAddOrEditOrder_Load);
            this.Shown += new System.EventHandler(this.frmAddOrEditOrder_Shown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtOrderNumber;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.MaskedTextBox txtDate;
        private System.Windows.Forms.ComboBox cmbCustomers;
        private System.Windows.Forms.CheckBox chkIsSpecial;
        private System.Windows.Forms.ComboBox cmbProductTypes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnToday;
    }
}