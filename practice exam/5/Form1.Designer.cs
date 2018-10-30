namespace _5
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
            this.button1 = new System.Windows.Forms.Button();
            this.lblkm = new System.Windows.Forms.Label();
            this.txth = new System.Windows.Forms.TextBox();
            this.txtm = new System.Windows.Forms.TextBox();
            this.txtsec = new System.Windows.Forms.TextBox();
            this.rbtn1 = new System.Windows.Forms.RadioButton();
            this.rbtn2 = new System.Windows.Forms.RadioButton();
            this.rbtn3 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(178, 296);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblkm
            // 
            this.lblkm.AutoSize = true;
            this.lblkm.Location = new System.Drawing.Point(358, 374);
            this.lblkm.Name = "lblkm";
            this.lblkm.Size = new System.Drawing.Size(46, 17);
            this.lblkm.TabIndex = 1;
            this.lblkm.Text = "label1";
            // 
            // txth
            // 
            this.txth.Location = new System.Drawing.Point(80, 156);
            this.txth.Name = "txth";
            this.txth.Size = new System.Drawing.Size(43, 22);
            this.txth.TabIndex = 2;
            this.txth.TextChanged += new System.EventHandler(this.txth_TextChanged);
            // 
            // txtm
            // 
            this.txtm.Location = new System.Drawing.Point(247, 155);
            this.txtm.Name = "txtm";
            this.txtm.Size = new System.Drawing.Size(39, 22);
            this.txtm.TabIndex = 3;
            this.txtm.TextChanged += new System.EventHandler(this.txtm_TextChanged);
            // 
            // txtsec
            // 
            this.txtsec.Location = new System.Drawing.Point(497, 155);
            this.txtsec.Name = "txtsec";
            this.txtsec.Size = new System.Drawing.Size(46, 22);
            this.txtsec.TabIndex = 4;
            this.txtsec.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // rbtn1
            // 
            this.rbtn1.AutoSize = true;
            this.rbtn1.Location = new System.Drawing.Point(80, 70);
            this.rbtn1.Name = "rbtn1";
            this.rbtn1.Size = new System.Drawing.Size(110, 21);
            this.rbtn1.TabIndex = 5;
            this.rbtn1.TabStop = true;
            this.rbtn1.Text = "radioButton1";
            this.rbtn1.UseVisualStyleBackColor = true;
            this.rbtn1.CheckedChanged += new System.EventHandler(this.Rbtn1_CheckedChanged);
            // 
            // rbtn2
            // 
            this.rbtn2.AutoSize = true;
            this.rbtn2.Location = new System.Drawing.Point(247, 70);
            this.rbtn2.Name = "rbtn2";
            this.rbtn2.Size = new System.Drawing.Size(110, 21);
            this.rbtn2.TabIndex = 6;
            this.rbtn2.TabStop = true;
            this.rbtn2.Text = "radioButton2";
            this.rbtn2.UseVisualStyleBackColor = true;
            this.rbtn2.CheckedChanged += new System.EventHandler(this.rbtn2_CheckedChanged);
            // 
            // rbtn3
            // 
            this.rbtn3.AutoSize = true;
            this.rbtn3.Location = new System.Drawing.Point(497, 70);
            this.rbtn3.Name = "rbtn3";
            this.rbtn3.Size = new System.Drawing.Size(110, 21);
            this.rbtn3.TabIndex = 7;
            this.rbtn3.TabStop = true;
            this.rbtn3.Text = "radioButton3";
            this.rbtn3.UseVisualStyleBackColor = true;
            this.rbtn3.CheckedChanged += new System.EventHandler(this.rbtn3_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rbtn3);
            this.Controls.Add(this.rbtn2);
            this.Controls.Add(this.rbtn1);
            this.Controls.Add(this.txtsec);
            this.Controls.Add(this.txtm);
            this.Controls.Add(this.txth);
            this.Controls.Add(this.lblkm);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblkm;
        private System.Windows.Forms.TextBox txth;
        private System.Windows.Forms.TextBox txtm;
        private System.Windows.Forms.TextBox txtsec;
        private System.Windows.Forms.RadioButton rbtn1;
        private System.Windows.Forms.RadioButton rbtn2;
        private System.Windows.Forms.RadioButton rbtn3;
    }
}

