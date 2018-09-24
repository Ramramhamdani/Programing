namespace _1._9
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtMembership = new System.Windows.Forms.TextBox();
            this.btnCalculation = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblFeePaid = new System.Windows.Forms.Label();
            this.rbtnFootball = new System.Windows.Forms.RadioButton();
            this.rbtnHandball = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "sport";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Age";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Membership duration";
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(161, 111);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(100, 20);
            this.txtAge.TabIndex = 6;
            this.txtAge.TextChanged += new System.EventHandler(this.txtAge_TextChanged);
            // 
            // txtMembership
            // 
            this.txtMembership.Location = new System.Drawing.Point(161, 156);
            this.txtMembership.Name = "txtMembership";
            this.txtMembership.Size = new System.Drawing.Size(100, 20);
            this.txtMembership.TabIndex = 7;
            this.txtMembership.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btnCalculation
            // 
            this.btnCalculation.Location = new System.Drawing.Point(40, 215);
            this.btnCalculation.Name = "btnCalculation";
            this.btnCalculation.Size = new System.Drawing.Size(221, 42);
            this.btnCalculation.TabIndex = 8;
            this.btnCalculation.Text = "&Calculation Fee";
            this.btnCalculation.UseVisualStyleBackColor = true;
            this.btnCalculation.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Fee to be paid";
            // 
            // lblFeePaid
            // 
            this.lblFeePaid.AutoSize = true;
            this.lblFeePaid.Location = new System.Drawing.Point(207, 276);
            this.lblFeePaid.Name = "lblFeePaid";
            this.lblFeePaid.Size = new System.Drawing.Size(16, 13);
            this.lblFeePaid.TabIndex = 10;
            this.lblFeePaid.Text = "...";
            this.lblFeePaid.Click += new System.EventHandler(this.lblFeePaid_Click);
            // 
            // rbtnFootball
            // 
            this.rbtnFootball.AutoSize = true;
            this.rbtnFootball.Location = new System.Drawing.Point(181, 34);
            this.rbtnFootball.Name = "rbtnFootball";
            this.rbtnFootball.Size = new System.Drawing.Size(62, 17);
            this.rbtnFootball.TabIndex = 11;
            this.rbtnFootball.TabStop = true;
            this.rbtnFootball.Text = "Football";
            this.rbtnFootball.UseVisualStyleBackColor = true;
            this.rbtnFootball.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rbtnHandball
            // 
            this.rbtnHandball.AutoSize = true;
            this.rbtnHandball.Location = new System.Drawing.Point(181, 57);
            this.rbtnHandball.Name = "rbtnHandball";
            this.rbtnHandball.Size = new System.Drawing.Size(67, 17);
            this.rbtnHandball.TabIndex = 12;
            this.rbtnHandball.TabStop = true;
            this.rbtnHandball.Text = "Handball";
            this.rbtnHandball.UseVisualStyleBackColor = true;
            this.rbtnHandball.CheckedChanged += new System.EventHandler(this.rbtnHandball_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 326);
            this.Controls.Add(this.rbtnHandball);
            this.Controls.Add(this.rbtnFootball);
            this.Controls.Add(this.lblFeePaid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCalculation);
            this.Controls.Add(this.txtMembership);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtMembership;
        private System.Windows.Forms.Button btnCalculation;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblFeePaid;
        private System.Windows.Forms.RadioButton rbtnFootball;
        private System.Windows.Forms.RadioButton rbtnHandball;
    }
}

