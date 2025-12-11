
namespace TowzinSaravan.App.Invoices
{
    partial class frmFullOrEmpty
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
            this.btnFullWeight = new System.Windows.Forms.Button();
            this.btnEmptyWeight = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFullWeight
            // 
            this.btnFullWeight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnFullWeight.Location = new System.Drawing.Point(27, 46);
            this.btnFullWeight.Margin = new System.Windows.Forms.Padding(4);
            this.btnFullWeight.Name = "btnFullWeight";
            this.btnFullWeight.Size = new System.Drawing.Size(125, 52);
            this.btnFullWeight.TabIndex = 0;
            this.btnFullWeight.Text = "وزن پر";
            this.btnFullWeight.UseVisualStyleBackColor = false;
            this.btnFullWeight.Click += new System.EventHandler(this.btnFullWeight_Click);
            // 
            // btnEmptyWeight
            // 
            this.btnEmptyWeight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnEmptyWeight.Location = new System.Drawing.Point(173, 46);
            this.btnEmptyWeight.Margin = new System.Windows.Forms.Padding(4);
            this.btnEmptyWeight.Name = "btnEmptyWeight";
            this.btnEmptyWeight.Size = new System.Drawing.Size(125, 52);
            this.btnEmptyWeight.TabIndex = 0;
            this.btnEmptyWeight.Text = " وزن خالی";
            this.btnEmptyWeight.UseVisualStyleBackColor = false;
            this.btnEmptyWeight.Click += new System.EventHandler(this.btnEmptyWeight_Click);
            // 
            // frmFullOrEmpty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(333, 142);
            this.Controls.Add(this.btnEmptyWeight);
            this.Controls.Add(this.btnFullWeight);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmFullOrEmpty";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmFullOrEmpty";
            this.Load += new System.EventHandler(this.frmFullOrEmpty_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFullWeight;
        private System.Windows.Forms.Button btnEmptyWeight;
    }
}