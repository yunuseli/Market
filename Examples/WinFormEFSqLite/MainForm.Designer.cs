namespace WinFormEFSqLite
{
  partial class MainForm
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
      this.components = new System.ComponentModel.Container();
      this.gvCategory = new System.Windows.Forms.DataGridView();
      this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.gvProducts = new System.Windows.Forms.DataGridView();
      this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.btnSave = new System.Windows.Forms.Button();
      this.productsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
      ((System.ComponentModel.ISupportInitialize)(this.gvCategory)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.gvProducts)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource1)).BeginInit();
      this.SuspendLayout();
      // 
      // gvCategory
      // 
      this.gvCategory.AutoGenerateColumns = false;
      this.gvCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.gvCategory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
      this.gvCategory.DataSource = this.categoryBindingSource;
      this.gvCategory.Location = new System.Drawing.Point(37, 63);
      this.gvCategory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.gvCategory.Name = "gvCategory";
      this.gvCategory.RowHeadersWidth = 51;
      this.gvCategory.RowTemplate.Height = 25;
      this.gvCategory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.gvCategory.Size = new System.Drawing.Size(349, 484);
      this.gvCategory.TabIndex = 0;
      this.gvCategory.SelectionChanged += new System.EventHandler(this.gvCategory_SelectionChanged);
      // 
      // dataGridViewTextBoxColumn1
      // 
      this.dataGridViewTextBoxColumn1.DataPropertyName = "CategoryId";
      this.dataGridViewTextBoxColumn1.HeaderText = "Id";
      this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
      this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
      this.dataGridViewTextBoxColumn1.ReadOnly = true;
      this.dataGridViewTextBoxColumn1.Width = 125;
      // 
      // dataGridViewTextBoxColumn2
      // 
      this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
      this.dataGridViewTextBoxColumn2.HeaderText = "Tanım";
      this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
      this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
      this.dataGridViewTextBoxColumn2.Width = 125;
      // 
      // categoryBindingSource
      // 
      this.categoryBindingSource.DataSource = typeof(WinFormEFSqLite.Category);
      // 
      // gvProducts
      // 
      this.gvProducts.AutoGenerateColumns = false;
      this.gvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.gvProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
      this.gvProducts.DataSource = this.productsBindingSource;
      this.gvProducts.Location = new System.Drawing.Point(410, 63);
      this.gvProducts.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.gvProducts.Name = "gvProducts";
      this.gvProducts.RowHeadersWidth = 51;
      this.gvProducts.RowTemplate.Height = 25;
      this.gvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.gvProducts.Size = new System.Drawing.Size(455, 484);
      this.gvProducts.TabIndex = 1;
      // 
      // dataGridViewTextBoxColumn3
      // 
      this.dataGridViewTextBoxColumn3.DataPropertyName = "ProductId";
      this.dataGridViewTextBoxColumn3.HeaderText = "Id";
      this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
      this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
      this.dataGridViewTextBoxColumn3.ReadOnly = true;
      this.dataGridViewTextBoxColumn3.Width = 125;
      // 
      // dataGridViewTextBoxColumn4
      // 
      this.dataGridViewTextBoxColumn4.DataPropertyName = "Name";
      this.dataGridViewTextBoxColumn4.HeaderText = "Tanım";
      this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
      this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
      this.dataGridViewTextBoxColumn4.Width = 125;
      // 
      // productsBindingSource
      // 
      this.productsBindingSource.DataMember = "Products";
      this.productsBindingSource.DataSource = this.categoryBindingSource;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(37, 39);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(66, 20);
      this.label1.TabIndex = 2;
      this.label1.Text = "Kategori";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(410, 39);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(40, 20);
      this.label2.TabIndex = 3;
      this.label2.Text = "Ürün";
      // 
      // btnSave
      // 
      this.btnSave.Location = new System.Drawing.Point(741, 568);
      this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.btnSave.Name = "btnSave";
      this.btnSave.Size = new System.Drawing.Size(125, 51);
      this.btnSave.TabIndex = 4;
      this.btnSave.Text = "Kaydet";
      this.btnSave.UseVisualStyleBackColor = true;
      this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
      // 
      // productsBindingSource1
      // 
      this.productsBindingSource1.DataMember = "Products";
      this.productsBindingSource1.DataSource = this.categoryBindingSource;
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(886, 640);
      this.Controls.Add(this.btnSave);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.gvProducts);
      this.Controls.Add(this.gvCategory);
      this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.Name = "MainForm";
      this.Text = "Ürünler ve Kategoriler";
      this.Load += new System.EventHandler(this.MainForm_Load);
      ((System.ComponentModel.ISupportInitialize)(this.gvCategory)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.gvProducts)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private DataGridView gvCategory;
    private DataGridView gvProducts;
    private Label label1;
    private Label label2;
    private Button btnSave;
    private DataGridViewTextBoxColumn categoryIdDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn productIdDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
    private DataGridViewTextBoxColumn categoryIdDataGridViewTextBoxColumn1;
    private DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    private BindingSource categoryBindingSource;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    private BindingSource productsBindingSource;
    private BindingSource productsBindingSource1;
  }
}