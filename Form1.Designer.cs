namespace CSharp_chuongtrinhtinhcanchi
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblnam = new System.Windows.Forms.Label();
            this.txtnam = new System.Windows.Forms.TextBox();
            this.lblkq = new System.Windows.Forms.Label();
            this.txtkq = new System.Windows.Forms.TextBox();
            this.btntinh = new System.Windows.Forms.Button();
            this.lbskq = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(440, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "CHƯƠNG TRÌNH TÍNH CAN CHI";
            // 
            // lblnam
            // 
            this.lblnam.AutoSize = true;
            this.lblnam.Location = new System.Drawing.Point(89, 121);
            this.lblnam.Name = "lblnam";
            this.lblnam.Size = new System.Drawing.Size(42, 19);
            this.lblnam.TabIndex = 1;
            this.lblnam.Text = "Năm";
            // 
            // txtnam
            // 
            this.txtnam.Location = new System.Drawing.Point(236, 113);
            this.txtnam.Name = "txtnam";
            this.txtnam.Size = new System.Drawing.Size(100, 27);
            this.txtnam.TabIndex = 2;
            // 
            // lblkq
            // 
            this.lblkq.AutoSize = true;
            this.lblkq.Location = new System.Drawing.Point(89, 198);
            this.lblkq.Name = "lblkq";
            this.lblkq.Size = new System.Drawing.Size(62, 19);
            this.lblkq.TabIndex = 3;
            this.lblkq.Text = "Kết quả";
            // 
            // txtkq
            // 
            this.txtkq.Location = new System.Drawing.Point(236, 190);
            this.txtkq.Name = "txtkq";
            this.txtkq.Size = new System.Drawing.Size(100, 27);
            this.txtkq.TabIndex = 4;
            // 
            // btntinh
            // 
            this.btntinh.Location = new System.Drawing.Point(236, 266);
            this.btntinh.Name = "btntinh";
            this.btntinh.Size = new System.Drawing.Size(82, 29);
            this.btntinh.TabIndex = 5;
            this.btntinh.Text = "Tính";
            this.btntinh.UseVisualStyleBackColor = true;
            this.btntinh.Click += new System.EventHandler(this.btntinh_Click);
            // 
            // lbskq
            // 
            this.lbskq.FormattingEnabled = true;
            this.lbskq.ItemHeight = 19;
            this.lbskq.Location = new System.Drawing.Point(521, 113);
            this.lbskq.Name = "lbskq";
            this.lbskq.Size = new System.Drawing.Size(311, 213);
            this.lbskq.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SpringGreen;
            this.ClientSize = new System.Drawing.Size(1200, 658);
            this.Controls.Add(this.lbskq);
            this.Controls.Add(this.btntinh);
            this.Controls.Add(this.txtkq);
            this.Controls.Add(this.lblkq);
            this.Controls.Add(this.txtnam);
            this.Controls.Add(this.lblnam);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblnam;
        private System.Windows.Forms.TextBox txtnam;
        private System.Windows.Forms.Label lblkq;
        private System.Windows.Forms.TextBox txtkq;
        private System.Windows.Forms.Button btntinh;
        private System.Windows.Forms.ListBox lbskq;
    }
}

