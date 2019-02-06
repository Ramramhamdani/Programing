namespace _1._10
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
            this.txtsalary = new System.Windows.Forms.TextBox();
            this.btncal = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblraise = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblnew = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "current monthly salary";
            // 
            // txtsalary
            // 
            this.txtsalary.Location = new System.Drawing.Point(199, 44);
            this.txtsalary.Name = "txtsalary";
            this.txtsalary.Size = new System.Drawing.Size(100, 20);
            this.txtsalary.TabIndex = 1;
            this.txtsalary.TextChanged += new System.EventHandler(this.txtsalary_TextChanged);
            // 
            // btncal
            // 
            this.btncal.Location = new System.Drawing.Point(23, 103);
            this.btncal.Name = "btncal";
            this.btncal.Size = new System.Drawing.Size(276, 33);
            this.btncal.TabIndex = 2;
            this.btncal.Text = "&Calculate raise";
            this.btncal.UseVisualStyleBackColor = true;
            this.btncal.Click += new System.EventHandler(this.btncal_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Raise";
            // 
            // lblraise
            // 
            this.lblraise.AutoSize = true;
            this.lblraise.Location = new System.Drawing.Point(256, 185);
            this.lblraise.Name = "lblraise";
            this.lblraise.Size = new System.Drawing.Size(0, 13);
            this.lblraise.TabIndex = 4;
            this.lblraise.Click += new System.EventHandler(this.lblraise_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "new monthly salary";
            // 
            // lblnew
            // 
            this.lblnew.AutoSize = true;
            this.lblnew.Location = new System.Drawing.Point(247, 223);
            this.lblnew.Name = "lblnew";
            this.lblnew.Size = new System.Drawing.Size(0, 13);
            this.lblnew.TabIndex = 6;
            this.lblnew.Click += new System.EventHandler(this.lblnew_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 274);
            this.Controls.Add(this.lblnew);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblraise);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btncal);
            this.Controls.Add(this.txtsalary);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Assaignment 10";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtsalary;
        private System.Windows.Forms.Button btncal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblraise;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblnew;
    }
}

