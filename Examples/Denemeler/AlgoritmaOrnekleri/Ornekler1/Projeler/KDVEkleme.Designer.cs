namespace Ornekler1.Projeler
{
    partial class KDVEkleme
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
            this.btnHesapla = new System.Windows.Forms.Button();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lstUrunFiyati = new System.Windows.Forms.ListBox();
            this.lstKDVliFiyati = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(24, 71);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(105, 90);
            this.btnHesapla.TabIndex = 0;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // txtFiyat
            // 
            this.txtFiyat.Location = new System.Drawing.Point(49, 27);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(100, 23);
            this.txtFiyat.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bir fiyat giriniz : ";
            // 
            // lstUrunFiyati
            // 
            this.lstUrunFiyati.FormattingEnabled = true;
            this.lstUrunFiyati.ItemHeight = 15;
            this.lstUrunFiyati.Location = new System.Drawing.Point(171, 9);
            this.lstUrunFiyati.Name = "lstUrunFiyati";
            this.lstUrunFiyati.Size = new System.Drawing.Size(153, 304);
            this.lstUrunFiyati.TabIndex = 3;
            // 
            // lstKDVliFiyati
            // 
            this.lstKDVliFiyati.FormattingEnabled = true;
            this.lstKDVliFiyati.ItemHeight = 15;
            this.lstKDVliFiyati.Location = new System.Drawing.Point(330, 9);
            this.lstKDVliFiyati.Name = "lstKDVliFiyati";
            this.lstKDVliFiyati.Size = new System.Drawing.Size(153, 304);
            this.lstKDVliFiyati.TabIndex = 4;
            // 
            // KDVEkleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 333);
            this.Controls.Add(this.lstKDVliFiyati);
            this.Controls.Add(this.lstUrunFiyati);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFiyat);
            this.Controls.Add(this.btnHesapla);
            this.Name = "KDVEkleme";
            this.Text = "KDVEkleme";
            this.Load += new System.EventHandler(this.KDVEkleme_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnHesapla;
        private TextBox txtFiyat;
        private Label label1;
        private ListBox lstUrunFiyati;
        private ListBox lstKDVliFiyati;
    }
}