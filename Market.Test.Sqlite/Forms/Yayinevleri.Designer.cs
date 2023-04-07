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
      this.gvListe = new System.Windows.Forms.DataGridView();
      this.tanimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ıdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ısDeletedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
      this.ısActiveDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
      this.yayineviBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.panel2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.gvListe)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.yayineviBindingSource)).BeginInit();
      this.SuspendLayout();
      // 
      // btnIslem
      // 
      this.btnIslem.Location = new System.Drawing.Point(14, 66);
      this.btnIslem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.btnIslem.Name = "btnIslem";
      this.btnIslem.Size = new System.Drawing.Size(136, 31);
      this.btnIslem.TabIndex = 8;
      this.btnIslem.Text = "Kaydet / Sil";
      this.btnIslem.UseVisualStyleBackColor = true;
      this.btnIslem.Click += new System.EventHandler(this.btnIslem_Click);
      // 
      // btnListele
      // 
      this.btnListele.Location = new System.Drawing.Point(14, 16);
      this.btnListele.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.btnListele.Name = "btnListele";
      this.btnListele.Size = new System.Drawing.Size(86, 31);
      this.btnListele.TabIndex = 0;
      this.btnListele.Text = "Listele";
      this.btnListele.UseVisualStyleBackColor = true;
      this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
      // 
      // panel2
      // 
      this.panel2.Controls.Add(this.btnIslem);
      this.panel2.Controls.Add(this.btnListele);
      this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
      this.panel2.Location = new System.Drawing.Point(0, 0);
      this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(207, 600);
      this.panel2.TabIndex = 7;
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
      this.gvListe.Location = new System.Drawing.Point(207, 0);
      this.gvListe.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.gvListe.Name = "gvListe";
      this.gvListe.RowHeadersWidth = 51;
      this.gvListe.RowTemplate.Height = 25;
      this.gvListe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.gvListe.Size = new System.Drawing.Size(707, 600);
      this.gvListe.TabIndex = 8;
      // 
      // tanimDataGridViewTextBoxColumn
      // 
      this.tanimDataGridViewTextBoxColumn.DataPropertyName = "Tanim";
      this.tanimDataGridViewTextBoxColumn.HeaderText = "Tanim";
      this.tanimDataGridViewTextBoxColumn.MinimumWidth = 6;
      this.tanimDataGridViewTextBoxColumn.Name = "tanimDataGridViewTextBoxColumn";
      this.tanimDataGridViewTextBoxColumn.Width = 125;
      // 
      // ıdDataGridViewTextBoxColumn
      // 
      this.ıdDataGridViewTextBoxColumn.DataPropertyName = "Id";
      this.ıdDataGridViewTextBoxColumn.HeaderText = "Id";
      this.ıdDataGridViewTextBoxColumn.MinimumWidth = 6;
      this.ıdDataGridViewTextBoxColumn.Name = "ıdDataGridViewTextBoxColumn";
      this.ıdDataGridViewTextBoxColumn.ReadOnly = true;
      this.ıdDataGridViewTextBoxColumn.Width = 125;
      // 
      // ısDeletedDataGridViewCheckBoxColumn
      // 
      this.ısDeletedDataGridViewCheckBoxColumn.DataPropertyName = "IsDeleted";
      this.ısDeletedDataGridViewCheckBoxColumn.HeaderText = "IsDeleted";
      this.ısDeletedDataGridViewCheckBoxColumn.MinimumWidth = 6;
      this.ısDeletedDataGridViewCheckBoxColumn.Name = "ısDeletedDataGridViewCheckBoxColumn";
      this.ısDeletedDataGridViewCheckBoxColumn.Width = 125;
      // 
      // ısActiveDataGridViewCheckBoxColumn
      // 
      this.ısActiveDataGridViewCheckBoxColumn.DataPropertyName = "IsActive";
      this.ısActiveDataGridViewCheckBoxColumn.HeaderText = "IsActive";
      this.ısActiveDataGridViewCheckBoxColumn.MinimumWidth = 6;
      this.ısActiveDataGridViewCheckBoxColumn.Name = "ısActiveDataGridViewCheckBoxColumn";
      this.ısActiveDataGridViewCheckBoxColumn.Width = 125;
      // 
      // yayineviBindingSource
      // 
      this.yayineviBindingSource.DataSource = typeof(Market.Test.Sqlite.Models.Yayinevi);
      // 
      // Yayinevleri
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(914, 600);
      this.Controls.Add(this.gvListe);
      this.Controls.Add(this.panel2);
      this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.Name = "Yayinevleri";
      this.Text = "Yayinevleri";
      this.Load += new System.EventHandler(this.Yayinevleri_Load);
      this.panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.gvListe)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.yayineviBindingSource)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private Button btnIslem;
    private Button btnListele;
    private Panel panel2;
    private DataGridView gvListe;
    private DataGridViewTextBoxColumn tanimDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn ıdDataGridViewTextBoxColumn;
    private DataGridViewCheckBoxColumn ısDeletedDataGridViewCheckBoxColumn;
    private DataGridViewCheckBoxColumn ısActiveDataGridViewCheckBoxColumn;
    private BindingSource yayineviBindingSource;
  }
}