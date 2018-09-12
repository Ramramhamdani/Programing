namespace _1._5
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
            this.txt1st = new System.Windows.Forms.TextBox();
            this.txt2nd = new System.Windows.Forms.TextBox();
            this.txt3rd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblAverage = new System.Windows.Forms.Label();
            this.btnAverage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(76, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "1st number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(76, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "2nd number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.Location = new System.Drawing.Point(76, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "3rd number";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txt1st
            // 
            this.txt1st.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txt1st.Location = new System.Drawing.Point(323, 62);
            this.txt1st.Name = "txt1st";
            this.txt1st.Size = new System.Drawing.Size(100, 34);
            this.txt1st.TabIndex = 3;
            this.txt1st.TextChanged += new System.EventHandler(this.txt1st_TextChanged);
            // 
            // txt2nd
            // 
            this.txt2nd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txt2nd.Location = new System.Drawing.Point(323, 119);
            this.txt2nd.Name = "txt2nd";
            this.txt2nd.Size = new System.Drawing.Size(100, 34);
            this.txt2nd.TabIndex = 4;
            this.txt2nd.TextChanged += new System.EventHandler(this.txt2nd_TextChanged);
            // 
            // txt3rd
            // 
            this.txt3rd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txt3rd.Location = new System.Drawing.Point(323, 179);
            this.txt3rd.Name = "txt3rd";
            this.txt3rd.Size = new System.Drawing.Size(100, 34);
            this.txt3rd.TabIndex = 5;
            this.txt3rd.TextChanged += new System.EventHandler(this.txt3rd_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label4.Location = new System.Drawing.Point(76, 375);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "Average";
            // 
            // lblAverage
            // 
            this.lblAverage.AutoSize = true;
            this.lblAverage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblAverage.Location = new System.Drawing.Point(318, 375);
            this.lblAverage.Name = "lblAverage";
            this.lblAverage.Size = new System.Drawing.Size(79, 29);
            this.lblAverage.TabIndex = 7;
            this.lblAverage.Text = "label5";
            this.lblAverage.Click += new System.EventHandler(this.lblAverage_Click);
            // 
            // btnAverage
            // 
            this.btnAverage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnAverage.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnAverage.Location = new System.Drawing.Point(144, 272);
            this.btnAverage.Name = "btnAverage";
            this.btnAverage.Size = new System.Drawing.Size(232, 60);
            this.btnAverage.TabIndex = 8;
            this.btnAverage.Text = "Caculate Average";
            this.btnAverage.UseVisualStyleBackColor = true;
            this.btnAverage.Click += new System.EventHandler(this.btnAverage_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 489);
            this.Controls.Add(this.btnAverage);
            this.Controls.Add(this.lblAverage);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt3rd);
            this.Controls.Add(this.txt2nd);
            this.Controls.Add(this.txt1st);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt1st;
        private System.Windows.Forms.TextBox txt2nd;
        private System.Windows.Forms.TextBox txt3rd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblAverage;
        private System.Windows.Forms.Button btnAverage;
    }
}

