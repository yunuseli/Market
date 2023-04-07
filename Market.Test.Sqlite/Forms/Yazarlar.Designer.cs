namespace Market.Test.Sqlite.Forms
{
  partial class Yazarlar
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
      this.btnListele = new System.Windows.Forms.Button();
      this.panel2 = new System.Windows.Forms.Panel();
      this.radioButtonSil = new System.Windows.Forms.RadioButton();
      this.radioButtonDuzenle = new System.Windows.Forms.RadioButton();
      this.radioButtonEkle = new System.Windows.Forms.RadioButton();
      this.txtSoyad = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.txtAd = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.btnIslem = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.gvListe)).BeginInit();
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
      this.gvListe.Location = new System.Drawing.Point(181, 0);
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
      this.gvListe.Size = new System.Drawing.Size(619, 450);
      this.gvListe.TabIndex = 3;
      this.gvListe.SelectionChanged += new System.EventHandler(this.gvListe_SelectionChanged);
      // 
      // btnListele
      // 
      this.btnListele.Location = new System.Drawing.Point(12, 12);
      this.btnListele.Name = "btnListele";
      this.btnListele.Size = new System.Drawing.Size(75, 23);
      this.btnListele.TabIndex = 0;
      this.btnListele.Text = "Listele";
      this.btnListele.UseVisualStyleBackColor = true;
      this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
      // 
      // panel2
      // 
      this.panel2.Controls.Add(this.btnIslem);
      this.panel2.Controls.Add(this.radioButtonSil);
      this.panel2.Controls.Add(this.radioButtonDuzenle);
      this.panel2.Controls.Add(this.radioButtonEkle);
      this.panel2.Controls.Add(this.txtSoyad);
      this.panel2.Controls.Add(this.label2);
      this.panel2.Controls.Add(this.txtAd);
      this.panel2.Controls.Add(this.label1);
      this.panel2.Controls.Add(this.btnListele);
      this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
      this.panel2.Location = new System.Drawing.Point(0, 0);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(181, 450);
      this.panel2.TabIndex = 5;
      // 
      // radioButtonSil
      // 
      this.radioButtonSil.AutoSize = true;
      this.radioButtonSil.Location = new System.Drawing.Point(12, 201);
      this.radioButtonSil.Name = "radioButtonSil";
      this.radioButtonSil.Size = new System.Drawing.Size(37, 19);
      this.radioButtonSil.TabIndex = 7;
      this.radioButtonSil.TabStop = true;
      this.radioButtonSil.Text = "Sil";
      this.radioButtonSil.UseVisualStyleBackColor = true;
      // 
      // radioButtonDuzenle
      // 
      this.radioButtonDuzenle.AutoSize = true;
      this.radioButtonDuzenle.Location = new System.Drawing.Point(12, 176);
      this.radioButtonDuzenle.Name = "radioButtonDuzenle";
      this.radioButtonDuzenle.Size = new System.Drawing.Size(67, 19);
      this.radioButtonDuzenle.TabIndex = 6;
      this.radioButtonDuzenle.TabStop = true;
      this.radioButtonDuzenle.Text = "Düzenle";
      this.radioButtonDuzenle.UseVisualStyleBackColor = true;
      // 
      // radioButtonEkle
      // 
      this.radioButtonEkle.AutoSize = true;
      this.radioButtonEkle.Location = new System.Drawing.Point(12, 151);
      this.radioButtonEkle.Name = "radioButtonEkle";
      this.radioButtonEkle.Size = new System.Drawing.Size(46, 19);
      this.radioButtonEkle.TabIndex = 5;
      this.radioButtonEkle.TabStop = true;
      this.radioButtonEkle.Text = "Ekle";
      this.radioButtonEkle.UseVisualStyleBackColor = true;
      // 
      // txtSoyad
      // 
      this.txtSoyad.Location = new System.Drawing.Point(12, 305);
      this.txtSoyad.Name = "txtSoyad";
      this.txtSoyad.Size = new System.Drawing.Size(100, 23);
      this.txtSoyad.TabIndex = 4;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(12, 287);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(39, 15);
      this.label2.TabIndex = 3;
      this.label2.Text = "Soyad";
      // 
      // txtAd
      // 
      this.txtAd.Location = new System.Drawing.Point(12, 256);
      this.txtAd.Name = "txtAd";
      this.txtAd.Size = new System.Drawing.Size(100, 23);
      this.txtAd.TabIndex = 2;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 238);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(22, 15);
      this.label1.TabIndex = 1;
      this.label1.Text = "Ad";
      // 
      // btnIslem
      // 
      this.btnIslem.Location = new System.Drawing.Point(37, 345);
      this.btnIslem.Name = "btnIslem";
      this.btnIslem.Size = new System.Drawing.Size(75, 23);
      this.btnIslem.TabIndex = 8;
      this.btnIslem.Text = "Kaydet / Sil";
      this.btnIslem.UseVisualStyleBackColor = true;
      this.btnIslem.Click += new System.EventHandler(this.btnIslem_Click);
      // 
      // Yazarlar
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.gvListe);
      this.Controls.Add(this.panel2);
      this.Name = "Yazarlar";
      this.Text = "Yazarlar";
      this.Load += new System.EventHandler(this.Yazarlar_Load);
      ((System.ComponentModel.ISupportInitialize)(this.gvListe)).EndInit();
      this.panel2.ResumeLayout(false);
      this.panel2.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private DataGridView gvListe;
    private Button btnListele;
    private Panel panel2;
    private RadioButton radioButtonSil;
    private RadioButton radioButtonDuzenle;
    private RadioButton radioButtonEkle;
    private TextBox txtSoyad;
    private Label label2;
    private TextBox txtAd;
    private Label label1;
    private Button btnIslem;
  }
}