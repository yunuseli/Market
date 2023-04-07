namespace Market.Presentation.WinUI.Forms.MusteriFormlari
{
  partial class MusteriListesi
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
      this.pnlIslem = new System.Windows.Forms.Panel();
      this.btnEkle = new System.Windows.Forms.Button();
      this.label3 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.txtTelefon = new System.Windows.Forms.TextBox();
      this.txtSoyad = new System.Windows.Forms.TextBox();
      this.txtAd = new System.Windows.Forms.TextBox();
      this.btnListele = new System.Windows.Forms.Button();
      this.gvListe = new System.Windows.Forms.DataGridView();
      this.btnDosyadan = new System.Windows.Forms.Button();
      this.pnlIslem.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.gvListe)).BeginInit();
      this.SuspendLayout();
      // 
      // pnlIslem
      // 
      this.pnlIslem.BackColor = System.Drawing.Color.LightSkyBlue;
      this.pnlIslem.Controls.Add(this.btnDosyadan);
      this.pnlIslem.Controls.Add(this.btnEkle);
      this.pnlIslem.Controls.Add(this.label3);
      this.pnlIslem.Controls.Add(this.label2);
      this.pnlIslem.Controls.Add(this.label1);
      this.pnlIslem.Controls.Add(this.txtTelefon);
      this.pnlIslem.Controls.Add(this.txtSoyad);
      this.pnlIslem.Controls.Add(this.txtAd);
      this.pnlIslem.Controls.Add(this.btnListele);
      this.pnlIslem.Dock = System.Windows.Forms.DockStyle.Left;
      this.pnlIslem.Location = new System.Drawing.Point(0, 0);
      this.pnlIslem.Name = "pnlIslem";
      this.pnlIslem.Size = new System.Drawing.Size(374, 616);
      this.pnlIslem.TabIndex = 0;
      // 
      // btnEkle
      // 
      this.btnEkle.Location = new System.Drawing.Point(134, 284);
      this.btnEkle.Name = "btnEkle";
      this.btnEkle.Size = new System.Drawing.Size(151, 47);
      this.btnEkle.TabIndex = 7;
      this.btnEkle.Text = "Ekle";
      this.btnEkle.UseVisualStyleBackColor = true;
      this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(67, 206);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(50, 20);
      this.label3.TabIndex = 6;
      this.label3.Text = "Soyad";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(67, 239);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(58, 20);
      this.label2.TabIndex = 5;
      this.label2.Text = "Telefon";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(69, 175);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(28, 20);
      this.label1.TabIndex = 4;
      this.label1.Text = "Ad";
      // 
      // txtTelefon
      // 
      this.txtTelefon.Location = new System.Drawing.Point(134, 236);
      this.txtTelefon.Name = "txtTelefon";
      this.txtTelefon.Size = new System.Drawing.Size(151, 27);
      this.txtTelefon.TabIndex = 3;
      // 
      // txtSoyad
      // 
      this.txtSoyad.Location = new System.Drawing.Point(134, 203);
      this.txtSoyad.Name = "txtSoyad";
      this.txtSoyad.Size = new System.Drawing.Size(151, 27);
      this.txtSoyad.TabIndex = 2;
      // 
      // txtAd
      // 
      this.txtAd.Location = new System.Drawing.Point(134, 170);
      this.txtAd.Name = "txtAd";
      this.txtAd.Size = new System.Drawing.Size(151, 27);
      this.txtAd.TabIndex = 1;
      // 
      // btnListele
      // 
      this.btnListele.Location = new System.Drawing.Point(23, 27);
      this.btnListele.Name = "btnListele";
      this.btnListele.Size = new System.Drawing.Size(94, 29);
      this.btnListele.TabIndex = 0;
      this.btnListele.Text = "Listele";
      this.btnListele.UseVisualStyleBackColor = true;
      this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
      // 
      // gvListe
      // 
      this.gvListe.BackgroundColor = System.Drawing.Color.MistyRose;
      this.gvListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.gvListe.Dock = System.Windows.Forms.DockStyle.Fill;
      this.gvListe.Location = new System.Drawing.Point(374, 0);
      this.gvListe.Name = "gvListe";
      this.gvListe.RowHeadersWidth = 51;
      this.gvListe.RowTemplate.Height = 29;
      this.gvListe.Size = new System.Drawing.Size(746, 616);
      this.gvListe.TabIndex = 1;
      this.gvListe.SelectionChanged += new System.EventHandler(this.gvListe_SelectionChanged);
      // 
      // btnDosyadan
      // 
      this.btnDosyadan.Location = new System.Drawing.Point(35, 421);
      this.btnDosyadan.Name = "btnDosyadan";
      this.btnDosyadan.Size = new System.Drawing.Size(175, 29);
      this.btnDosyadan.TabIndex = 8;
      this.btnDosyadan.Text = "Dosyada getir";
      this.btnDosyadan.UseVisualStyleBackColor = true;
      this.btnDosyadan.Click += new System.EventHandler(this.btnDosyadan_Click);
      // 
      // MusteriListesi
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1120, 616);
      this.Controls.Add(this.gvListe);
      this.Controls.Add(this.pnlIslem);
      this.Name = "MusteriListesi";
      this.Text = "MusteriListesi";
      this.Load += new System.EventHandler(this.MusteriListesi_Load);
      this.pnlIslem.ResumeLayout(false);
      this.pnlIslem.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.gvListe)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private Panel pnlIslem;
    private Button btnListele;
    private DataGridView gvListe;
    private Button btnEkle;
    private Label label3;
    private Label label2;
    private Label label1;
    private TextBox txtTelefon;
    private TextBox txtSoyad;
    private TextBox txtAd;
    private Button btnDosyadan;
  }
}