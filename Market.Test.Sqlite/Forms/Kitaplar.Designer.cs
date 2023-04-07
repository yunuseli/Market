namespace Market.Test.Sqlite.Forms
{
  partial class Kitaplar
  {
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
      this.gvListe = new System.Windows.Forms.DataGridView();
      this.panel1 = new System.Windows.Forms.Panel();
      this.radioButtonSil = new System.Windows.Forms.RadioButton();
      this.radioButtonDuzenle = new System.Windows.Forms.RadioButton();
      this.btnYayin = new System.Windows.Forms.Button();
      this.radioButtonEkle = new System.Windows.Forms.RadioButton();
      this.btnYazarlar = new System.Windows.Forms.Button();
      this.btnListele = new System.Windows.Forms.Button();
      this.panel2 = new System.Windows.Forms.Panel();
      this.btnIptal = new System.Windows.Forms.Button();
      this.btnKaydet = new System.Windows.Forms.Button();
      this.txtAciklama = new System.Windows.Forms.TextBox();
      this.label6 = new System.Windows.Forms.Label();
      this.txtSayfa = new System.Windows.Forms.TextBox();
      this.label5 = new System.Windows.Forms.Label();
      this.txtBaskiYili = new System.Windows.Forms.TextBox();
      this.label23432 = new System.Windows.Forms.Label();
      this.txtBarkod = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.txtKitapAdi = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.cmbYayinevi = new System.Windows.Forms.ComboBox();
      this.cmbYazar = new System.Windows.Forms.ComboBox();
      ((System.ComponentModel.ISupportInitialize)(this.gvListe)).BeginInit();
      this.panel1.SuspendLayout();
      this.panel2.SuspendLayout();
      this.SuspendLayout();
      // 
      // gvListe
      // 
      this.gvListe.AllowUserToAddRows = false;
      this.gvListe.AllowUserToDeleteRows = false;
      this.gvListe.AllowUserToOrderColumns = true;
      this.gvListe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
      this.gvListe.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
      this.gvListe.BackgroundColor = System.Drawing.Color.Ivory;
      this.gvListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.gvListe.Dock = System.Windows.Forms.DockStyle.Fill;
      this.gvListe.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
      this.gvListe.GridColor = System.Drawing.Color.Silver;
      this.gvListe.Location = new System.Drawing.Point(213, 57);
      this.gvListe.MultiSelect = false;
      this.gvListe.Name = "gvListe";
      this.gvListe.ReadOnly = true;
      this.gvListe.RowHeadersWidth = 30;
      dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
      dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Blue;
      dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Thistle;
      dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.DarkGreen;
      dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.gvListe.RowsDefaultCellStyle = dataGridViewCellStyle1;
      this.gvListe.RowTemplate.Height = 25;
      this.gvListe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.gvListe.Size = new System.Drawing.Size(844, 393);
      this.gvListe.TabIndex = 0;
      this.gvListe.SelectionChanged += new System.EventHandler(this.gvListe_SelectionChanged);
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.radioButtonSil);
      this.panel1.Controls.Add(this.radioButtonDuzenle);
      this.panel1.Controls.Add(this.btnYayin);
      this.panel1.Controls.Add(this.radioButtonEkle);
      this.panel1.Controls.Add(this.btnYazarlar);
      this.panel1.Controls.Add(this.btnListele);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel1.Location = new System.Drawing.Point(0, 0);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(1057, 57);
      this.panel1.TabIndex = 1;
      // 
      // radioButtonSil
      // 
      this.radioButtonSil.AutoSize = true;
      this.radioButtonSil.Location = new System.Drawing.Point(233, 19);
      this.radioButtonSil.Name = "radioButtonSil";
      this.radioButtonSil.Size = new System.Drawing.Size(37, 19);
      this.radioButtonSil.TabIndex = 10;
      this.radioButtonSil.TabStop = true;
      this.radioButtonSil.Text = "Sil";
      this.radioButtonSil.UseVisualStyleBackColor = true;
      this.radioButtonSil.Click += new System.EventHandler(this.radioButtonSil_Click);
      // 
      // radioButtonDuzenle
      // 
      this.radioButtonDuzenle.AutoSize = true;
      this.radioButtonDuzenle.Location = new System.Drawing.Point(160, 19);
      this.radioButtonDuzenle.Name = "radioButtonDuzenle";
      this.radioButtonDuzenle.Size = new System.Drawing.Size(67, 19);
      this.radioButtonDuzenle.TabIndex = 9;
      this.radioButtonDuzenle.TabStop = true;
      this.radioButtonDuzenle.Text = "Düzenle";
      this.radioButtonDuzenle.UseVisualStyleBackColor = true;
      this.radioButtonDuzenle.Click += new System.EventHandler(this.radioButtonDuzenle_Click);
      // 
      // btnYayin
      // 
      this.btnYayin.Location = new System.Drawing.Point(764, 12);
      this.btnYayin.Name = "btnYayin";
      this.btnYayin.Size = new System.Drawing.Size(91, 23);
      this.btnYayin.TabIndex = 2;
      this.btnYayin.Text = "Yayın Evleri";
      this.btnYayin.UseVisualStyleBackColor = true;
      this.btnYayin.Click += new System.EventHandler(this.btnYayin_Click);
      // 
      // radioButtonEkle
      // 
      this.radioButtonEkle.AutoSize = true;
      this.radioButtonEkle.Location = new System.Drawing.Point(108, 19);
      this.radioButtonEkle.Name = "radioButtonEkle";
      this.radioButtonEkle.Size = new System.Drawing.Size(46, 19);
      this.radioButtonEkle.TabIndex = 8;
      this.radioButtonEkle.TabStop = true;
      this.radioButtonEkle.Text = "Ekle";
      this.radioButtonEkle.UseVisualStyleBackColor = true;
      this.radioButtonEkle.Click += new System.EventHandler(this.radioButtonEkle_Click);
      // 
      // btnYazarlar
      // 
      this.btnYazarlar.Location = new System.Drawing.Point(683, 12);
      this.btnYazarlar.Name = "btnYazarlar";
      this.btnYazarlar.Size = new System.Drawing.Size(75, 23);
      this.btnYazarlar.TabIndex = 1;
      this.btnYazarlar.Text = "Yazarlar";
      this.btnYazarlar.UseVisualStyleBackColor = true;
      this.btnYazarlar.Click += new System.EventHandler(this.btnYazarlar_Click);
      // 
      // btnListele
      // 
      this.btnListele.Location = new System.Drawing.Point(9, 12);
      this.btnListele.Name = "btnListele";
      this.btnListele.Size = new System.Drawing.Size(68, 32);
      this.btnListele.TabIndex = 0;
      this.btnListele.Text = "Listele";
      this.btnListele.UseVisualStyleBackColor = true;
      this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
      // 
      // panel2
      // 
      this.panel2.Controls.Add(this.btnIptal);
      this.panel2.Controls.Add(this.btnKaydet);
      this.panel2.Controls.Add(this.txtAciklama);
      this.panel2.Controls.Add(this.label6);
      this.panel2.Controls.Add(this.txtSayfa);
      this.panel2.Controls.Add(this.label5);
      this.panel2.Controls.Add(this.txtBaskiYili);
      this.panel2.Controls.Add(this.label23432);
      this.panel2.Controls.Add(this.txtBarkod);
      this.panel2.Controls.Add(this.label4);
      this.panel2.Controls.Add(this.txtKitapAdi);
      this.panel2.Controls.Add(this.label3);
      this.panel2.Controls.Add(this.label2);
      this.panel2.Controls.Add(this.label1);
      this.panel2.Controls.Add(this.cmbYayinevi);
      this.panel2.Controls.Add(this.cmbYazar);
      this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
      this.panel2.Location = new System.Drawing.Point(0, 57);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(213, 393);
      this.panel2.TabIndex = 2;
      // 
      // btnIptal
      // 
      this.btnIptal.Location = new System.Drawing.Point(48, 308);
      this.btnIptal.Name = "btnIptal";
      this.btnIptal.Size = new System.Drawing.Size(68, 32);
      this.btnIptal.TabIndex = 17;
      this.btnIptal.Text = "İptal";
      this.btnIptal.UseVisualStyleBackColor = true;
      this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
      // 
      // btnKaydet
      // 
      this.btnKaydet.Location = new System.Drawing.Point(122, 308);
      this.btnKaydet.Name = "btnKaydet";
      this.btnKaydet.Size = new System.Drawing.Size(68, 32);
      this.btnKaydet.TabIndex = 16;
      this.btnKaydet.Text = "Kaydet";
      this.btnKaydet.UseVisualStyleBackColor = true;
      this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
      // 
      // txtAciklama
      // 
      this.txtAciklama.Location = new System.Drawing.Point(21, 265);
      this.txtAciklama.Name = "txtAciklama";
      this.txtAciklama.Size = new System.Drawing.Size(169, 23);
      this.txtAciklama.TabIndex = 14;
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(119, 99);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(35, 15);
      this.label6.TabIndex = 13;
      this.label6.Text = "Sayfa";
      // 
      // txtSayfa
      // 
      this.txtSayfa.Location = new System.Drawing.Point(119, 117);
      this.txtSayfa.Name = "txtSayfa";
      this.txtSayfa.Size = new System.Drawing.Size(71, 23);
      this.txtSayfa.TabIndex = 12;
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(21, 99);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(53, 15);
      this.label5.TabIndex = 11;
      this.label5.Text = "Baskı Yılı";
      // 
      // txtBaskiYili
      // 
      this.txtBaskiYili.Location = new System.Drawing.Point(21, 117);
      this.txtBaskiYili.Name = "txtBaskiYili";
      this.txtBaskiYili.Size = new System.Drawing.Size(66, 23);
      this.txtBaskiYili.TabIndex = 10;
      // 
      // label23432
      // 
      this.label23432.AutoSize = true;
      this.label23432.Location = new System.Drawing.Point(21, 52);
      this.label23432.Name = "label23432";
      this.label23432.Size = new System.Drawing.Size(44, 15);
      this.label23432.TabIndex = 9;
      this.label23432.Text = "Barkod";
      // 
      // txtBarkod
      // 
      this.txtBarkod.Location = new System.Drawing.Point(21, 70);
      this.txtBarkod.Name = "txtBarkod";
      this.txtBarkod.Size = new System.Drawing.Size(169, 23);
      this.txtBarkod.TabIndex = 8;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(21, 7);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(25, 15);
      this.label4.TabIndex = 7;
      this.label4.Text = "Adı";
      // 
      // txtKitapAdi
      // 
      this.txtKitapAdi.Location = new System.Drawing.Point(21, 25);
      this.txtKitapAdi.Name = "txtKitapAdi";
      this.txtKitapAdi.Size = new System.Drawing.Size(169, 23);
      this.txtKitapAdi.TabIndex = 6;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(21, 247);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(56, 15);
      this.label3.TabIndex = 5;
      this.label3.Text = "Açıklama";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(21, 196);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(50, 15);
      this.label2.TabIndex = 4;
      this.label2.Text = "Yayınevi";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(21, 150);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(34, 15);
      this.label1.TabIndex = 3;
      this.label1.Text = "Yazar";
      // 
      // cmbYayinevi
      // 
      this.cmbYayinevi.FormattingEnabled = true;
      this.cmbYayinevi.Location = new System.Drawing.Point(21, 214);
      this.cmbYayinevi.Name = "cmbYayinevi";
      this.cmbYayinevi.Size = new System.Drawing.Size(169, 23);
      this.cmbYayinevi.TabIndex = 2;
      // 
      // cmbYazar
      // 
      this.cmbYazar.FormattingEnabled = true;
      this.cmbYazar.Location = new System.Drawing.Point(21, 168);
      this.cmbYazar.Name = "cmbYazar";
      this.cmbYazar.Size = new System.Drawing.Size(169, 23);
      this.cmbYazar.TabIndex = 1;
      // 
      // Kitaplar
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1057, 450);
      this.Controls.Add(this.gvListe);
      this.Controls.Add(this.panel2);
      this.Controls.Add(this.panel1);
      this.Name = "Kitaplar";
      this.Text = "Kitap Listesi";
      this.Load += new System.EventHandler(this.Kitaplar_Load);
      ((System.ComponentModel.ISupportInitialize)(this.gvListe)).EndInit();
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.panel2.ResumeLayout(false);
      this.panel2.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private DataGridView gvListe;
    private Panel panel1;
    private Panel panel2;
    private Button btnListele;
    private Button btnYazarlar;
    private Button btnYayin;
    private ComboBox cmbYayinevi;
    private ComboBox cmbYazar;
    private Label label3;
    private Label label2;
    private Label label1;
    private TextBox txtKitapAdi;
    private Label label4;
    private TextBox txtAciklama;
    private Label label6;
    private TextBox txtSayfa;
    private Label label5;
    private TextBox txtBaskiYili;
    private Label label23432;
    private TextBox txtBarkod;
    private Button btnKaydet;
    private RadioButton radioButtonSil;
    private RadioButton radioButtonDuzenle;
    private RadioButton radioButtonEkle;
    private Button btnIptal;
  }
}