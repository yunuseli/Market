namespace Ornekler
{
  partial class Giris
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Giris));
      this.label2 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.txtSifre = new System.Windows.Forms.TextBox();
      this.txtKullanici = new System.Windows.Forms.TextBox();
      this.btnGiris = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(16, 54);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(30, 15);
      this.label2.TabIndex = 9;
      this.label2.Text = "Şifre";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(16, 23);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(73, 15);
      this.label1.TabIndex = 8;
      this.label1.Text = "Kullanıcı Adı";
      // 
      // txtSifre
      // 
      this.txtSifre.Location = new System.Drawing.Point(95, 52);
      this.txtSifre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.txtSifre.Name = "txtSifre";
      this.txtSifre.PasswordChar = 'x';
      this.txtSifre.Size = new System.Drawing.Size(167, 23);
      this.txtSifre.TabIndex = 7;
      this.txtSifre.UseSystemPasswordChar = true;
      // 
      // txtKullanici
      // 
      this.txtKullanici.Location = new System.Drawing.Point(95, 20);
      this.txtKullanici.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.txtKullanici.Name = "txtKullanici";
      this.txtKullanici.Size = new System.Drawing.Size(167, 23);
      this.txtKullanici.TabIndex = 6;
      // 
      // btnGiris
      // 
      this.btnGiris.BackColor = System.Drawing.SystemColors.Control;
      this.btnGiris.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.btnGiris.Location = new System.Drawing.Point(275, 20);
      this.btnGiris.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.btnGiris.Name = "btnGiris";
      this.btnGiris.Size = new System.Drawing.Size(112, 52);
      this.btnGiris.TabIndex = 5;
      this.btnGiris.Text = "Giriş";
      this.btnGiris.UseVisualStyleBackColor = false;
      this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
      // 
      // Giris
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(397, 90);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.txtSifre);
      this.Controls.Add(this.txtKullanici);
      this.Controls.Add(this.btnGiris);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "Giris";
      this.Text = "Giris";
      this.Load += new System.EventHandler(this.Giris_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private Label label2;
    private Label label1;
    private TextBox txtSifre;
    private TextBox txtKullanici;
    private Button btnGiris;
  }
}