
namespace CriaVGC
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
            this.cbxInicial2 = new System.Windows.Forms.ComboBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.cbxInicial1 = new System.Windows.Forms.ComboBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbxInicial2
            // 
            this.cbxInicial2.FormattingEnabled = true;
            this.cbxInicial2.Items.AddRange(new object[] {
            "Charmander",
            "Totodaio",
            "Sprigatito"});
            this.cbxInicial2.Location = new System.Drawing.Point(667, 59);
            this.cbxInicial2.Name = "cbxInicial2";
            this.cbxInicial2.Size = new System.Drawing.Size(121, 21);
            this.cbxInicial2.TabIndex = 2;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(292, 12);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(200, 40);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // cbxInicial1
            // 
            this.cbxInicial1.FormattingEnabled = true;
            this.cbxInicial1.Items.AddRange(new object[] {
            "Charmander",
            "Totodaio",
            "Sprigatito"});
            this.cbxInicial1.Location = new System.Drawing.Point(12, 59);
            this.cbxInicial1.Name = "cbxInicial1";
            this.cbxInicial1.Size = new System.Drawing.Size(121, 21);
            this.cbxInicial1.TabIndex = 1;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(352, 269);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(35, 13);
            this.lblTotal.TabIndex = 4;
            this.lblTotal.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.cbxInicial2);
            this.Controls.Add(this.cbxInicial1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxInicial2;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ComboBox cbxInicial1;
        private System.Windows.Forms.Label lblTotal;
    }
}

