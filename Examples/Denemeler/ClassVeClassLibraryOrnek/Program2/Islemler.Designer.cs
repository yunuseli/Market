namespace Program2
{
  partial class Islemler
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
      this.panelIslemSec = new System.Windows.Forms.Panel();
      this.radioButtonTopla = new System.Windows.Forms.RadioButton();
      this.radioButtonCikar = new System.Windows.Forms.RadioButton();
      this.radioButtonCarp = new System.Windows.Forms.RadioButton();
      this.radioButtonBol = new System.Windows.Forms.RadioButton();
      this.lblSonuc = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.buttonIslem4 = new System.Windows.Forms.Button();
      this.label3 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.txtSayi2 = new System.Windows.Forms.TextBox();
      this.txtSayi1 = new System.Windows.Forms.TextBox();
      this.buttonTemizle1 = new System.Windows.Forms.Button();
      this.buttonQGetir = new System.Windows.Forms.Button();
      this.buttonQEkle = new System.Windows.Forms.Button();
      this.label5 = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.listBox2 = new System.Windows.Forms.ListBox();
      this.buttonStackGetir = new System.Windows.Forms.Button();
      this.listBox1 = new System.Windows.Forms.ListBox();
      this.textBoxYigin = new System.Windows.Forms.TextBox();
      this.buttonStackEkle = new System.Windows.Forms.Button();
      this.panelIslemSec.SuspendLayout();
      this.SuspendLayout();
      // 
      // panelIslemSec
      // 
      this.panelIslemSec.BackColor = System.Drawing.SystemColors.ControlLight;
      this.panelIslemSec.Controls.Add(this.radioButtonTopla);
      this.panelIslemSec.Controls.Add(this.radioButtonCikar);
      this.panelIslemSec.Controls.Add(this.radioButtonCarp);
      this.panelIslemSec.Controls.Add(this.radioButtonBol);
      this.panelIslemSec.Location = new System.Drawing.Point(12, 123);
      this.panelIslemSec.Name = "panelIslemSec";
      this.panelIslemSec.Size = new System.Drawing.Size(102, 128);
      this.panelIslemSec.TabIndex = 29;
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
      // lblSonuc
      // 
      this.lblSonuc.AutoSize = true;
      this.lblSonuc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.lblSonuc.ForeColor = System.Drawing.Color.IndianRed;
      this.lblSonuc.Location = new System.Drawing.Point(45, 345);
      this.lblSonuc.Name = "lblSonuc";
      this.lblSonuc.Size = new System.Drawing.Size(19, 21);
      this.lblSonuc.TabIndex = 28;
      this.lblSonuc.Text = "0";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(30, 318);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(40, 15);
      this.label4.TabIndex = 27;
      this.label4.Text = "Sonuç";
      // 
      // buttonIslem4
      // 
      this.buttonIslem4.Location = new System.Drawing.Point(12, 273);
      this.buttonIslem4.Name = "buttonIslem4";
      this.buttonIslem4.Size = new System.Drawing.Size(211, 23);
      this.buttonIslem4.TabIndex = 26;
      this.buttonIslem4.Text = "Class Library ile işlem";
      this.buttonIslem4.UseVisualStyleBackColor = true;
      this.buttonIslem4.Click += new System.EventHandler(this.buttonIslem4_Click);
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(12, 105);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(35, 15);
      this.label3.TabIndex = 22;
      this.label3.Text = "İşlem";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(12, 56);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(37, 15);
      this.label2.TabIndex = 21;
      this.label2.Text = "Sayı 2";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 12);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(37, 15);
      this.label1.TabIndex = 20;
      this.label1.Text = "Sayı 1";
      // 
      // txtSayi2
      // 
      this.txtSayi2.Location = new System.Drawing.Point(12, 74);
      this.txtSayi2.Name = "txtSayi2";
      this.txtSayi2.Size = new System.Drawing.Size(100, 23);
      this.txtSayi2.TabIndex = 19;
      // 
      // txtSayi1
      // 
      this.txtSayi1.Location = new System.Drawing.Point(12, 30);
      this.txtSayi1.Name = "txtSayi1";
      this.txtSayi1.Size = new System.Drawing.Size(100, 23);
      this.txtSayi1.TabIndex = 18;
      // 
      // buttonTemizle1
      // 
      this.buttonTemizle1.Location = new System.Drawing.Point(449, 355);
      this.buttonTemizle1.Name = "buttonTemizle1";
      this.buttonTemizle1.Size = new System.Drawing.Size(96, 23);
      this.buttonTemizle1.TabIndex = 39;
      this.buttonTemizle1.Text = "Temizle";
      this.buttonTemizle1.UseVisualStyleBackColor = true;
      this.buttonTemizle1.Click += new System.EventHandler(this.buttonTemizle1_Click);
      // 
      // buttonQGetir
      // 
      this.buttonQGetir.Location = new System.Drawing.Point(301, 185);
      this.buttonQGetir.Name = "buttonQGetir";
      this.buttonQGetir.Size = new System.Drawing.Size(96, 23);
      this.buttonQGetir.TabIndex = 38;
      this.buttonQGetir.Text = "Queue Getir";
      this.buttonQGetir.UseVisualStyleBackColor = true;
      this.buttonQGetir.Click += new System.EventHandler(this.buttonQGetir_Click);
      // 
      // buttonQEkle
      // 
      this.buttonQEkle.Location = new System.Drawing.Point(301, 156);
      this.buttonQEkle.Name = "buttonQEkle";
      this.buttonQEkle.Size = new System.Drawing.Size(96, 23);
      this.buttonQEkle.TabIndex = 37;
      this.buttonQEkle.Text = "Queue Ekle";
      this.buttonQEkle.UseVisualStyleBackColor = true;
      this.buttonQEkle.Click += new System.EventHandler(this.buttonQEkle_Click);
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(652, 27);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(28, 15);
      this.label5.TabIndex = 36;
      this.label5.Text = "liste";
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(449, 27);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(35, 15);
      this.label6.TabIndex = 35;
      this.label6.Text = "işlem";
      // 
      // listBox2
      // 
      this.listBox2.FormattingEnabled = true;
      this.listBox2.ItemHeight = 15;
      this.listBox2.Location = new System.Drawing.Point(652, 45);
      this.listBox2.Name = "listBox2";
      this.listBox2.Size = new System.Drawing.Size(197, 304);
      this.listBox2.TabIndex = 34;
      // 
      // buttonStackGetir
      // 
      this.buttonStackGetir.Location = new System.Drawing.Point(301, 106);
      this.buttonStackGetir.Name = "buttonStackGetir";
      this.buttonStackGetir.Size = new System.Drawing.Size(96, 23);
      this.buttonStackGetir.TabIndex = 33;
      this.buttonStackGetir.Text = "Stack Getir";
      this.buttonStackGetir.UseVisualStyleBackColor = true;
      this.buttonStackGetir.Click += new System.EventHandler(this.buttonStackGetir_Click);
      // 
      // listBox1
      // 
      this.listBox1.FormattingEnabled = true;
      this.listBox1.ItemHeight = 15;
      this.listBox1.Location = new System.Drawing.Point(449, 45);
      this.listBox1.Name = "listBox1";
      this.listBox1.Size = new System.Drawing.Size(197, 304);
      this.listBox1.TabIndex = 32;
      // 
      // textBoxYigin
      // 
      this.textBoxYigin.Location = new System.Drawing.Point(301, 45);
      this.textBoxYigin.Name = "textBoxYigin";
      this.textBoxYigin.Size = new System.Drawing.Size(142, 23);
      this.textBoxYigin.TabIndex = 31;
      // 
      // buttonStackEkle
      // 
      this.buttonStackEkle.Location = new System.Drawing.Point(301, 77);
      this.buttonStackEkle.Name = "buttonStackEkle";
      this.buttonStackEkle.Size = new System.Drawing.Size(96, 23);
      this.buttonStackEkle.TabIndex = 30;
      this.buttonStackEkle.Text = "Stack Ekle";
      this.buttonStackEkle.UseVisualStyleBackColor = true;
      this.buttonStackEkle.Click += new System.EventHandler(this.buttonStackEkle_Click);
      // 
      // Islemler
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(882, 402);
      this.Controls.Add(this.buttonTemizle1);
      this.Controls.Add(this.buttonQGetir);
      this.Controls.Add(this.buttonQEkle);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.listBox2);
      this.Controls.Add(this.buttonStackGetir);
      this.Controls.Add(this.listBox1);
      this.Controls.Add(this.textBoxYigin);
      this.Controls.Add(this.buttonStackEkle);
      this.Controls.Add(this.panelIslemSec);
      this.Controls.Add(this.lblSonuc);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.buttonIslem4);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.txtSayi2);
      this.Controls.Add(this.txtSayi1);
      this.Name = "Islemler";
      this.Text = "Program 2 - Islemler";
      this.Load += new System.EventHandler(this.Islemler_Load);
      this.panelIslemSec.ResumeLayout(false);
      this.panelIslemSec.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private Panel panelIslemSec;
    private RadioButton radioButtonTopla;
    private RadioButton radioButtonCikar;
    private RadioButton radioButtonCarp;
    private RadioButton radioButtonBol;
    private Label lblSonuc;
    private Label label4;
    private Button buttonIslem4;
    private Label label3;
    private Label label2;
    private Label label1;
    private TextBox txtSayi2;
    private TextBox txtSayi1;
    private Button buttonTemizle1;
    private Button buttonQGetir;
    private Button buttonQEkle;
    private Label label5;
    private Label label6;
    private ListBox listBox2;
    private Button buttonStackGetir;
    private ListBox listBox1;
    private TextBox textBoxYigin;
    private Button buttonStackEkle;
  }
}