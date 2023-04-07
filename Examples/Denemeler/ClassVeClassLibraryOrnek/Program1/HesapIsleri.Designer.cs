namespace Program1
{
  partial class HesapIsleri
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
      this.txtSayi1 = new System.Windows.Forms.TextBox();
      this.txtSayi2 = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.radioButtonTopla = new System.Windows.Forms.RadioButton();
      this.radioButtonCikar = new System.Windows.Forms.RadioButton();
      this.radioButtonBol = new System.Windows.Forms.RadioButton();
      this.radioButtonCarp = new System.Windows.Forms.RadioButton();
      this.buttonIslem1 = new System.Windows.Forms.Button();
      this.buttonIslem2 = new System.Windows.Forms.Button();
      this.buttonIslem3 = new System.Windows.Forms.Button();
      this.buttonIslem4 = new System.Windows.Forms.Button();
      this.label4 = new System.Windows.Forms.Label();
      this.lblSonuc = new System.Windows.Forms.Label();
      this.panelIslemSec = new System.Windows.Forms.Panel();
      this.buttonIslem3m = new System.Windows.Forms.Button();
      this.panelIslemSec.SuspendLayout();
      this.SuspendLayout();
      // 
      // txtSayi1
      // 
      this.txtSayi1.Location = new System.Drawing.Point(34, 36);
      this.txtSayi1.Name = "txtSayi1";
      this.txtSayi1.Size = new System.Drawing.Size(100, 23);
      this.txtSayi1.TabIndex = 0;
      // 
      // txtSayi2
      // 
      this.txtSayi2.Location = new System.Drawing.Point(34, 80);
      this.txtSayi2.Name = "txtSayi2";
      this.txtSayi2.Size = new System.Drawing.Size(100, 23);
      this.txtSayi2.TabIndex = 1;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(34, 18);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(37, 15);
      this.label1.TabIndex = 2;
      this.label1.Text = "Sayı 1";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(34, 62);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(37, 15);
      this.label2.TabIndex = 3;
      this.label2.Text = "Sayı 2";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(34, 111);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(35, 15);
      this.label3.TabIndex = 5;
      this.label3.Text = "İşlem";
      // 
      // radioButtonTopla
      // 
      this.radioButtonTopla.AutoSize = true;
      this.radioButtonTopla.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.radioButtonTopla.Location = new System.Drawing.Point(3, 3);
      this.radioButtonTopla.Name = "radioButtonTopla";
      this.radioButtonTopla.Size = new System.Drawing.Size(70, 25);
      this.radioButtonTopla.TabIndex = 6;
      this.radioButtonTopla.TabStop = true;
      this.radioButtonTopla.Tag = "+";
      this.radioButtonTopla.Text = "Topla";
      this.radioButtonTopla.UseVisualStyleBackColor = true;
      // 
      // radioButtonCikar
      // 
      this.radioButtonCikar.AutoSize = true;
      this.radioButtonCikar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.radioButtonCikar.Location = new System.Drawing.Point(3, 34);
      this.radioButtonCikar.Name = "radioButtonCikar";
      this.radioButtonCikar.Size = new System.Drawing.Size(67, 25);
      this.radioButtonCikar.TabIndex = 7;
      this.radioButtonCikar.TabStop = true;
      this.radioButtonCikar.Tag = "-";
      this.radioButtonCikar.Text = "Çıkar";
      this.radioButtonCikar.UseVisualStyleBackColor = true;
      // 
      // radioButtonBol
      // 
      this.radioButtonBol.AutoSize = true;
      this.radioButtonBol.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.radioButtonBol.Location = new System.Drawing.Point(5, 96);
      this.radioButtonBol.Name = "radioButtonBol";
      this.radioButtonBol.Size = new System.Drawing.Size(53, 25);
      this.radioButtonBol.TabIndex = 9;
      this.radioButtonBol.TabStop = true;
      this.radioButtonBol.Tag = "/";
      this.radioButtonBol.Text = "Böl";
      this.radioButtonBol.UseVisualStyleBackColor = true;
      // 
      // radioButtonCarp
      // 
      this.radioButtonCarp.AutoSize = true;
      this.radioButtonCarp.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.radioButtonCarp.Location = new System.Drawing.Point(5, 65);
      this.radioButtonCarp.Name = "radioButtonCarp";
      this.radioButtonCarp.Size = new System.Drawing.Size(63, 25);
      this.radioButtonCarp.TabIndex = 8;
      this.radioButtonCarp.TabStop = true;
      this.radioButtonCarp.Tag = "*";
      this.radioButtonCarp.Text = "Çarp";
      this.radioButtonCarp.UseVisualStyleBackColor = true;
      // 
      // buttonIslem1
      // 
      this.buttonIslem1.Location = new System.Drawing.Point(156, 35);
      this.buttonIslem1.Name = "buttonIslem1";
      this.buttonIslem1.Size = new System.Drawing.Size(211, 23);
      this.buttonIslem1.TabIndex = 10;
      this.buttonIslem1.Text = "Button Click ile işlem";
      this.buttonIslem1.UseVisualStyleBackColor = true;
      this.buttonIslem1.Click += new System.EventHandler(this.buttonIslem1_Click);
      // 
      // buttonIslem2
      // 
      this.buttonIslem2.Location = new System.Drawing.Point(156, 64);
      this.buttonIslem2.Name = "buttonIslem2";
      this.buttonIslem2.Size = new System.Drawing.Size(211, 23);
      this.buttonIslem2.TabIndex = 11;
      this.buttonIslem2.Text = "Metot kullanımı ile işlem";
      this.buttonIslem2.UseVisualStyleBackColor = true;
      this.buttonIslem2.Click += new System.EventHandler(this.buttonIslem2_Click);
      // 
      // buttonIslem3
      // 
      this.buttonIslem3.Location = new System.Drawing.Point(156, 93);
      this.buttonIslem3.Name = "buttonIslem3";
      this.buttonIslem3.Size = new System.Drawing.Size(211, 23);
      this.buttonIslem3.TabIndex = 12;
      this.buttonIslem3.Text = "Class Property ile işlem";
      this.buttonIslem3.UseVisualStyleBackColor = true;
      this.buttonIslem3.Click += new System.EventHandler(this.buttonIslem3_Click);
      // 
      // buttonIslem4
      // 
      this.buttonIslem4.Location = new System.Drawing.Point(156, 151);
      this.buttonIslem4.Name = "buttonIslem4";
      this.buttonIslem4.Size = new System.Drawing.Size(211, 23);
      this.buttonIslem4.TabIndex = 13;
      this.buttonIslem4.Text = "Class Library ile işlem";
      this.buttonIslem4.UseVisualStyleBackColor = true;
      this.buttonIslem4.Click += new System.EventHandler(this.buttonIslem4_Click);
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(174, 194);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(40, 15);
      this.label4.TabIndex = 14;
      this.label4.Text = "Sonuç";
      // 
      // lblSonuc
      // 
      this.lblSonuc.AutoSize = true;
      this.lblSonuc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.lblSonuc.ForeColor = System.Drawing.Color.IndianRed;
      this.lblSonuc.Location = new System.Drawing.Point(189, 221);
      this.lblSonuc.Name = "lblSonuc";
      this.lblSonuc.Size = new System.Drawing.Size(19, 21);
      this.lblSonuc.TabIndex = 15;
      this.lblSonuc.Text = "0";
      // 
      // panelIslemSec
      // 
      this.panelIslemSec.BackColor = System.Drawing.SystemColors.ControlLight;
      this.panelIslemSec.Controls.Add(this.radioButtonTopla);
      this.panelIslemSec.Controls.Add(this.radioButtonCikar);
      this.panelIslemSec.Controls.Add(this.radioButtonCarp);
      this.panelIslemSec.Controls.Add(this.radioButtonBol);
      this.panelIslemSec.Location = new System.Drawing.Point(34, 129);
      this.panelIslemSec.Name = "panelIslemSec";
      this.panelIslemSec.Size = new System.Drawing.Size(102, 128);
      this.panelIslemSec.TabIndex = 16;
      // 
      // buttonIslem3m
      // 
      this.buttonIslem3m.Location = new System.Drawing.Point(156, 122);
      this.buttonIslem3m.Name = "buttonIslem3m";
      this.buttonIslem3m.Size = new System.Drawing.Size(211, 23);
      this.buttonIslem3m.TabIndex = 17;
      this.buttonIslem3m.Text = "Class Method ile işlem";
      this.buttonIslem3m.UseVisualStyleBackColor = true;
      this.buttonIslem3m.Click += new System.EventHandler(this.buttonIslem3m_Click);
      // 
      // HesapIsleri
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(732, 495);
      this.Controls.Add(this.buttonIslem3m);
      this.Controls.Add(this.panelIslemSec);
      this.Controls.Add(this.lblSonuc);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.buttonIslem4);
      this.Controls.Add(this.buttonIslem3);
      this.Controls.Add(this.buttonIslem2);
      this.Controls.Add(this.buttonIslem1);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.txtSayi2);
      this.Controls.Add(this.txtSayi1);
      this.Name = "HesapIsleri";
      this.Text = "Program 1 - HesapIsleri";
      this.Load += new System.EventHandler(this.HesapIsleri_Load);
      this.panelIslemSec.ResumeLayout(false);
      this.panelIslemSec.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private TextBox txtSayi1;
    private TextBox txtSayi2;
    private Label label1;
    private Label label2;
    private Label label3;
    private RadioButton radioButtonTopla;
    private RadioButton radioButtonCikar;
    private RadioButton radioButtonBol;
    private RadioButton radioButtonCarp;
    private Button buttonIslem1;
    private Button buttonIslem2;
    private Button buttonIslem3;
    private Button buttonIslem4;
    private Label label4;
    private Label lblSonuc;
    private Panel panelIslemSec;
    private Button buttonIslem3m;
  }
}