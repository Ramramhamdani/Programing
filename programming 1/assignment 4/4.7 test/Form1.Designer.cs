namespace _4._7_test
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
            this.txtsize = new System.Windows.Forms.TextBox();
            this.btncreate = new System.Windows.Forms.Button();
            this.lblsquare = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtsize
            // 
            this.txtsize.Location = new System.Drawing.Point(223, 85);
            this.txtsize.Name = "txtsize";
            this.txtsize.Size = new System.Drawing.Size(100, 20);
            this.txtsize.TabIndex = 0;
            this.txtsize.TextChanged += new System.EventHandler(this.txtsize_TextChanged);
            // 
            // btncreate
            // 
            this.btncreate.Location = new System.Drawing.Point(181, 200);
            this.btncreate.Name = "btncreate";
            this.btncreate.Size = new System.Drawing.Size(75, 23);
            this.btncreate.TabIndex = 1;
            this.btncreate.Text = "button1";
            this.btncreate.UseVisualStyleBackColor = true;
            this.btncreate.Click += new System.EventHandler(this.btncreate_Click);
            // 
            // lblsquare
            // 
            this.lblsquare.AutoSize = true;
            this.lblsquare.Location = new System.Drawing.Point(425, 205);
            this.lblsquare.Name = "lblsquare";
            this.lblsquare.Size = new System.Drawing.Size(35, 13);
            this.lblsquare.TabIndex = 2;
            this.lblsquare.Text = "label1";
            this.lblsquare.Click += new System.EventHandler(this.lblsquare_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblsquare);
            this.Controls.Add(this.btncreate);
            this.Controls.Add(this.txtsize);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtsize;
        private System.Windows.Forms.Button btncreate;
        private System.Windows.Forms.Label lblsquare;
    }
}

