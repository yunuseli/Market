namespace Ornekler.Projeler.DigerOrnekler
{
  partial class Kelime
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kelime));
      this.btnBul = new System.Windows.Forms.Button();
      this.listBoxSonuc = new System.Windows.Forms.ListBox();
      this.richTextBoxCumle = new System.Windows.Forms.RichTextBox();
      this.btnBulHarf = new System.Windows.Forms.Button();
      this.lblToplam = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // btnBul
      // 
      this.btnBul.Location = new System.Drawing.Point(12, 286);
      this.btnBul.Name = "btnBul";
      this.btnBul.Size = new System.Drawing.Size(147, 67);
      this.btnBul.TabIndex = 5;
      this.btnBul.Text = "Kelime Bul";
      this.btnBul.UseVisualStyleBackColor = true;
      this.btnBul.Click += new System.EventHandler(this.btnBul_Click);
      // 
      // listBoxSonuc
      // 
      this.listBoxSonuc.Dock = System.Windows.Forms.DockStyle.Right;
      this.listBoxSonuc.FormattingEnabled = true;
      this.listBoxSonuc.ItemHeight = 15;
      this.listBoxSonuc.Location = new System.Drawing.Point(487, 0);
      this.listBoxSonuc.Name = "listBoxSonuc";
      this.listBoxSonuc.Size = new System.Drawing.Size(313, 605);
      this.listBoxSonuc.TabIndex = 4;
      // 
      // richTextBoxCumle
      // 
      this.richTextBoxCumle.Dock = System.Windows.Forms.DockStyle.Top;
      this.richTextBoxCumle.Location = new System.Drawing.Point(0, 0);
      this.richTextBoxCumle.Name = "richTextBoxCumle";
      this.richTextBoxCumle.Size = new System.Drawing.Size(487, 280);
      this.richTextBoxCumle.TabIndex = 3;
      this.richTextBoxCumle.Text = resources.GetString("richTextBoxCumle.Text");
      // 
      // btnBulHarf
      // 
      this.btnBulHarf.Location = new System.Drawing.Point(12, 359);
      this.btnBulHarf.Name = "btnBulHarf";
      this.btnBulHarf.Size = new System.Drawing.Size(147, 67);
      this.btnBulHarf.TabIndex = 7;
      this.btnBulHarf.Text = "Harf Bul";
      this.btnBulHarf.UseVisualStyleBackColor = true;
      this.btnBulHarf.Click += new System.EventHandler(this.btnBulHarf_Click);
      // 
      // lblToplam
      // 
      this.lblToplam.AutoSize = true;
      this.lblToplam.Location = new System.Drawing.Point(187, 303);
      this.lblToplam.Name = "lblToplam";
      this.lblToplam.Size = new System.Drawing.Size(46, 15);
      this.lblToplam.TabIndex = 8;
      this.lblToplam.Text = "Toplam";
      // 
      // Kelime
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 605);
      this.Controls.Add(this.lblToplam);
      this.Controls.Add(this.btnBulHarf);
      this.Controls.Add(this.richTextBoxCumle);
      this.Controls.Add(this.btnBul);
      this.Controls.Add(this.listBoxSonuc);
      this.Name = "Kelime";
      this.Text = "Kelime";
      this.Load += new System.EventHandler(this.Kelime_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private Button btnBul;
    private ListBox listBoxKelimeler;
    private RichTextBox richTextBoxCumle;
    private ListBox listBoxToplam;
    private Button btnBulHarf;
    private ListBox listBoxSonuc;
    private Label lblToplam;
  }
}