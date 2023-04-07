namespace Ornekler1
{
    partial class Menu
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
            this.btnAc = new System.Windows.Forms.Button();
            this.lstProjeler = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnAc
            // 
            this.btnAc.Location = new System.Drawing.Point(264, 142);
            this.btnAc.Name = "btnAc";
            this.btnAc.Size = new System.Drawing.Size(104, 61);
            this.btnAc.TabIndex = 0;
            this.btnAc.Text = "Aç";
            this.btnAc.UseVisualStyleBackColor = true;
            this.btnAc.Click += new System.EventHandler(this.btnAc_Click);
            // 
            // lstProjeler
            // 
            this.lstProjeler.Dock = System.Windows.Forms.DockStyle.Left;
            this.lstProjeler.FormattingEnabled = true;
            this.lstProjeler.ItemHeight = 15;
            this.lstProjeler.Items.AddRange(new object[] {
            "1. Çarpma Operatörsüz Çarpma",
            "2. Sayının Kaç Basamaklı Olduğunu Bulma",
            "3. Mükemmel Sayıyı Bulma",
            "4. Ortalama Hesabı",
            "5. Girilen Kelimeyi Tersten Yazma",
            "6. Kelimenin Harflerini Sağa Atma",
            "7. Polindrom Kontrolü",
            "8. Öğrenci Not Ortalaması",
            "9. KDV Ekleme",
            "10. Sıramatik"});
            this.lstProjeler.Location = new System.Drawing.Point(0, 0);
            this.lstProjeler.Name = "lstProjeler";
            this.lstProjeler.Size = new System.Drawing.Size(172, 450);
            this.lstProjeler.TabIndex = 1;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstProjeler);
            this.Controls.Add(this.btnAc);
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnAc;
        private ListBox lstProjeler;
    }
}