namespace Ornekler.Projeler.ComboboxOrnekler
{
  partial class MarkaModel
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
      this.cmbMarka = new System.Windows.Forms.ComboBox();
      this.cmbModel = new System.Windows.Forms.ComboBox();
      this.btnGoster = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.comboBox1 = new System.Windows.Forms.ComboBox();
      this.SuspendLayout();
      // 
      // cmbMarka
      // 
      this.cmbMarka.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.cmbMarka.FormattingEnabled = true;
      this.cmbMarka.Location = new System.Drawing.Point(38, 59);
      this.cmbMarka.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.cmbMarka.Name = "cmbMarka";
      this.cmbMarka.Size = new System.Drawing.Size(298, 44);
      this.cmbMarka.TabIndex = 0;
      this.cmbMarka.SelectedIndexChanged += new System.EventHandler(this.cmbMarka_SelectedIndexChanged);
      // 
      // cmbModel
      // 
      this.cmbModel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.cmbModel.FormattingEnabled = true;
      this.cmbModel.Location = new System.Drawing.Point(38, 151);
      this.cmbModel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.cmbModel.Name = "cmbModel";
      this.cmbModel.Size = new System.Drawing.Size(298, 44);
      this.cmbModel.TabIndex = 1;
      // 
      // btnGoster
      // 
      this.btnGoster.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.btnGoster.Location = new System.Drawing.Point(185, 239);
      this.btnGoster.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.btnGoster.Name = "btnGoster";
      this.btnGoster.Size = new System.Drawing.Size(151, 75);
      this.btnGoster.TabIndex = 2;
      this.btnGoster.Text = "Göster";
      this.btnGoster.UseVisualStyleBackColor = true;
      this.btnGoster.Click += new System.EventHandler(this.btnGoster_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(38, 32);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(50, 20);
      this.label1.TabIndex = 3;
      this.label1.Text = "Marka";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(38, 127);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(52, 20);
      this.label2.TabIndex = 4;
      this.label2.Text = "Model";
      // 
      // comboBox1
      // 
      this.comboBox1.FormattingEnabled = true;
      this.comboBox1.Items.AddRange(new object[] {
            "a",
            "b",
            "c",
            "d",
            "e",
            "f"});
      this.comboBox1.Location = new System.Drawing.Point(422, 80);
      this.comboBox1.Name = "comboBox1";
      this.comboBox1.Size = new System.Drawing.Size(267, 28);
      this.comboBox1.TabIndex = 5;
      // 
      // MarkaModel
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(914, 600);
      this.Controls.Add(this.comboBox1);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.btnGoster);
      this.Controls.Add(this.cmbModel);
      this.Controls.Add(this.cmbMarka);
      this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.Name = "MarkaModel";
      this.Text = "MarkaModel";
      this.Load += new System.EventHandler(this.MarkaModel_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private ComboBox cmbMarka;
    private ComboBox cmbModel;
    private Button btnGoster;
    private Label label1;
    private Label label2;
    private ComboBox comboBox1;
  }
}