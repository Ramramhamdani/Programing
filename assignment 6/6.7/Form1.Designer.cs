namespace _6._7
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
            this.lblResult = new System.Windows.Forms.Label();
            this.txtnumber = new System.Windows.Forms.TextBox();
            this.btnCal = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnCtoK = new System.Windows.Forms.RadioButton();
            this.rbtnCtoF = new System.Windows.Forms.RadioButton();
            this.rbtnFtoC = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Degrees";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 304);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Converted degrees";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(242, 303);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 13);
            this.lblResult.TabIndex = 2;
            this.lblResult.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtnumber
            // 
            this.txtnumber.Location = new System.Drawing.Point(218, 35);
            this.txtnumber.Name = "txtnumber";
            this.txtnumber.Size = new System.Drawing.Size(100, 20);
            this.txtnumber.TabIndex = 3;
            this.txtnumber.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnCal
            // 
            this.btnCal.Location = new System.Drawing.Point(109, 249);
            this.btnCal.Name = "btnCal";
            this.btnCal.Size = new System.Drawing.Size(75, 23);
            this.btnCal.TabIndex = 4;
            this.btnCal.Text = "&Calculate";
            this.btnCal.UseVisualStyleBackColor = true;
            this.btnCal.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnFtoC);
            this.groupBox1.Controls.Add(this.rbtnCtoF);
            this.groupBox1.Controls.Add(this.rbtnCtoK);
            this.groupBox1.Location = new System.Drawing.Point(33, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(232, 120);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "conversion";
            // 
            // rbtnCtoK
            // 
            this.rbtnCtoK.AutoSize = true;
            this.rbtnCtoK.Location = new System.Drawing.Point(23, 30);
            this.rbtnCtoK.Name = "rbtnCtoK";
            this.rbtnCtoK.Size = new System.Drawing.Size(105, 17);
            this.rbtnCtoK.TabIndex = 0;
            this.rbtnCtoK.TabStop = true;
            this.rbtnCtoK.Text = " Celsius to Kelvin";
            this.rbtnCtoK.UseVisualStyleBackColor = true;
            this.rbtnCtoK.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rbtnCtoF
            // 
            this.rbtnCtoF.AutoSize = true;
            this.rbtnCtoF.Location = new System.Drawing.Point(23, 54);
            this.rbtnCtoF.Name = "rbtnCtoF";
            this.rbtnCtoF.Size = new System.Drawing.Size(126, 17);
            this.rbtnCtoF.TabIndex = 1;
            this.rbtnCtoF.TabStop = true;
            this.rbtnCtoF.Text = " Celsius to Fahrenheit";
            this.rbtnCtoF.UseVisualStyleBackColor = true;
            this.rbtnCtoF.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rbtnFtoC
            // 
            this.rbtnFtoC.AutoSize = true;
            this.rbtnFtoC.Location = new System.Drawing.Point(23, 78);
            this.rbtnFtoC.Name = "rbtnFtoC";
            this.rbtnFtoC.Size = new System.Drawing.Size(126, 17);
            this.rbtnFtoC.TabIndex = 2;
            this.rbtnFtoC.TabStop = true;
            this.rbtnFtoC.Text = " Fahrenheit to Celsius";
            this.rbtnFtoC.UseVisualStyleBackColor = true;
            this.rbtnFtoC.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 356);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCal);
            this.Controls.Add(this.txtnumber);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox txtnumber;
        private System.Windows.Forms.Button btnCal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnFtoC;
        private System.Windows.Forms.RadioButton rbtnCtoF;
        private System.Windows.Forms.RadioButton rbtnCtoK;
    }
}

