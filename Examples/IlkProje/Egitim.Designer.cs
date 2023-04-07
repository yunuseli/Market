namespace IlkProje
{
  partial class Egitim
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
      System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Ekle");
      System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Düzenle");
      System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Sil");
      System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Marka", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
      System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Model");
      System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Renk");
      System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Yıl");
      System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Menü", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5,
            treeNode6,
            treeNode7});
      this.checkBox = new System.Windows.Forms.CheckBox();
      this.checkBox2 = new System.Windows.Forms.CheckBox();
      this.panel1 = new System.Windows.Forms.Panel();
      this.splitContainer1 = new System.Windows.Forms.SplitContainer();
      this.tabControl1 = new System.Windows.Forms.TabControl();
      this.tabPage1 = new System.Windows.Forms.TabPage();
      this.tabPage2 = new System.Windows.Forms.TabPage();
      this.button1 = new System.Windows.Forms.Button();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.textBox2 = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.button2 = new System.Windows.Forms.Button();
      this.label2 = new System.Windows.Forms.Label();
      this.treeView1 = new System.Windows.Forms.TreeView();
      this.label3 = new System.Windows.Forms.Label();
      this.linkLabel1 = new System.Windows.Forms.LinkLabel();
      this.listBox1 = new System.Windows.Forms.ListBox();
      this.panel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
      this.splitContainer1.Panel1.SuspendLayout();
      this.splitContainer1.Panel2.SuspendLayout();
      this.splitContainer1.SuspendLayout();
      this.tabControl1.SuspendLayout();
      this.tabPage1.SuspendLayout();
      this.tabPage2.SuspendLayout();
      this.SuspendLayout();
      // 
      // checkBox
      // 
      this.checkBox.AutoSize = true;
      this.checkBox.Location = new System.Drawing.Point(30, 35);
      this.checkBox.Name = "checkBox";
      this.checkBox.Size = new System.Drawing.Size(83, 19);
      this.checkBox.TabIndex = 0;
      this.checkBox.Text = "checkBox1";
      this.checkBox.UseVisualStyleBackColor = true;
      // 
      // checkBox2
      // 
      this.checkBox2.AutoSize = true;
      this.checkBox2.Location = new System.Drawing.Point(30, 70);
      this.checkBox2.Name = "checkBox2";
      this.checkBox2.Size = new System.Drawing.Size(83, 19);
      this.checkBox2.TabIndex = 1;
      this.checkBox2.Text = "checkBox2";
      this.checkBox2.UseVisualStyleBackColor = true;
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.checkBox);
      this.panel1.Controls.Add(this.checkBox2);
      this.panel1.Location = new System.Drawing.Point(22, 34);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(329, 184);
      this.panel1.TabIndex = 2;
      // 
      // splitContainer1
      // 
      this.splitContainer1.Location = new System.Drawing.Point(390, 34);
      this.splitContainer1.Name = "splitContainer1";
      // 
      // splitContainer1.Panel1
      // 
      this.splitContainer1.Panel1.Controls.Add(this.treeView1);
      this.splitContainer1.Panel1.Controls.Add(this.label2);
      // 
      // splitContainer1.Panel2
      // 
      this.splitContainer1.Panel2.Controls.Add(this.listBox1);
      this.splitContainer1.Panel2.Controls.Add(this.linkLabel1);
      this.splitContainer1.Panel2.Controls.Add(this.label3);
      this.splitContainer1.Size = new System.Drawing.Size(421, 357);
      this.splitContainer1.SplitterDistance = 140;
      this.splitContainer1.TabIndex = 3;
      // 
      // tabControl1
      // 
      this.tabControl1.Controls.Add(this.tabPage1);
      this.tabControl1.Controls.Add(this.tabPage2);
      this.tabControl1.Location = new System.Drawing.Point(24, 238);
      this.tabControl1.Name = "tabControl1";
      this.tabControl1.SelectedIndex = 0;
      this.tabControl1.Size = new System.Drawing.Size(327, 286);
      this.tabControl1.TabIndex = 4;
      // 
      // tabPage1
      // 
      this.tabPage1.Controls.Add(this.button1);
      this.tabPage1.Location = new System.Drawing.Point(4, 24);
      this.tabPage1.Name = "tabPage1";
      this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage1.Size = new System.Drawing.Size(344, 258);
      this.tabPage1.TabIndex = 0;
      this.tabPage1.Text = "tabPage1";
      this.tabPage1.UseVisualStyleBackColor = true;
      // 
      // tabPage2
      // 
      this.tabPage2.Controls.Add(this.button2);
      this.tabPage2.Controls.Add(this.label1);
      this.tabPage2.Controls.Add(this.textBox2);
      this.tabPage2.Controls.Add(this.textBox1);
      this.tabPage2.Location = new System.Drawing.Point(4, 24);
      this.tabPage2.Name = "tabPage2";
      this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage2.Size = new System.Drawing.Size(319, 258);
      this.tabPage2.TabIndex = 1;
      this.tabPage2.Text = "tabPage2";
      this.tabPage2.UseVisualStyleBackColor = true;
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(32, 39);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(75, 23);
      this.button1.TabIndex = 0;
      this.button1.Text = "button1";
      this.button1.UseVisualStyleBackColor = true;
      // 
      // textBox1
      // 
      this.textBox1.Location = new System.Drawing.Point(33, 44);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(224, 23);
      this.textBox1.TabIndex = 0;
      // 
      // textBox2
      // 
      this.textBox2.Location = new System.Drawing.Point(33, 73);
      this.textBox2.Name = "textBox2";
      this.textBox2.Size = new System.Drawing.Size(224, 23);
      this.textBox2.TabIndex = 1;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(39, 18);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(38, 15);
      this.label1.TabIndex = 2;
      this.label1.Text = "label1";
      // 
      // button2
      // 
      this.button2.Location = new System.Drawing.Point(182, 102);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(75, 23);
      this.button2.TabIndex = 3;
      this.button2.Text = "button2";
      this.button2.UseVisualStyleBackColor = true;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(13, 16);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(38, 15);
      this.label2.TabIndex = 0;
      this.label2.Text = "label2";
      // 
      // treeView1
      // 
      this.treeView1.Location = new System.Drawing.Point(12, 61);
      this.treeView1.Name = "treeView1";
      treeNode1.Name = "Node5";
      treeNode1.Text = "Ekle";
      treeNode2.Name = "Node6";
      treeNode2.Text = "Düzenle";
      treeNode3.Name = "Node7";
      treeNode3.Text = "Sil";
      treeNode4.Name = "Node1";
      treeNode4.Text = "Marka";
      treeNode5.Name = "Node2";
      treeNode5.Text = "Model";
      treeNode6.Name = "Node3";
      treeNode6.Text = "Renk";
      treeNode7.Name = "Node4";
      treeNode7.Text = "Yıl";
      treeNode8.Name = "Node0";
      treeNode8.Text = "Menü";
      this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode8});
      this.treeView1.Size = new System.Drawing.Size(121, 242);
      this.treeView1.TabIndex = 1;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(54, 60);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(38, 15);
      this.label3.TabIndex = 0;
      this.label3.Text = "label3";
      // 
      // linkLabel1
      // 
      this.linkLabel1.AutoSize = true;
      this.linkLabel1.Location = new System.Drawing.Point(52, 96);
      this.linkLabel1.Name = "linkLabel1";
      this.linkLabel1.Size = new System.Drawing.Size(60, 15);
      this.linkLabel1.TabIndex = 1;
      this.linkLabel1.TabStop = true;
      this.linkLabel1.Text = "linkLabel1";
      // 
      // listBox1
      // 
      this.listBox1.FormattingEnabled = true;
      this.listBox1.ItemHeight = 15;
      this.listBox1.Location = new System.Drawing.Point(44, 133);
      this.listBox1.Name = "listBox1";
      this.listBox1.Size = new System.Drawing.Size(173, 184);
      this.listBox1.TabIndex = 2;
      // 
      // Egitim
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1116, 602);
      this.Controls.Add(this.tabControl1);
      this.Controls.Add(this.splitContainer1);
      this.Controls.Add(this.panel1);
      this.Name = "Egitim";
      this.Text = "Egitim";
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.splitContainer1.Panel1.ResumeLayout(false);
      this.splitContainer1.Panel1.PerformLayout();
      this.splitContainer1.Panel2.ResumeLayout(false);
      this.splitContainer1.Panel2.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
      this.splitContainer1.ResumeLayout(false);
      this.tabControl1.ResumeLayout(false);
      this.tabPage1.ResumeLayout(false);
      this.tabPage2.ResumeLayout(false);
      this.tabPage2.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private CheckBox checkBox;
    private CheckBox checkBox2;
    private Panel panel1;
    private SplitContainer splitContainer1;
    private TreeView treeView1;
    private Label label2;
    private ListBox listBox1;
    private LinkLabel linkLabel1;
    private Label label3;
    private TabControl tabControl1;
    private TabPage tabPage1;
    private Button button1;
    private TabPage tabPage2;
    private Button button2;
    private Label label1;
    private TextBox textBox2;
    private TextBox textBox1;
  }
}