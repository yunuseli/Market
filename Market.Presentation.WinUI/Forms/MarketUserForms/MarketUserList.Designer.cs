namespace Market.Presentation.WinUI.Forms.MarketUserForms
{
  partial class MarketUserList
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
      this.buttonList = new System.Windows.Forms.Button();
      this.panelTop = new System.Windows.Forms.Panel();
      this.btnFind = new System.Windows.Forms.Button();
      this.txtFilter = new System.Windows.Forms.TextBox();
      this.label11 = new System.Windows.Forms.Label();
      this.btnCopyAll = new System.Windows.Forms.Button();
      this.btnExcel = new System.Windows.Forms.Button();
      this.btnPrint = new System.Windows.Forms.Button();
      this.gvList = new System.Windows.Forms.DataGridView();
      this.cmsGrid = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.ekleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.düzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.panelTop.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.gvList)).BeginInit();
      this.cmsGrid.SuspendLayout();
      this.SuspendLayout();
      // 
      // buttonList
      // 
      this.buttonList.Location = new System.Drawing.Point(12, 8);
      this.buttonList.Name = "buttonList";
      this.buttonList.Size = new System.Drawing.Size(75, 23);
      this.buttonList.TabIndex = 7;
      this.buttonList.Text = "Listele";
      this.buttonList.UseVisualStyleBackColor = true;
      this.buttonList.Click += new System.EventHandler(this.buttonList_Click);
      // 
      // panelTop
      // 
      this.panelTop.Controls.Add(this.btnFind);
      this.panelTop.Controls.Add(this.txtFilter);
      this.panelTop.Controls.Add(this.label11);
      this.panelTop.Controls.Add(this.btnCopyAll);
      this.panelTop.Controls.Add(this.btnExcel);
      this.panelTop.Controls.Add(this.btnPrint);
      this.panelTop.Controls.Add(this.buttonList);
      this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
      this.panelTop.Location = new System.Drawing.Point(0, 0);
      this.panelTop.Name = "panelTop";
      this.panelTop.Size = new System.Drawing.Size(838, 38);
      this.panelTop.TabIndex = 8;
      // 
      // btnFind
      // 
      this.btnFind.Location = new System.Drawing.Point(649, 8);
      this.btnFind.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.btnFind.Name = "btnFind";
      this.btnFind.Size = new System.Drawing.Size(66, 23);
      this.btnFind.TabIndex = 13;
      this.btnFind.Text = "Ara";
      this.btnFind.UseVisualStyleBackColor = true;
      this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
      // 
      // txtFilter
      // 
      this.txtFilter.Location = new System.Drawing.Point(479, 8);
      this.txtFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.txtFilter.Name = "txtFilter";
      this.txtFilter.Size = new System.Drawing.Size(164, 23);
      this.txtFilter.TabIndex = 12;
      // 
      // label11
      // 
      this.label11.AutoSize = true;
      this.label11.Location = new System.Drawing.Point(440, 12);
      this.label11.Name = "label11";
      this.label11.Size = new System.Drawing.Size(33, 15);
      this.label11.TabIndex = 11;
      this.label11.Text = "Filtre";
      // 
      // btnCopyAll
      // 
      this.btnCopyAll.Location = new System.Drawing.Point(273, 8);
      this.btnCopyAll.Name = "btnCopyAll";
      this.btnCopyAll.Size = new System.Drawing.Size(115, 23);
      this.btnCopyAll.TabIndex = 10;
      this.btnCopyAll.Text = "Tümünü Kopyala";
      this.btnCopyAll.UseVisualStyleBackColor = true;
      this.btnCopyAll.Click += new System.EventHandler(this.btnCopyAll_Click);
      // 
      // btnExcel
      // 
      this.btnExcel.Location = new System.Drawing.Point(174, 8);
      this.btnExcel.Name = "btnExcel";
      this.btnExcel.Size = new System.Drawing.Size(93, 23);
      this.btnExcel.TabIndex = 9;
      this.btnExcel.Text = "Excele Aktar";
      this.btnExcel.UseVisualStyleBackColor = true;
      this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
      // 
      // btnPrint
      // 
      this.btnPrint.Location = new System.Drawing.Point(93, 9);
      this.btnPrint.Name = "btnPrint";
      this.btnPrint.Size = new System.Drawing.Size(75, 23);
      this.btnPrint.TabIndex = 8;
      this.btnPrint.Text = "Yazdır";
      this.btnPrint.UseVisualStyleBackColor = true;
      this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
      // 
      // gvList
      // 
      this.gvList.AllowUserToAddRows = false;
      this.gvList.AllowUserToDeleteRows = false;
      this.gvList.BackgroundColor = System.Drawing.Color.FloralWhite;
      this.gvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.gvList.Dock = System.Windows.Forms.DockStyle.Fill;
      this.gvList.Location = new System.Drawing.Point(0, 38);
      this.gvList.Name = "gvList";
      this.gvList.ReadOnly = true;
      this.gvList.RowHeadersWidth = 51;
      this.gvList.RowTemplate.Height = 25;
      this.gvList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.gvList.Size = new System.Drawing.Size(838, 383);
      this.gvList.TabIndex = 9;
      this.gvList.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gvList_CellMouseDown);
      this.gvList.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvList_CellMouseLeave);
      this.gvList.CellMouseMove += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gvList_CellMouseMove);
      // 
      // cmsGrid
      // 
      this.cmsGrid.ImageScalingSize = new System.Drawing.Size(20, 20);
      this.cmsGrid.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ekleToolStripMenuItem,
            this.düzenleToolStripMenuItem,
            this.silToolStripMenuItem});
      this.cmsGrid.Name = "cmsGrid";
      this.cmsGrid.Size = new System.Drawing.Size(117, 70);
      // 
      // ekleToolStripMenuItem
      // 
      this.ekleToolStripMenuItem.Name = "ekleToolStripMenuItem";
      this.ekleToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
      this.ekleToolStripMenuItem.Tag = "Add";
      this.ekleToolStripMenuItem.Text = "Ekle";
      this.ekleToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuGrid_Click);
      // 
      // düzenleToolStripMenuItem
      // 
      this.düzenleToolStripMenuItem.Name = "düzenleToolStripMenuItem";
      this.düzenleToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
      this.düzenleToolStripMenuItem.Tag = "Edit";
      this.düzenleToolStripMenuItem.Text = "Düzenle";
      this.düzenleToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuGrid_Click);
      // 
      // silToolStripMenuItem
      // 
      this.silToolStripMenuItem.Name = "silToolStripMenuItem";
      this.silToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
      this.silToolStripMenuItem.Tag = "Delete";
      this.silToolStripMenuItem.Text = "Sil";
      this.silToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuGrid_Click);
      // 
      // MarketUserList
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(838, 421);
      this.Controls.Add(this.gvList);
      this.Controls.Add(this.panelTop);
      this.Name = "MarketUserList";
      this.Text = "Kullanıcı Listesi ve İşlemleri";
      this.Load += new System.EventHandler(this.MarketUserList_Load);
      this.panelTop.ResumeLayout(false);
      this.panelTop.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.gvList)).EndInit();
      this.cmsGrid.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private Button buttonList;
    private Panel panelTop;
    private DataGridView gvList;
    private ContextMenuStrip cmsGrid;
    private ToolStripMenuItem ekleToolStripMenuItem;
    private ToolStripMenuItem düzenleToolStripMenuItem;
    private ToolStripMenuItem silToolStripMenuItem;
    private Button btnPrint;
    private Button btnExcel;
    private Button btnCopyAll;
    private Button btnFind;
    private TextBox txtFilter;
    private Label label11;
  }
}