namespace _1._8
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtTprice = new System.Windows.Forms.TextBox();
            this.txtJprice = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTotalprice = new System.Windows.Forms.Label();
            this.txtVAT = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lbltime = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of T-shirts (*€30.00)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Number of jeans(*€100.00)";
            // 
            // txtTprice
            // 
            this.txtTprice.Location = new System.Drawing.Point(290, 42);
            this.txtTprice.Name = "txtTprice";
            this.txtTprice.Size = new System.Drawing.Size(177, 22);
            this.txtTprice.TabIndex = 2;
            this.txtTprice.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtJprice
            // 
            this.txtJprice.Location = new System.Drawing.Point(290, 82);
            this.txtJprice.Name = "txtJprice";
            this.txtJprice.Size = new System.Drawing.Size(177, 22);
            this.txtJprice.TabIndex = 3;
            this.txtJprice.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbltime);
            this.groupBox1.Controls.Add(this.txtTotalprice);
            this.groupBox1.Controls.Add(this.txtVAT);
            this.groupBox1.Controls.Add(this.txtPrice);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 283);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(495, 242);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "inovice";
            // 
            // txtTotalprice
            // 
            this.txtTotalprice.AutoSize = true;
            this.txtTotalprice.Location = new System.Drawing.Point(392, 190);
            this.txtTotalprice.Name = "txtTotalprice";
            this.txtTotalprice.Size = new System.Drawing.Size(20, 17);
            this.txtTotalprice.TabIndex = 7;
            this.txtTotalprice.Text = "...";
            this.txtTotalprice.Click += new System.EventHandler(this.txtTotalprice_Click);
            // 
            // txtVAT
            // 
            this.txtVAT.AutoSize = true;
            this.txtVAT.Location = new System.Drawing.Point(392, 125);
            this.txtVAT.Name = "txtVAT";
            this.txtVAT.Size = new System.Drawing.Size(20, 17);
            this.txtVAT.TabIndex = 6;
            this.txtVAT.Text = "...";
            this.txtVAT.Click += new System.EventHandler(this.txtVAT_Click);
            // 
            // txtPrice
            // 
            this.txtPrice.AutoSize = true;
            this.txtPrice.Location = new System.Drawing.Point(392, 76);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(20, 17);
            this.txtPrice.TabIndex = 5;
            this.txtPrice.Text = "...";
            this.txtPrice.Click += new System.EventHandler(this.txtPrice_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Total price:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "VAT:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Price:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Date:";
            // 
            // button1
            // 
            this.button1.Image = global::_1._8.Properties.Resources.Capture2;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(29, 173);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button1.Size = new System.Drawing.Size(276, 57);
            this.button1.TabIndex = 4;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbltime
            // 
            this.lbltime.AutoSize = true;
            this.lbltime.Location = new System.Drawing.Point(356, 30);
            this.lbltime.Name = "lbltime";
            this.lbltime.Size = new System.Drawing.Size(56, 17);
            this.lbltime.TabIndex = 8;
            this.lbltime.Text = ".. : .. : ..";
            this.lbltime.Click += new System.EventHandler(this.lbltime_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 537);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtJprice);
            this.Controls.Add(this.txtTprice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTprice;
        private System.Windows.Forms.TextBox txtJprice;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label txtTotalprice;
        private System.Windows.Forms.Label txtVAT;
        private System.Windows.Forms.Label txtPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbltime;
    }
}

