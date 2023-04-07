namespace Market.Test.Sqlite.Forms
{
  partial class Yayinevleri
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
      this.btnIslem = new System.Windows.Forms.Button();
      this.btnListele = new System.Windows.Forms.Button();
      this.panel2 = new System.Windows.Forms.Panel();
      this.radioButtonSil = new System.Windows.Forms.RadioButton();
      this.radioButtonDuzenle = new System.Windows.Forms.RadioButton();
      this.radioButtonEkle = new System.Windows.Forms.RadioButton();
      this.txtTanim = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.gvListe = new System.Windows.Forms.DataGridView();
      this.yayineviBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.tanimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ıdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ısDeletedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
      this.ısActiveDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
      this.panel2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.gvListe)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.yayineviBindingSource)).BeginInit();
      this.SuspendLayout();
      // 
      // btnIslem
      // 
      this.btnIslem.Location = new System.Drawing.Point(37, 302);
      this.btnIslem.Name = "btnIslem";
      this.btnIslem.Size = new System.Drawing.Size(75, 23);
      this.btnIslem.TabIndex = 8;
      this.btnIslem.Text = "Kaydet / Sil";
      this.btnIslem.UseVisualStyleBackColor = true;
      this.btnIslem.Click += new System.EventHandler(this.btnIslem_Click);
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
      this.panel2.Controls.Add(this.txtTanim);
      this.panel2.Controls.Add(this.label1);
      this.panel2.Controls.Add(this.btnListele);
      this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
      this.panel2.Location = new System.Drawing.Point(0, 0);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(181, 450);
      this.panel2.TabIndex = 7;
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
      // txtTanim
      // 
      this.txtTanim.Location = new System.Drawing.Point(12, 256);
      this.txtTanim.Name = "txtTanim";
      this.txtTanim.Size = new System.Drawing.Size(100, 23);
      this.txtTanim.TabIndex = 2;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 238);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(39, 15);
      this.label1.TabIndex = 1;
      this.label1.Text = "Tanım";
      // 
      // gvListe
      // 
      this.gvListe.AutoGenerateColumns = false;
      this.gvListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.gvListe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tanimDataGridViewTextBoxColumn,
            this.ıdDataGridViewTextBoxColumn,
            this.ısDeletedDataGridViewCheckBoxColumn,
            this.ısActiveDataGridViewCheckBoxColumn});
      this.gvListe.DataSource = this.yayineviBindingSource;
      this.gvListe.Dock = System.Windows.Forms.DockStyle.Fill;
      this.gvListe.Location = new System.Drawing.Point(181, 0);
      this.gvListe.Name = "gvListe";
      this.gvListe.RowTemplate.Height = 25;
      this.gvListe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.gvListe.Size = new System.Drawing.Size(619, 450);
      this.gvListe.TabIndex = 8;
      // 
      // yayineviBindingSource
      // 
      this.yayineviBindingSource.DataSource = typeof(Market.Test.Sqlite.Models.Yayinevi);
      // 
      // tanimDataGridViewTextBoxColumn
      // 
      this.tanimDataGridViewTextBoxColumn.DataPropertyName = "Tanim";
      this.tanimDataGridViewTextBoxColumn.HeaderText = "Tanim";
      this.tanimDataGridViewTextBoxColumn.Name = "tanimDataGridViewTextBoxColumn";
      // 
      // ıdDataGridViewTextBoxColumn
      // 
      this.ıdDataGridViewTextBoxColumn.DataPropertyName = "Id";
      this.ıdDataGridViewTextBoxColumn.HeaderText = "Id";
      this.ıdDataGridViewTextBoxColumn.Name = "ıdDataGridViewTextBoxColumn";
      this.ıdDataGridViewTextBoxColumn.ReadOnly = true;
      // 
      // ısDeletedDataGridViewCheckBoxColumn
      // 
      this.ısDeletedDataGridViewCheckBoxColumn.DataPropertyName = "IsDeleted";
      this.ısDeletedDataGridViewCheckBoxColumn.HeaderText = "IsDeleted";
      this.ısDeletedDataGridViewCheckBoxColumn.Name = "ısDeletedDataGridViewCheckBoxColumn";
      // 
      // ısActiveDataGridViewCheckBoxColumn
      // 
      this.ısActiveDataGridViewCheckBoxColumn.DataPropertyName = "IsActive";
      this.ısActiveDataGridViewCheckBoxColumn.HeaderText = "IsActive";
      this.ısActiveDataGridViewCheckBoxColumn.Name = "ısActiveDataGridViewCheckBoxColumn";
      // 
      // Yayinevleri
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.gvListe);
      this.Controls.Add(this.panel2);
      this.Name = "Yayinevleri";
      this.Text = "Yayinevleri";
      this.Load += new System.EventHandler(this.Yayinevleri_Load);
      this.panel2.ResumeLayout(false);
      this.panel2.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.gvListe)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.yayineviBindingSource)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private Button btnIslem;
    private Button btnListele;
    private Panel panel2;
    private RadioButton radioButtonSil;
    private RadioButton radioButtonDuzenle;
    private RadioButton radioButtonEkle;
    private TextBox txtTanim;
    private Label label1;
    private DataGridView gvListe;
    private DataGridViewTextBoxColumn tanimDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn ıdDataGridViewTextBoxColumn;
    private DataGridViewCheckBoxColumn ısDeletedDataGridViewCheckBoxColumn;
    private DataGridViewCheckBoxColumn ısActiveDataGridViewCheckBoxColumn;
    private BindingSource yayineviBindingSource;
  }
}