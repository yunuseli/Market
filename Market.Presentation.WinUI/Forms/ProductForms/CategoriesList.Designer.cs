namespace Market.Presentation.WinUI.Forms.ProductForms
{
  partial class CategoriesList
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
      this.gvList = new System.Windows.Forms.DataGridView();
      this.pnlEdit = new System.Windows.Forms.Panel();
      this.btnList = new System.Windows.Forms.Button();
      this.btnDelete = new System.Windows.Forms.Button();
      this.btnEdit = new System.Windows.Forms.Button();
      this.btnCancel = new System.Windows.Forms.Button();
      this.btnSave = new System.Windows.Forms.Button();
      this.btnAdd = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.gvList)).BeginInit();
      this.pnlEdit.SuspendLayout();
      this.SuspendLayout();
      // 
      // gvList
      // 
      this.gvList.AllowUserToAddRows = false;
      this.gvList.AllowUserToDeleteRows = false;
      this.gvList.BackgroundColor = System.Drawing.Color.FloralWhite;
      this.gvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.gvList.Dock = System.Windows.Forms.DockStyle.Fill;
      this.gvList.Location = new System.Drawing.Point(101, 0);
      this.gvList.Name = "gvList";
      this.gvList.ReadOnly = true;
      this.gvList.RowHeadersWidth = 51;
      this.gvList.RowTemplate.Height = 25;
      this.gvList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.gvList.Size = new System.Drawing.Size(737, 421);
      this.gvList.TabIndex = 9;
      this.gvList.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gvList_CellMouseDown);
      // 
      // pnlEdit
      // 
      this.pnlEdit.Controls.Add(this.btnList);
      this.pnlEdit.Controls.Add(this.btnDelete);
      this.pnlEdit.Controls.Add(this.btnEdit);
      this.pnlEdit.Controls.Add(this.btnCancel);
      this.pnlEdit.Controls.Add(this.btnSave);
      this.pnlEdit.Controls.Add(this.btnAdd);
      this.pnlEdit.Dock = System.Windows.Forms.DockStyle.Left;
      this.pnlEdit.Location = new System.Drawing.Point(0, 0);
      this.pnlEdit.Name = "pnlEdit";
      this.pnlEdit.Size = new System.Drawing.Size(101, 421);
      this.pnlEdit.TabIndex = 10;
      // 
      // btnList
      // 
      this.btnList.Location = new System.Drawing.Point(12, 12);
      this.btnList.Name = "btnList";
      this.btnList.Size = new System.Drawing.Size(75, 23);
      this.btnList.TabIndex = 19;
      this.btnList.Tag = "List";
      this.btnList.Text = "Listele";
      this.btnList.UseVisualStyleBackColor = true;
      this.btnList.Click += new System.EventHandler(this.btnCrud_Click);
      // 
      // btnDelete
      // 
      this.btnDelete.Location = new System.Drawing.Point(12, 152);
      this.btnDelete.Name = "btnDelete";
      this.btnDelete.Size = new System.Drawing.Size(75, 23);
      this.btnDelete.TabIndex = 18;
      this.btnDelete.Tag = "Delete";
      this.btnDelete.Text = "Sil";
      this.btnDelete.UseVisualStyleBackColor = true;
      this.btnDelete.Click += new System.EventHandler(this.btnCrud_Click);
      // 
      // btnEdit
      // 
      this.btnEdit.Location = new System.Drawing.Point(12, 123);
      this.btnEdit.Name = "btnEdit";
      this.btnEdit.Size = new System.Drawing.Size(75, 23);
      this.btnEdit.TabIndex = 17;
      this.btnEdit.Tag = "Update";
      this.btnEdit.Text = "Düzenle";
      this.btnEdit.UseVisualStyleBackColor = true;
      this.btnEdit.Click += new System.EventHandler(this.btnCrud_Click);
      // 
      // btnCancel
      // 
      this.btnCancel.Location = new System.Drawing.Point(12, 278);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new System.Drawing.Size(75, 23);
      this.btnCancel.TabIndex = 16;
      this.btnCancel.Tag = "Cancel";
      this.btnCancel.Text = "İptal";
      this.btnCancel.UseVisualStyleBackColor = true;
      this.btnCancel.Click += new System.EventHandler(this.btnCrud_Click);
      // 
      // btnSave
      // 
      this.btnSave.Location = new System.Drawing.Point(12, 249);
      this.btnSave.Name = "btnSave";
      this.btnSave.Size = new System.Drawing.Size(75, 23);
      this.btnSave.TabIndex = 15;
      this.btnSave.Tag = "Save";
      this.btnSave.Text = "Kaydet";
      this.btnSave.UseVisualStyleBackColor = true;
      this.btnSave.Click += new System.EventHandler(this.btnCrud_Click);
      // 
      // btnAdd
      // 
      this.btnAdd.Location = new System.Drawing.Point(12, 94);
      this.btnAdd.Name = "btnAdd";
      this.btnAdd.Size = new System.Drawing.Size(75, 23);
      this.btnAdd.TabIndex = 14;
      this.btnAdd.Tag = "Insert";
      this.btnAdd.Text = "Ekle";
      this.btnAdd.UseVisualStyleBackColor = true;
      this.btnAdd.Click += new System.EventHandler(this.btnCrud_Click);
      // 
      // CategoriesList
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(838, 421);
      this.Controls.Add(this.gvList);
      this.Controls.Add(this.pnlEdit);
      this.Name = "CategoriesList";
      this.Text = "Kategori İşlemleri";
      this.Load += new System.EventHandler(this.CategoriesList_Load);
      ((System.ComponentModel.ISupportInitialize)(this.gvList)).EndInit();
      this.pnlEdit.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion
    private DataGridView gvList;
    private Panel pnlEdit;
    private Button btnAdd;
    private Button btnDelete;
    private Button btnEdit;
    private Button btnCancel;
    private Button btnSave;
    private Button btnList;
  }
}