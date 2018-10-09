namespace _5._6
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
            this.lblbefore = new System.Windows.Forms.Label();
            this.lblafter = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtnumber = new System.Windows.Forms.TextBox();
            this.btncompare = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Content table (before)";
            // 
            // lblbefore
            // 
            this.lblbefore.AutoSize = true;
            this.lblbefore.Location = new System.Drawing.Point(12, 58);
            this.lblbefore.Name = "lblbefore";
            this.lblbefore.Size = new System.Drawing.Size(35, 13);
            this.lblbefore.TabIndex = 1;
            this.lblbefore.Text = "label2";
            this.lblbefore.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblafter
            // 
            this.lblafter.AutoSize = true;
            this.lblafter.Location = new System.Drawing.Point(222, 58);
            this.lblafter.Name = "lblafter";
            this.lblafter.Size = new System.Drawing.Size(35, 13);
            this.lblafter.TabIndex = 2;
            this.lblafter.Text = "label3";
            this.lblafter.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(222, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Content table (after)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 350);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Comparison number";
            // 
            // txtnumber
            // 
            this.txtnumber.Location = new System.Drawing.Point(161, 347);
            this.txtnumber.Name = "txtnumber";
            this.txtnumber.Size = new System.Drawing.Size(54, 20);
            this.txtnumber.TabIndex = 5;
            this.txtnumber.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btncompare
            // 
            this.btncompare.Location = new System.Drawing.Point(255, 345);
            this.btncompare.Name = "btncompare";
            this.btncompare.Size = new System.Drawing.Size(75, 23);
            this.btncompare.TabIndex = 6;
            this.btncompare.Text = "&Compare";
            this.btncompare.UseVisualStyleBackColor = true;
            this.btncompare.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 380);
            this.Controls.Add(this.btncompare);
            this.Controls.Add(this.txtnumber);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblafter);
            this.Controls.Add(this.lblbefore);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Assignment 5.6";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblbefore;
        private System.Windows.Forms.Label lblafter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtnumber;
        private System.Windows.Forms.Button btncompare;
    }
}

