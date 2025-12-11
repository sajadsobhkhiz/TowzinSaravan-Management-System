
namespace TowzinSaravan.App.Invoices
{
    partial class frmInvoices
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
            this.rbImport = new System.Windows.Forms.RadioButton();
            this.rbExport = new System.Windows.Forms.RadioButton();
            this.rbThrowAway = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtSourceNetWeight = new System.Windows.Forms.TextBox();
            this.txtSourceEmptyWeight = new System.Windows.Forms.TextBox();
            this.txtSourceFullWeight = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtNetWeight = new System.Windows.Forms.TextBox();
            this.txtEmptyWeight = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtFullWeight = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDigit3 = new System.Windows.Forms.TextBox();
            this.txtDigit2 = new System.Windows.Forms.TextBox();
            this.txtDigit1 = new System.Windows.Forms.TextBox();
            this.btnAddDriver = new System.Windows.Forms.Button();
            this.cmbLetters = new System.Windows.Forms.ComboBox();
            this.cmbDrivers = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtOrderDetails = new System.Windows.Forms.TextBox();
            this.btnSelectOrder = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbProductTypes = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtInvoiceNumber = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.MaskedTextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnToday = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbImport
            // 
            this.rbImport.AutoSize = true;
            this.rbImport.Location = new System.Drawing.Point(507, 17);
            this.rbImport.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbImport.Name = "rbImport";
            this.rbImport.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rbImport.Size = new System.Drawing.Size(56, 20);
            this.rbImport.TabIndex = 0;
            this.rbImport.Text = "تخلیه";
            this.rbImport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rbImport.UseVisualStyleBackColor = true;
            this.rbImport.CheckedChanged += new System.EventHandler(this.rbImport_CheckedChanged);
            // 
            // rbExport
            // 
            this.rbExport.AutoSize = true;
            this.rbExport.Location = new System.Drawing.Point(586, 17);
            this.rbExport.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbExport.Name = "rbExport";
            this.rbExport.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rbExport.Size = new System.Drawing.Size(66, 20);
            this.rbExport.TabIndex = 0;
            this.rbExport.Text = "بارگیری";
            this.rbExport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rbExport.UseVisualStyleBackColor = true;
            this.rbExport.CheckedChanged += new System.EventHandler(this.rbExport_CheckedChanged);
            // 
            // rbThrowAway
            // 
            this.rbThrowAway.AutoSize = true;
            this.rbThrowAway.Enabled = false;
            this.rbThrowAway.Location = new System.Drawing.Point(435, 17);
            this.rbThrowAway.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbThrowAway.Name = "rbThrowAway";
            this.rbThrowAway.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rbThrowAway.Size = new System.Drawing.Size(54, 20);
            this.rbThrowAway.TabIndex = 0;
            this.rbThrowAway.Text = "امحاء";
            this.rbThrowAway.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rbThrowAway.UseVisualStyleBackColor = true;
            this.rbThrowAway.CheckedChanged += new System.EventHandler(this.rbThrowAway_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtSourceNetWeight);
            this.groupBox2.Controls.Add(this.txtSourceEmptyWeight);
            this.groupBox2.Controls.Add(this.txtSourceFullWeight);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupBox2.Location = new System.Drawing.Point(12, 164);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(638, 107);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "اوزان مبدأ";
            this.groupBox2.EnabledChanged += new System.EventHandler(this.groupBox2_EnabledChanged);
            // 
            // txtSourceNetWeight
            // 
            this.txtSourceNetWeight.BackColor = System.Drawing.Color.Yellow;
            this.txtSourceNetWeight.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtSourceNetWeight.Location = new System.Drawing.Point(31, 47);
            this.txtSourceNetWeight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSourceNetWeight.MaxLength = 10;
            this.txtSourceNetWeight.Name = "txtSourceNetWeight";
            this.txtSourceNetWeight.ReadOnly = true;
            this.txtSourceNetWeight.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtSourceNetWeight.Size = new System.Drawing.Size(100, 23);
            this.txtSourceNetWeight.TabIndex = 1;
            this.txtSourceNetWeight.TabStop = false;
            this.txtSourceNetWeight.Text = "0";
            this.txtSourceNetWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSourceNetWeight.TextChanged += new System.EventHandler(this.txtSourceNetWeight_TextChanged);
            this.txtSourceNetWeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInvoiceNumber_KeyPress);
            // 
            // txtSourceEmptyWeight
            // 
            this.txtSourceEmptyWeight.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtSourceEmptyWeight.Location = new System.Drawing.Point(239, 47);
            this.txtSourceEmptyWeight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSourceEmptyWeight.MaxLength = 10;
            this.txtSourceEmptyWeight.Name = "txtSourceEmptyWeight";
            this.txtSourceEmptyWeight.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtSourceEmptyWeight.Size = new System.Drawing.Size(100, 23);
            this.txtSourceEmptyWeight.TabIndex = 1;
            this.txtSourceEmptyWeight.Text = "0";
            this.txtSourceEmptyWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSourceEmptyWeight.TextChanged += new System.EventHandler(this.txtSourceEmptyWeight_TextChanged);
            this.txtSourceEmptyWeight.Enter += new System.EventHandler(this.txtSourceFullWeight_Enter);
            this.txtSourceEmptyWeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInvoiceNumber_KeyPress);
            // 
            // txtSourceFullWeight
            // 
            this.txtSourceFullWeight.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtSourceFullWeight.Location = new System.Drawing.Point(444, 47);
            this.txtSourceFullWeight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSourceFullWeight.MaxLength = 10;
            this.txtSourceFullWeight.Name = "txtSourceFullWeight";
            this.txtSourceFullWeight.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtSourceFullWeight.Size = new System.Drawing.Size(100, 23);
            this.txtSourceFullWeight.TabIndex = 0;
            this.txtSourceFullWeight.Text = "0";
            this.txtSourceFullWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSourceFullWeight.TextChanged += new System.EventHandler(this.txtSourceFullWeight_TextChanged);
            this.txtSourceFullWeight.Enter += new System.EventHandler(this.txtSourceFullWeight_Enter);
            this.txtSourceFullWeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInvoiceNumber_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.Location = new System.Drawing.Point(150, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "وزن خالص:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(359, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "وزن خالی:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(565, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "وزن پر:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtNetWeight);
            this.groupBox3.Controls.Add(this.txtEmptyWeight);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txtFullWeight);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupBox3.Location = new System.Drawing.Point(12, 279);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox3.Size = new System.Drawing.Size(638, 113);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "توزین مقصد";
            // 
            // txtNetWeight
            // 
            this.txtNetWeight.BackColor = System.Drawing.Color.Yellow;
            this.txtNetWeight.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtNetWeight.Location = new System.Drawing.Point(31, 47);
            this.txtNetWeight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNetWeight.MaxLength = 10;
            this.txtNetWeight.Name = "txtNetWeight";
            this.txtNetWeight.ReadOnly = true;
            this.txtNetWeight.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtNetWeight.Size = new System.Drawing.Size(100, 23);
            this.txtNetWeight.TabIndex = 1;
            this.txtNetWeight.TabStop = false;
            this.txtNetWeight.Text = "0";
            this.txtNetWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNetWeight.TextChanged += new System.EventHandler(this.txtNetWeight_TextChanged);
            this.txtNetWeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInvoiceNumber_KeyPress);
            // 
            // txtEmptyWeight
            // 
            this.txtEmptyWeight.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtEmptyWeight.Location = new System.Drawing.Point(239, 47);
            this.txtEmptyWeight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmptyWeight.MaxLength = 10;
            this.txtEmptyWeight.Name = "txtEmptyWeight";
            this.txtEmptyWeight.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtEmptyWeight.Size = new System.Drawing.Size(100, 23);
            this.txtEmptyWeight.TabIndex = 1;
            this.txtEmptyWeight.Text = "0";
            this.txtEmptyWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtEmptyWeight.TextChanged += new System.EventHandler(this.txtEmptyWeight_TextChanged);
            this.txtEmptyWeight.Enter += new System.EventHandler(this.txtSourceFullWeight_Enter);
            this.txtEmptyWeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInvoiceNumber_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label8.Location = new System.Drawing.Point(150, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "وزن خالص:";
            // 
            // txtFullWeight
            // 
            this.txtFullWeight.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtFullWeight.Location = new System.Drawing.Point(444, 47);
            this.txtFullWeight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFullWeight.MaxLength = 10;
            this.txtFullWeight.Name = "txtFullWeight";
            this.txtFullWeight.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtFullWeight.Size = new System.Drawing.Size(100, 23);
            this.txtFullWeight.TabIndex = 0;
            this.txtFullWeight.Text = "0";
            this.txtFullWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFullWeight.TextChanged += new System.EventHandler(this.txtFullWeight_TextChanged);
            this.txtFullWeight.Enter += new System.EventHandler(this.txtSourceFullWeight_Enter);
            this.txtFullWeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInvoiceNumber_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label6.Location = new System.Drawing.Point(565, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "وزن پر:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label7.Location = new System.Drawing.Point(359, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "وزن خالی:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDigit3);
            this.groupBox1.Controls.Add(this.txtDigit2);
            this.groupBox1.Controls.Add(this.txtDigit1);
            this.groupBox1.Controls.Add(this.btnAddDriver);
            this.groupBox1.Controls.Add(this.cmbLetters);
            this.groupBox1.Controls.Add(this.cmbDrivers);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupBox1.Location = new System.Drawing.Point(12, 50);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(638, 106);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "مشخصات وسیله نقلیه";
            // 
            // txtDigit3
            // 
            this.txtDigit3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtDigit3.Location = new System.Drawing.Point(190, 54);
            this.txtDigit3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDigit3.MaxLength = 2;
            this.txtDigit3.Name = "txtDigit3";
            this.txtDigit3.Size = new System.Drawing.Size(46, 23);
            this.txtDigit3.TabIndex = 3;
            this.txtDigit3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDigit3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInvoiceNumber_KeyPress);
            // 
            // txtDigit2
            // 
            this.txtDigit2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtDigit2.Location = new System.Drawing.Point(126, 54);
            this.txtDigit2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDigit2.MaxLength = 3;
            this.txtDigit2.Name = "txtDigit2";
            this.txtDigit2.Size = new System.Drawing.Size(46, 23);
            this.txtDigit2.TabIndex = 2;
            this.txtDigit2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDigit2.TextChanged += new System.EventHandler(this.txtDigit2_TextChanged);
            this.txtDigit2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInvoiceNumber_KeyPress);
            // 
            // txtDigit1
            // 
            this.txtDigit1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtDigit1.Location = new System.Drawing.Point(16, 54);
            this.txtDigit1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDigit1.MaxLength = 2;
            this.txtDigit1.Name = "txtDigit1";
            this.txtDigit1.Size = new System.Drawing.Size(46, 23);
            this.txtDigit1.TabIndex = 0;
            this.txtDigit1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDigit1.TextChanged += new System.EventHandler(this.txtDigit1_TextChanged);
            this.txtDigit1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInvoiceNumber_KeyPress);
            // 
            // btnAddDriver
            // 
            this.btnAddDriver.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnAddDriver.Location = new System.Drawing.Point(388, 54);
            this.btnAddDriver.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddDriver.Name = "btnAddDriver";
            this.btnAddDriver.Size = new System.Drawing.Size(28, 25);
            this.btnAddDriver.TabIndex = 4;
            this.btnAddDriver.Text = "+";
            this.btnAddDriver.UseVisualStyleBackColor = true;
            this.btnAddDriver.Click += new System.EventHandler(this.btnAddDriver_Click);
            // 
            // cmbLetters
            // 
            this.cmbLetters.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLetters.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cmbLetters.FormattingEnabled = true;
            this.cmbLetters.Items.AddRange(new object[] {
            "الف",
            "ب",
            "پ",
            "ت",
            "ث",
            "ج",
            "چ",
            "ح",
            "خ",
            "د",
            "ذ",
            "ر",
            "ز",
            "ژ",
            "س",
            "ش",
            "ص",
            "ض",
            "ط",
            "ظ",
            "ع",
            "غ",
            "ف",
            "ق",
            "ک",
            "گ",
            "ل",
            "م",
            "ن",
            "و",
            "ه",
            "ی"});
            this.cmbLetters.Location = new System.Drawing.Point(68, 54);
            this.cmbLetters.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbLetters.Name = "cmbLetters";
            this.cmbLetters.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbLetters.Size = new System.Drawing.Size(52, 24);
            this.cmbLetters.TabIndex = 1;
            // 
            // cmbDrivers
            // 
            this.cmbDrivers.DropDownHeight = 200;
            this.cmbDrivers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDrivers.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cmbDrivers.FormattingEnabled = true;
            this.cmbDrivers.IntegralHeight = false;
            this.cmbDrivers.ItemHeight = 16;
            this.cmbDrivers.Location = new System.Drawing.Point(422, 54);
            this.cmbDrivers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbDrivers.Name = "cmbDrivers";
            this.cmbDrivers.Size = new System.Drawing.Size(140, 24);
            this.cmbDrivers.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label9.Location = new System.Drawing.Point(175, 57);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 16);
            this.label9.TabIndex = 0;
            this.label9.Text = "-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(239, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "شماره وسیله نقلیه:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(568, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "راننده:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtOrderDetails);
            this.groupBox4.Controls.Add(this.btnSelectOrder);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.cmbProductTypes);
            this.groupBox4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupBox4.Location = new System.Drawing.Point(12, 399);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox4.Size = new System.Drawing.Size(639, 89);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "مشخصات کالا";
            this.groupBox4.EnabledChanged += new System.EventHandler(this.groupBox4_EnabledChanged);
            // 
            // txtOrderDetails
            // 
            this.txtOrderDetails.BackColor = System.Drawing.SystemColors.Window;
            this.txtOrderDetails.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtOrderDetails.Location = new System.Drawing.Point(16, 41);
            this.txtOrderDetails.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtOrderDetails.Name = "txtOrderDetails";
            this.txtOrderDetails.ReadOnly = true;
            this.txtOrderDetails.Size = new System.Drawing.Size(301, 23);
            this.txtOrderDetails.TabIndex = 2;
            this.txtOrderDetails.TabStop = false;
            // 
            // btnSelectOrder
            // 
            this.btnSelectOrder.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnSelectOrder.Location = new System.Drawing.Point(327, 39);
            this.btnSelectOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSelectOrder.Name = "btnSelectOrder";
            this.btnSelectOrder.Size = new System.Drawing.Size(90, 26);
            this.btnSelectOrder.TabIndex = 1;
            this.btnSelectOrder.Text = "انتخاب حواله";
            this.btnSelectOrder.UseVisualStyleBackColor = true;
            this.btnSelectOrder.Click += new System.EventHandler(this.btnSelectOrder_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label10.Location = new System.Drawing.Point(574, 43);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 16);
            this.label10.TabIndex = 0;
            this.label10.Text = "نوع کالا:";
            // 
            // cmbProductTypes
            // 
            this.cmbProductTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProductTypes.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cmbProductTypes.FormattingEnabled = true;
            this.cmbProductTypes.Location = new System.Drawing.Point(423, 39);
            this.cmbProductTypes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbProductTypes.Name = "cmbProductTypes";
            this.cmbProductTypes.Size = new System.Drawing.Size(140, 24);
            this.cmbProductTypes.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(335, 18);
            this.label11.Name = "label11";
            this.label11.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label11.Size = new System.Drawing.Size(78, 16);
            this.label11.TabIndex = 0;
            this.label11.Text = "شماره سند:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(169, 18);
            this.label12.Name = "label12";
            this.label12.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label12.Size = new System.Drawing.Size(39, 16);
            this.label12.TabIndex = 0;
            this.label12.Text = "تاریخ:";
            // 
            // txtInvoiceNumber
            // 
            this.txtInvoiceNumber.BackColor = System.Drawing.SystemColors.Window;
            this.txtInvoiceNumber.Location = new System.Drawing.Point(230, 16);
            this.txtInvoiceNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtInvoiceNumber.MaxLength = 10;
            this.txtInvoiceNumber.Name = "txtInvoiceNumber";
            this.txtInvoiceNumber.ReadOnly = true;
            this.txtInvoiceNumber.Size = new System.Drawing.Size(100, 23);
            this.txtInvoiceNumber.TabIndex = 0;
            this.txtInvoiceNumber.TabStop = false;
            this.txtInvoiceNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtInvoiceNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInvoiceNumber_KeyPress);
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(63, 16);
            this.txtDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDate.Mask = "0000/00/00";
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(100, 23);
            this.txtDate.TabIndex = 1;
            this.txtDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDate.ValidatingType = typeof(System.DateTime);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(12, 494);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 25);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "ذخیره";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(93, 494);
            this.btnNew.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 25);
            this.btnNew.TabIndex = 7;
            this.btnNew.Text = "جدید";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnToday
            // 
            this.btnToday.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnToday.Location = new System.Drawing.Point(12, 15);
            this.btnToday.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnToday.Name = "btnToday";
            this.btnToday.Size = new System.Drawing.Size(50, 25);
            this.btnToday.TabIndex = 0;
            this.btnToday.Text = "امروز";
            this.btnToday.UseVisualStyleBackColor = true;
            this.btnToday.Click += new System.EventHandler(this.btnToday_Click);
            // 
            // frmInvoices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 530);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.btnToday);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.txtInvoiceNumber);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.rbThrowAway);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rbExport);
            this.Controls.Add(this.rbImport);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmInvoices";
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "توزین";
            this.Load += new System.EventHandler(this.frmInvoices_Load);
            this.Shown += new System.EventHandler(this.frmInvoices_Shown);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbImport;
        private System.Windows.Forms.RadioButton rbExport;
        private System.Windows.Forms.RadioButton rbThrowAway;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDigit3;
        private System.Windows.Forms.TextBox txtDigit2;
        private System.Windows.Forms.TextBox txtDigit1;
        private System.Windows.Forms.Button btnAddDriver;
        private System.Windows.Forms.ComboBox cmbLetters;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbDrivers;
        private System.Windows.Forms.TextBox txtSourceNetWeight;
        private System.Windows.Forms.TextBox txtSourceEmptyWeight;
        private System.Windows.Forms.TextBox txtSourceFullWeight;
        private System.Windows.Forms.TextBox txtNetWeight;
        private System.Windows.Forms.TextBox txtEmptyWeight;
        private System.Windows.Forms.TextBox txtFullWeight;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtOrderDetails;
        private System.Windows.Forms.Button btnSelectOrder;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbProductTypes;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtInvoiceNumber;
        private System.Windows.Forms.MaskedTextBox txtDate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnToday;
    }
}