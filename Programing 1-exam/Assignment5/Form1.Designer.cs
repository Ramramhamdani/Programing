namespace Assignment5
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
            this.txtAge = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rbtnStar = new System.Windows.Forms.RadioButton();
            this.rbtnJohn = new System.Windows.Forms.RadioButton();
            this.rbtnPepp = new System.Windows.Forms.RadioButton();
            this.btnCal = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Age";
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(178, 28);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(100, 22);
            this.txtAge.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Movie";
            // 
            // rbtnStar
            // 
            this.rbtnStar.AutoSize = true;
            this.rbtnStar.Location = new System.Drawing.Point(178, 139);
            this.rbtnStar.Name = "rbtnStar";
            this.rbtnStar.Size = new System.Drawing.Size(113, 21);
            this.rbtnStar.TabIndex = 3;
            this.rbtnStar.TabStop = true;
            this.rbtnStar.Text = "A star is bron";
            this.rbtnStar.UseVisualStyleBackColor = true;
            // 
            // rbtnJohn
            // 
            this.rbtnJohn.AutoSize = true;
            this.rbtnJohn.Location = new System.Drawing.Point(178, 166);
            this.rbtnJohn.Name = "rbtnJohn";
            this.rbtnJohn.Size = new System.Drawing.Size(212, 21);
            this.rbtnJohn.TabIndex = 4;
            this.rbtnJohn.TabStop = true;
            this.rbtnJohn.Text = "Johnny English Strikes Again";
            this.rbtnJohn.UseVisualStyleBackColor = true;
            // 
            // rbtnPepp
            // 
            this.rbtnPepp.AutoSize = true;
            this.rbtnPepp.Location = new System.Drawing.Point(178, 193);
            this.rbtnPepp.Name = "rbtnPepp";
            this.rbtnPepp.Size = new System.Drawing.Size(101, 21);
            this.rbtnPepp.TabIndex = 5;
            this.rbtnPepp.TabStop = true;
            this.rbtnPepp.Text = "Peppermint";
            this.rbtnPepp.UseVisualStyleBackColor = true;
            // 
            // btnCal
            // 
            this.btnCal.Location = new System.Drawing.Point(178, 248);
            this.btnCal.Name = "btnCal";
            this.btnCal.Size = new System.Drawing.Size(128, 38);
            this.btnCal.TabIndex = 6;
            this.btnCal.Text = "Calculate price";
            this.btnCal.UseVisualStyleBackColor = true;
            this.btnCal.Click += new System.EventHandler(this.btnCal_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 339);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Price";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(175, 339);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(12, 17);
            this.lblPrice.TabIndex = 8;
            this.lblPrice.Text = " ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 379);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCal);
            this.Controls.Add(this.rbtnPepp);
            this.Controls.Add(this.rbtnJohn);
            this.Controls.Add(this.rbtnStar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Assignment5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbtnStar;
        private System.Windows.Forms.RadioButton rbtnJohn;
        private System.Windows.Forms.RadioButton rbtnPepp;
        private System.Windows.Forms.Button btnCal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPrice;
    }
}

