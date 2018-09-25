namespace _1._12
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
            this.txtage = new System.Windows.Forms.TextBox();
            this.btncal = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblprice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Age";
            // 
            // txtage
            // 
            this.txtage.Location = new System.Drawing.Point(161, 25);
            this.txtage.Name = "txtage";
            this.txtage.Size = new System.Drawing.Size(100, 20);
            this.txtage.TabIndex = 1;
            // 
            // btncal
            // 
            this.btncal.Location = new System.Drawing.Point(31, 89);
            this.btncal.Name = "btncal";
            this.btncal.Size = new System.Drawing.Size(230, 23);
            this.btncal.TabIndex = 2;
            this.btncal.Text = "&Calculate price";
            this.btncal.UseVisualStyleBackColor = true;
            this.btncal.Click += new System.EventHandler(this.btncal_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Price ticket";
            // 
            // lblprice
            // 
            this.lblprice.AutoSize = true;
            this.lblprice.Location = new System.Drawing.Point(158, 163);
            this.lblprice.Name = "lblprice";
            this.lblprice.Size = new System.Drawing.Size(43, 13);
            this.lblprice.TabIndex = 4;
            this.lblprice.Text = "€ 12.00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 209);
            this.Controls.Add(this.lblprice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btncal);
            this.Controls.Add(this.txtage);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Assaignment 12";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtage;
        private System.Windows.Forms.Button btncal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblprice;
    }
}

