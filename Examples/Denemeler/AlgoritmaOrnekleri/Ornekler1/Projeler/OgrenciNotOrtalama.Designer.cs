namespace Ornekler1.Projeler
{
    partial class OgrenciNotOrtalama
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
            this.txtOgrenciAdi = new System.Windows.Forms.TextBox();
            this.txtVize = new System.Windows.Forms.TextBox();
            this.txtFinal = new System.Windows.Forms.TextBox();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lstAd = new System.Windows.Forms.ListBox();
            this.lstVize = new System.Windows.Forms.ListBox();
            this.lstFinal = new System.Windows.Forms.ListBox();
            this.lstOrtalama = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtOgrenciAdi
            // 
            this.txtOgrenciAdi.Location = new System.Drawing.Point(23, 27);
            this.txtOgrenciAdi.Name = "txtOgrenciAdi";
            this.txtOgrenciAdi.Size = new System.Drawing.Size(100, 23);
            this.txtOgrenciAdi.TabIndex = 0;
            // 
            // txtVize
            // 
            this.txtVize.Location = new System.Drawing.Point(25, 71);
            this.txtVize.Name = "txtVize";
            this.txtVize.Size = new System.Drawing.Size(100, 23);
            this.txtVize.TabIndex = 1;
            // 
            // txtFinal
            // 
            this.txtFinal.Location = new System.Drawing.Point(23, 121);
            this.txtFinal.Name = "txtFinal";
            this.txtFinal.Size = new System.Drawing.Size(100, 23);
            this.txtFinal.TabIndex = 2;
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(147, 43);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(100, 65);
            this.btnHesapla.TabIndex = 4;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Öğrenci Adı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Vize Notu :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Final Notu :";
            // 
            // lstAd
            // 
            this.lstAd.FormattingEnabled = true;
            this.lstAd.ItemHeight = 15;
            this.lstAd.Location = new System.Drawing.Point(267, 3);
            this.lstAd.Name = "lstAd";
            this.lstAd.Size = new System.Drawing.Size(124, 244);
            this.lstAd.TabIndex = 9;
            // 
            // lstVize
            // 
            this.lstVize.FormattingEnabled = true;
            this.lstVize.ItemHeight = 15;
            this.lstVize.Location = new System.Drawing.Point(393, 3);
            this.lstVize.Name = "lstVize";
            this.lstVize.Size = new System.Drawing.Size(124, 244);
            this.lstVize.TabIndex = 10;
            // 
            // lstFinal
            // 
            this.lstFinal.FormattingEnabled = true;
            this.lstFinal.ItemHeight = 15;
            this.lstFinal.Location = new System.Drawing.Point(519, 3);
            this.lstFinal.Name = "lstFinal";
            this.lstFinal.Size = new System.Drawing.Size(124, 244);
            this.lstFinal.TabIndex = 11;
            // 
            // lstOrtalama
            // 
            this.lstOrtalama.FormattingEnabled = true;
            this.lstOrtalama.ItemHeight = 15;
            this.lstOrtalama.Location = new System.Drawing.Point(645, 3);
            this.lstOrtalama.Name = "lstOrtalama";
            this.lstOrtalama.Size = new System.Drawing.Size(124, 244);
            this.lstOrtalama.TabIndex = 12;
            // 
            // OgrenciNotOrtalama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 331);
            this.Controls.Add(this.lstOrtalama);
            this.Controls.Add(this.lstFinal);
            this.Controls.Add(this.lstVize);
            this.Controls.Add(this.lstAd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.txtFinal);
            this.Controls.Add(this.txtVize);
            this.Controls.Add(this.txtOgrenciAdi);
            this.Name = "OgrenciNotOrtalama";
            this.Text = "OgrenciNotOrtalama";
            this.Load += new System.EventHandler(this.OgrenciNotOrtalama_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtOgrenciAdi;
        private TextBox txtVize;
        private TextBox txtFinal;
        private Button btnHesapla;
        private Label label1;
        private Label label2;
        private Label label3;
        private ListBox lstAd;
        private ListBox lstVize;
        private ListBox lstFinal;
        private ListBox lstOrtalama;
    }
}