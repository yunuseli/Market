namespace HesapMak
{
  partial class HesapMakinasi
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HesapMakinasi));
      this.textBoxSayi1 = new System.Windows.Forms.TextBox();
      this.textBoxSayi2 = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.buttonTopla = new System.Windows.Forms.Button();
      this.buttonCarp = new System.Windows.Forms.Button();
      this.buttonBol = new System.Windows.Forms.Button();
      this.buttonCikar = new System.Windows.Forms.Button();
      this.label3 = new System.Windows.Forms.Label();
      this.labelSonuc = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // textBoxSayi1
      // 
      this.textBoxSayi1.Location = new System.Drawing.Point(70, 58);
      this.textBoxSayi1.Name = "textBoxSayi1";
      this.textBoxSayi1.Size = new System.Drawing.Size(173, 27);
      this.textBoxSayi1.TabIndex = 0;
      // 
      // textBoxSayi2
      // 
      this.textBoxSayi2.Location = new System.Drawing.Point(70, 91);
      this.textBoxSayi2.Name = "textBoxSayi2";
      this.textBoxSayi2.Size = new System.Drawing.Size(173, 27);
      this.textBoxSayi2.TabIndex = 1;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 61);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(48, 20);
      this.label1.TabIndex = 2;
      this.label1.Text = "Sayı 1";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(12, 94);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(48, 20);
      this.label2.TabIndex = 3;
      this.label2.Text = "Sayı 2";
      // 
      // buttonTopla
      // 
      this.buttonTopla.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.buttonTopla.Location = new System.Drawing.Point(75, 142);
      this.buttonTopla.Name = "buttonTopla";
      this.buttonTopla.Size = new System.Drawing.Size(63, 61);
      this.buttonTopla.TabIndex = 4;
      this.buttonTopla.Text = "+";
      this.buttonTopla.UseVisualStyleBackColor = true;
      this.buttonTopla.Click += new System.EventHandler(this.button_Click);
      // 
      // buttonCarp
      // 
      this.buttonCarp.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.buttonCarp.Location = new System.Drawing.Point(282, 142);
      this.buttonCarp.Name = "buttonCarp";
      this.buttonCarp.Size = new System.Drawing.Size(63, 61);
      this.buttonCarp.TabIndex = 5;
      this.buttonCarp.Text = "*";
      this.buttonCarp.UseVisualStyleBackColor = true;
      this.buttonCarp.Click += new System.EventHandler(this.button_Click);
      // 
      // buttonBol
      // 
      this.buttonBol.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.buttonBol.Location = new System.Drawing.Point(213, 142);
      this.buttonBol.Name = "buttonBol";
      this.buttonBol.Size = new System.Drawing.Size(63, 61);
      this.buttonBol.TabIndex = 6;
      this.buttonBol.Text = "/";
      this.buttonBol.UseVisualStyleBackColor = true;
      this.buttonBol.Click += new System.EventHandler(this.button_Click);
      // 
      // buttonCikar
      // 
      this.buttonCikar.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.buttonCikar.Location = new System.Drawing.Point(144, 142);
      this.buttonCikar.Name = "buttonCikar";
      this.buttonCikar.Size = new System.Drawing.Size(63, 61);
      this.buttonCikar.TabIndex = 7;
      this.buttonCikar.Text = "-";
      this.buttonCikar.UseVisualStyleBackColor = true;
      this.buttonCikar.Click += new System.EventHandler(this.button_Click);
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(25, 236);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(49, 20);
      this.label3.TabIndex = 8;
      this.label3.Text = "Sonuç";
      // 
      // labelSonuc
      // 
      this.labelSonuc.AutoSize = true;
      this.labelSonuc.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.labelSonuc.ForeColor = System.Drawing.Color.IndianRed;
      this.labelSonuc.Location = new System.Drawing.Point(75, 276);
      this.labelSonuc.Name = "labelSonuc";
      this.labelSonuc.Size = new System.Drawing.Size(81, 38);
      this.labelSonuc.TabIndex = 9;
      this.labelSonuc.Text = "0000";
      // 
      // HesapMakinasi
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(374, 348);
      this.Controls.Add(this.labelSonuc);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.buttonCikar);
      this.Controls.Add(this.buttonBol);
      this.Controls.Add(this.buttonCarp);
      this.Controls.Add(this.buttonTopla);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.textBoxSayi2);
      this.Controls.Add(this.textBoxSayi1);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "HesapMakinasi";
      this.Text = "Hesap Makinası";
      this.Load += new System.EventHandler(this.HesapMakinasi_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private TextBox textBoxSayi1;
    private TextBox textBoxSayi2;
    private Label label1;
    private Label label2;
    private Button buttonTopla;
    private Button buttonCarp;
    private Button buttonBol;
    private Button buttonCikar;
    private Label label3;
    private Label labelSonuc;
  }
}