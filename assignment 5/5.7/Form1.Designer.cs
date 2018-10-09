namespace _5._7
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
            this.lblAnswer = new System.Windows.Forms.Label();
            this.btnThrow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblAnswer.Location = new System.Drawing.Point(26, 28);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(46, 17);
            this.lblAnswer.TabIndex = 0;
            this.lblAnswer.Text = "label1";
            this.lblAnswer.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnThrow
            // 
            this.btnThrow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnThrow.Location = new System.Drawing.Point(128, 192);
            this.btnThrow.Name = "btnThrow";
            this.btnThrow.Size = new System.Drawing.Size(75, 23);
            this.btnThrow.TabIndex = 1;
            this.btnThrow.Text = "&Throw";
            this.btnThrow.UseVisualStyleBackColor = true;
            this.btnThrow.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 225);
            this.Controls.Add(this.btnThrow);
            this.Controls.Add(this.lblAnswer);
            this.Name = "Form1";
            this.Text = "assignment 5.7";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.Button btnThrow;
    }
}

