namespace Siniflar
{
  partial class OgrenciIslem
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
      this.components = new System.ComponentModel.Container();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
      this.btnEkle = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.txtAd = new System.Windows.Forms.TextBox();
      this.gvListe = new System.Windows.Forms.DataGridView();
      this.txtSoyad = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.txtSinif = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.txtNot1 = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.txtNumara = new System.Windows.Forms.TextBox();
      this.label5 = new System.Windows.Forms.Label();
      this.txtSube = new System.Windows.Forms.TextBox();
      this.label6 = new System.Windows.Forms.Label();
      this.txtNot3 = new System.Windows.Forms.TextBox();
      this.label8 = new System.Windows.Forms.Label();
      this.txtNot2 = new System.Windows.Forms.TextBox();
      this.label9 = new System.Windows.Forms.Label();
      this.btnGuncelle = new System.Windows.Forms.Button();
      this.btnSil = new System.Windows.Forms.Button();
      this.pnlUst = new System.Windows.Forms.Panel();
      this.lblDurum = new System.Windows.Forms.Label();
      this.lblOrtalama = new System.Windows.Forms.Label();
      this.label7 = new System.Windows.Forms.Label();
      this.label10 = new System.Windows.Forms.Label();
      this.pnlIslem = new System.Windows.Forms.Panel();
      this.btnIptal = new System.Windows.Forms.Button();
      this.btnKaydet = new System.Windows.Forms.Button();
      this.toolTipInfo = new System.Windows.Forms.ToolTip(this.components);
      this.pnlAlt = new System.Windows.Forms.Panel();
      ((System.ComponentModel.ISupportInitialize)(this.gvListe)).BeginInit();
      this.pnlUst.SuspendLayout();
      this.pnlIslem.SuspendLayout();
      this.SuspendLayout();
      // 
      // btnEkle
      // 
      this.btnEkle.Image = global::Siniflar.Properties.Resources.add;
      this.btnEkle.Location = new System.Drawing.Point(12, 12);
      this.btnEkle.Name = "btnEkle";
      this.btnEkle.Size = new System.Drawing.Size(60, 60);
      this.btnEkle.TabIndex = 0;
      this.btnEkle.UseVisualStyleBackColor = true;
      this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(14, 47);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(22, 15);
      this.label1.TabIndex = 1;
      this.label1.Text = "Ad";
      // 
      // txtAd
      // 
      this.txtAd.Location = new System.Drawing.Point(64, 44);
      this.txtAd.Name = "txtAd";
      this.txtAd.Size = new System.Drawing.Size(167, 23);
      this.txtAd.TabIndex = 2;
      // 
      // gvListe
      // 
      this.gvListe.BackgroundColor = System.Drawing.Color.WhiteSmoke;
      dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
      dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.gvListe.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
      this.gvListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
      dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
      dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
      this.gvListe.DefaultCellStyle = dataGridViewCellStyle2;
      this.gvListe.Dock = System.Windows.Forms.DockStyle.Fill;
      this.gvListe.Location = new System.Drawing.Point(253, 83);
      this.gvListe.Name = "gvListe";
      dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
      dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.gvListe.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
      this.gvListe.RowTemplate.Height = 25;
      this.gvListe.Size = new System.Drawing.Size(843, 448);
      this.gvListe.TabIndex = 3;
      // 
      // txtSoyad
      // 
      this.txtSoyad.Location = new System.Drawing.Point(64, 73);
      this.txtSoyad.Name = "txtSoyad";
      this.txtSoyad.Size = new System.Drawing.Size(167, 23);
      this.txtSoyad.TabIndex = 5;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(14, 76);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(39, 15);
      this.label2.TabIndex = 4;
      this.label2.Text = "Soyad";
      // 
      // txtSinif
      // 
      this.txtSinif.Location = new System.Drawing.Point(64, 102);
      this.txtSinif.Name = "txtSinif";
      this.txtSinif.Size = new System.Drawing.Size(167, 23);
      this.txtSinif.TabIndex = 7;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(14, 105);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(30, 15);
      this.label3.TabIndex = 6;
      this.label3.Text = "Sınıf";
      // 
      // txtNot1
      // 
      this.txtNot1.Location = new System.Drawing.Point(64, 189);
      this.txtNot1.Name = "txtNot1";
      this.txtNot1.Size = new System.Drawing.Size(167, 23);
      this.txtNot1.TabIndex = 13;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(14, 192);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(33, 15);
      this.label4.TabIndex = 12;
      this.label4.Text = "Not1";
      // 
      // txtNumara
      // 
      this.txtNumara.Location = new System.Drawing.Point(64, 160);
      this.txtNumara.Name = "txtNumara";
      this.txtNumara.Size = new System.Drawing.Size(167, 23);
      this.txtNumara.TabIndex = 11;
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(14, 163);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(50, 15);
      this.label5.TabIndex = 10;
      this.label5.Text = "Numara";
      // 
      // txtSube
      // 
      this.txtSube.Location = new System.Drawing.Point(64, 131);
      this.txtSube.Name = "txtSube";
      this.txtSube.Size = new System.Drawing.Size(167, 23);
      this.txtSube.TabIndex = 9;
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(14, 134);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(33, 15);
      this.label6.TabIndex = 8;
      this.label6.Text = "Şube";
      // 
      // txtNot3
      // 
      this.txtNot3.Location = new System.Drawing.Point(64, 247);
      this.txtNot3.Name = "txtNot3";
      this.txtNot3.Size = new System.Drawing.Size(167, 23);
      this.txtNot3.TabIndex = 17;
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Location = new System.Drawing.Point(14, 250);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(33, 15);
      this.label8.TabIndex = 16;
      this.label8.Text = "Not3";
      // 
      // txtNot2
      // 
      this.txtNot2.Location = new System.Drawing.Point(64, 218);
      this.txtNot2.Name = "txtNot2";
      this.txtNot2.Size = new System.Drawing.Size(167, 23);
      this.txtNot2.TabIndex = 15;
      // 
      // label9
      // 
      this.label9.AutoSize = true;
      this.label9.Location = new System.Drawing.Point(14, 221);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(33, 15);
      this.label9.TabIndex = 14;
      this.label9.Text = "Not2";
      // 
      // btnGuncelle
      // 
      this.btnGuncelle.Image = global::Siniflar.Properties.Resources.edit;
      this.btnGuncelle.Location = new System.Drawing.Point(78, 12);
      this.btnGuncelle.Name = "btnGuncelle";
      this.btnGuncelle.Size = new System.Drawing.Size(60, 60);
      this.btnGuncelle.TabIndex = 18;
      this.btnGuncelle.UseVisualStyleBackColor = true;
      this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
      // 
      // btnSil
      // 
      this.btnSil.Image = global::Siniflar.Properties.Resources.delete;
      this.btnSil.Location = new System.Drawing.Point(144, 12);
      this.btnSil.Name = "btnSil";
      this.btnSil.Size = new System.Drawing.Size(60, 60);
      this.btnSil.TabIndex = 19;
      this.btnSil.UseVisualStyleBackColor = true;
      // 
      // pnlUst
      // 
      this.pnlUst.BackColor = System.Drawing.Color.SandyBrown;
      this.pnlUst.Controls.Add(this.lblDurum);
      this.pnlUst.Controls.Add(this.btnEkle);
      this.pnlUst.Controls.Add(this.lblOrtalama);
      this.pnlUst.Controls.Add(this.label7);
      this.pnlUst.Controls.Add(this.btnSil);
      this.pnlUst.Controls.Add(this.label10);
      this.pnlUst.Controls.Add(this.btnGuncelle);
      this.pnlUst.Dock = System.Windows.Forms.DockStyle.Top;
      this.pnlUst.Location = new System.Drawing.Point(0, 0);
      this.pnlUst.Name = "pnlUst";
      this.pnlUst.Size = new System.Drawing.Size(1096, 83);
      this.pnlUst.TabIndex = 20;
      // 
      // lblDurum
      // 
      this.lblDurum.AutoSize = true;
      this.lblDurum.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.lblDurum.Location = new System.Drawing.Point(353, 41);
      this.lblDurum.Name = "lblDurum";
      this.lblDurum.Size = new System.Drawing.Size(63, 21);
      this.lblDurum.TabIndex = 23;
      this.lblDurum.Text = "Durum";
      // 
      // lblOrtalama
      // 
      this.lblOrtalama.AutoSize = true;
      this.lblOrtalama.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.lblOrtalama.Location = new System.Drawing.Point(353, 12);
      this.lblOrtalama.Name = "lblOrtalama";
      this.lblOrtalama.Size = new System.Drawing.Size(81, 21);
      this.lblOrtalama.TabIndex = 22;
      this.lblOrtalama.Text = "Ortalama";
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Location = new System.Drawing.Point(285, 47);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(44, 15);
      this.label7.TabIndex = 21;
      this.label7.Text = "Durum";
      // 
      // label10
      // 
      this.label10.AutoSize = true;
      this.label10.Location = new System.Drawing.Point(285, 18);
      this.label10.Name = "label10";
      this.label10.Size = new System.Drawing.Size(56, 15);
      this.label10.TabIndex = 20;
      this.label10.Text = "Ortalama";
      // 
      // pnlIslem
      // 
      this.pnlIslem.BackColor = System.Drawing.Color.PaleTurquoise;
      this.pnlIslem.Controls.Add(this.btnIptal);
      this.pnlIslem.Controls.Add(this.btnKaydet);
      this.pnlIslem.Controls.Add(this.txtAd);
      this.pnlIslem.Controls.Add(this.label1);
      this.pnlIslem.Controls.Add(this.txtNot3);
      this.pnlIslem.Controls.Add(this.label2);
      this.pnlIslem.Controls.Add(this.label8);
      this.pnlIslem.Controls.Add(this.txtSoyad);
      this.pnlIslem.Controls.Add(this.txtNot2);
      this.pnlIslem.Controls.Add(this.label3);
      this.pnlIslem.Controls.Add(this.label9);
      this.pnlIslem.Controls.Add(this.txtSinif);
      this.pnlIslem.Controls.Add(this.txtNot1);
      this.pnlIslem.Controls.Add(this.label6);
      this.pnlIslem.Controls.Add(this.label4);
      this.pnlIslem.Controls.Add(this.txtSube);
      this.pnlIslem.Controls.Add(this.txtNumara);
      this.pnlIslem.Controls.Add(this.label5);
      this.pnlIslem.Dock = System.Windows.Forms.DockStyle.Left;
      this.pnlIslem.Location = new System.Drawing.Point(0, 83);
      this.pnlIslem.Name = "pnlIslem";
      this.pnlIslem.Size = new System.Drawing.Size(253, 448);
      this.pnlIslem.TabIndex = 21;
      // 
      // btnIptal
      // 
      this.btnIptal.Image = global::Siniflar.Properties.Resources.cancel;
      this.btnIptal.Location = new System.Drawing.Point(105, 287);
      this.btnIptal.Name = "btnIptal";
      this.btnIptal.Size = new System.Drawing.Size(60, 60);
      this.btnIptal.TabIndex = 19;
      this.btnIptal.UseVisualStyleBackColor = true;
      this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
      // 
      // btnKaydet
      // 
      this.btnKaydet.Image = global::Siniflar.Properties.Resources.save;
      this.btnKaydet.Location = new System.Drawing.Point(171, 287);
      this.btnKaydet.Name = "btnKaydet";
      this.btnKaydet.Size = new System.Drawing.Size(60, 60);
      this.btnKaydet.TabIndex = 18;
      this.btnKaydet.UseVisualStyleBackColor = true;
      this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
      // 
      // pnlAlt
      // 
      this.pnlAlt.BackColor = System.Drawing.Color.Pink;
      this.pnlAlt.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.pnlAlt.Location = new System.Drawing.Point(0, 531);
      this.pnlAlt.Name = "pnlAlt";
      this.pnlAlt.Size = new System.Drawing.Size(1096, 33);
      this.pnlAlt.TabIndex = 20;
      // 
      // OgrenciIslem
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1096, 564);
      this.Controls.Add(this.gvListe);
      this.Controls.Add(this.pnlIslem);
      this.Controls.Add(this.pnlUst);
      this.Controls.Add(this.pnlAlt);
      this.Name = "OgrenciIslem";
      this.Text = "OgrenciIslem";
      this.Load += new System.EventHandler(this.OgrenciIslem_Load);
      ((System.ComponentModel.ISupportInitialize)(this.gvListe)).EndInit();
      this.pnlUst.ResumeLayout(false);
      this.pnlUst.PerformLayout();
      this.pnlIslem.ResumeLayout(false);
      this.pnlIslem.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private Button btnEkle;
    private Label label1;
    private TextBox txtAd;
    private DataGridView gvListe;
    private TextBox txtSoyad;
    private Label label2;
    private TextBox txtSinif;
    private Label label3;
    private TextBox txtNot1;
    private Label label4;
    private TextBox txtNumara;
    private Label label5;
    private TextBox txtSube;
    private Label label6;
    private TextBox txtNot3;
    private Label label8;
    private TextBox txtNot2;
    private Label label9;
    private Button btnGuncelle;
    private Button btnSil;
    private Panel pnlUst;
    private Panel pnlIslem;
    private Button btnKaydet;
    private ToolTip toolTipInfo;
    private Button btnIptal;
    private Panel pnlAlt;
    private Label lblDurum;
    private Label lblOrtalama;
    private Label label7;
    private Label label10;
  }
}