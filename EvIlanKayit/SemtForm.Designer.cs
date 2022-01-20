namespace EvIlanKayit
{
    partial class SemtForm
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
            this.txtSemtAd = new System.Windows.Forms.TextBox();
            this.txtIlce = new System.Windows.Forms.TextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Semt Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "İlçe:";
            // 
            // txtSemtAd
            // 
            this.txtSemtAd.Location = new System.Drawing.Point(105, 21);
            this.txtSemtAd.Name = "txtSemtAd";
            this.txtSemtAd.Size = new System.Drawing.Size(100, 20);
            this.txtSemtAd.TabIndex = 2;
            // 
            // txtIlce
            // 
            this.txtIlce.Location = new System.Drawing.Point(105, 47);
            this.txtIlce.Name = "txtIlce";
            this.txtIlce.Size = new System.Drawing.Size(100, 20);
            this.txtIlce.TabIndex = 3;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(105, 73);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(100, 23);
            this.btnKaydet.TabIndex = 4;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // SemtForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 118);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.txtIlce);
            this.Controls.Add(this.txtSemtAd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SemtForm";
            this.Text = "SemtForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SemtForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSemtAd;
        private System.Windows.Forms.TextBox txtIlce;
        private System.Windows.Forms.Button btnKaydet;
    }
}