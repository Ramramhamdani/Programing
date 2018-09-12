namespace _1._6
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
            this.txtseconds = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTimeIO = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(93, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "seconds";
            // 
            // txtseconds
            // 
            this.txtseconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtseconds.Location = new System.Drawing.Point(351, 71);
            this.txtseconds.Name = "txtseconds";
            this.txtseconds.Size = new System.Drawing.Size(236, 30);
            this.txtseconds.TabIndex = 1;
            this.txtseconds.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.Location = new System.Drawing.Point(187, 176);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(265, 53);
            this.button1.TabIndex = 2;
            this.button1.Text = "Calculate time";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(96, 272);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "hours:minutes:seconds";
            // 
            // lblTimeIO
            // 
            this.lblTimeIO.AutoSize = true;
            this.lblTimeIO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTimeIO.Location = new System.Drawing.Point(96, 319);
            this.lblTimeIO.Name = "lblTimeIO";
            this.lblTimeIO.Size = new System.Drawing.Size(74, 25);
            this.lblTimeIO.TabIndex = 4;
            this.lblTimeIO.Text = ".. : .. : ..";
            this.lblTimeIO.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 435);
            this.Controls.Add(this.lblTimeIO);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtseconds);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtseconds;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTimeIO;
    }
}

