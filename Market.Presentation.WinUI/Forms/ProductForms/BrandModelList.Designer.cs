namespace Market.Presentation.WinUI.Forms.ProductForms
{
  partial class BrandModelList
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
      this.gvBrand = new System.Windows.Forms.DataGridView();
      this.pnlEdit = new System.Windows.Forms.Panel();
      this.btnList = new System.Windows.Forms.Button();
      this.btnDelete = new System.Windows.Forms.Button();
      this.btnEdit = new System.Windows.Forms.Button();
      this.btnCancel = new System.Windows.Forms.Button();
      this.btnSave = new System.Windows.Forms.Button();
      this.btnAdd = new System.Windows.Forms.Button();
      this.pnlTree = new System.Windows.Forms.Panel();
      this.treeViewList = new System.Windows.Forms.TreeView();
      this.gvModel = new System.Windows.Forms.DataGridView();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.pnlGrid = new System.Windows.Forms.Panel();
      ((System.ComponentModel.ISupportInitialize)(this.gvBrand)).BeginInit();
      this.pnlEdit.SuspendLayout();
      this.pnlTree.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.gvModel)).BeginInit();
      this.pnlGrid.SuspendLayout();
      this.SuspendLayout();
      // 
      // gvBrand
      // 
      this.gvBrand.AllowUserToAddRows = false;
      this.gvBrand.AllowUserToDeleteRows = false;
      this.gvBrand.BackgroundColor = System.Drawing.Color.FloralWhite;
      this.gvBrand.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.gvBrand.Location = new System.Drawing.Point(12, 27);
      this.gvBrand.Name = "gvBrand";
      this.gvBrand.ReadOnly = true;
      this.gvBrand.RowHeadersWidth = 51;
      this.gvBrand.RowTemplate.Height = 25;
      this.gvBrand.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.gvBrand.Size = new System.Drawing.Size(212, 272);
      this.gvBrand.TabIndex = 9;
      this.gvBrand.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gvList_CellMouseDown);
      this.gvBrand.SelectionChanged += new System.EventHandler(this.gvBrand_SelectionChanged);
      // 
      // pnlEdit
      // 
      this.pnlEdit.Controls.Add(this.btnList);
      this.pnlEdit.Controls.Add(this.btnDelete);
      this.pnlEdit.Controls.Add(this.btnEdit);
      this.pnlEdit.Controls.Add(this.btnCancel);
      this.pnlEdit.Controls.Add(this.btnSave);
      this.pnlEdit.Controls.Add(this.btnAdd);
      this.pnlEdit.Dock = System.Windows.Forms.DockStyle.Top;
      this.pnlEdit.Location = new System.Drawing.Point(0, 0);
      this.pnlEdit.Name = "pnlEdit";
      this.pnlEdit.Size = new System.Drawing.Size(838, 76);
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
      this.btnDelete.Location = new System.Drawing.Point(270, 12);
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
      this.btnEdit.Location = new System.Drawing.Point(189, 12);
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
      this.btnCancel.Location = new System.Drawing.Point(627, 42);
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
      this.btnSave.Location = new System.Drawing.Point(546, 42);
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
      this.btnAdd.Location = new System.Drawing.Point(108, 12);
      this.btnAdd.Name = "btnAdd";
      this.btnAdd.Size = new System.Drawing.Size(75, 23);
      this.btnAdd.TabIndex = 14;
      this.btnAdd.Tag = "Insert";
      this.btnAdd.Text = "Ekle";
      this.btnAdd.UseVisualStyleBackColor = true;
      this.btnAdd.Click += new System.EventHandler(this.btnCrud_Click);
      // 
      // pnlTree
      // 
      this.pnlTree.Controls.Add(this.treeViewList);
      this.pnlTree.Dock = System.Windows.Forms.DockStyle.Left;
      this.pnlTree.Location = new System.Drawing.Point(0, 76);
      this.pnlTree.Name = "pnlTree";
      this.pnlTree.Size = new System.Drawing.Size(239, 345);
      this.pnlTree.TabIndex = 11;
      // 
      // treeViewList
      // 
      this.treeViewList.Dock = System.Windows.Forms.DockStyle.Fill;
      this.treeViewList.Location = new System.Drawing.Point(0, 0);
      this.treeViewList.Name = "treeViewList";
      this.treeViewList.Size = new System.Drawing.Size(239, 345);
      this.treeViewList.TabIndex = 0;
      this.treeViewList.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewList_AfterSelect);
      // 
      // gvModel
      // 
      this.gvModel.AllowUserToAddRows = false;
      this.gvModel.AllowUserToDeleteRows = false;
      this.gvModel.BackgroundColor = System.Drawing.Color.LightYellow;
      this.gvModel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.gvModel.Location = new System.Drawing.Point(237, 27);
      this.gvModel.Name = "gvModel";
      this.gvModel.ReadOnly = true;
      this.gvModel.RowHeadersWidth = 51;
      this.gvModel.RowTemplate.Height = 25;
      this.gvModel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.gvModel.Size = new System.Drawing.Size(240, 272);
      this.gvModel.TabIndex = 12;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 9);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(53, 15);
      this.label1.TabIndex = 13;
      this.label1.Text = "Markalar";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(237, 9);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(54, 15);
      this.label2.TabIndex = 14;
      this.label2.Text = "Modeller";
      // 
      // pnlGrid
      // 
      this.pnlGrid.Controls.Add(this.label2);
      this.pnlGrid.Controls.Add(this.label1);
      this.pnlGrid.Controls.Add(this.gvBrand);
      this.pnlGrid.Controls.Add(this.gvModel);
      this.pnlGrid.Dock = System.Windows.Forms.DockStyle.Fill;
      this.pnlGrid.Location = new System.Drawing.Point(239, 76);
      this.pnlGrid.Name = "pnlGrid";
      this.pnlGrid.Size = new System.Drawing.Size(599, 345);
      this.pnlGrid.TabIndex = 20;
      // 
      // BrandModelList
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(838, 421);
      this.Controls.Add(this.pnlGrid);
      this.Controls.Add(this.pnlTree);
      this.Controls.Add(this.pnlEdit);
      this.Name = "BrandModelList";
      this.Text = "Marka Model İşlemleri";
      this.Load += new System.EventHandler(this.BrandModelList_Load);
      ((System.ComponentModel.ISupportInitialize)(this.gvBrand)).EndInit();
      this.pnlEdit.ResumeLayout(false);
      this.pnlTree.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.gvModel)).EndInit();
      this.pnlGrid.ResumeLayout(false);
      this.pnlGrid.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion
    private DataGridView gvBrand;
    private Panel pnlEdit;
    private Button btnAdd;
    private Button btnDelete;
    private Button btnEdit;
    private Button btnCancel;
    private Button btnSave;
    private Button btnList;
    private Panel pnlTree;
    private TreeView treeViewList;
    private DataGridView gvModel;
    private Label label1;
    private Label label2;
    private Panel pnlGrid;
  }
}