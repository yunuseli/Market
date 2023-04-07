namespace IlkProje
{
  partial class Form1
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
      this.btnMesaj = new System.Windows.Forms.Button();
      this.txtMesaj = new System.Windows.Forms.TextBox();
      this.txtSayi2 = new System.Windows.Forms.TextBox();
      this.txtSayi1 = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.btnTopla = new System.Windows.Forms.Button();
      this.txtSonuc = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.btnCikart = new System.Windows.Forms.Button();
      this.btnCarp = new System.Windows.Forms.Button();
      this.btnBol = new System.Windows.Forms.Button();
      this.txtOperator = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.btnHesapla = new System.Windows.Forms.Button();
      this.btnMetotTest = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // btnMesaj
      // 
      this.btnMesaj.BackColor = System.Drawing.Color.PeachPuff;
      this.btnMesaj.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.btnMesaj.Location = new System.Drawing.Point(589, 396);
      this.btnMesaj.Name = "btnMesaj";
      this.btnMesaj.Size = new System.Drawing.Size(200, 200);
      this.btnMesaj.TabIndex = 0;
      this.btnMesaj.Text = "Mesaj";
      this.btnMesaj.UseVisualStyleBackColor = false;
      this.btnMesaj.Click += new System.EventHandler(this.btnMesaj_Click);
      // 
      // txtMesaj
      // 
      this.txtMesaj.Location = new System.Drawing.Point(589, 363);
      this.txtMesaj.Name = "txtMesaj";
      this.txtMesaj.Size = new System.Drawing.Size(200, 27);
      this.txtMesaj.TabIndex = 1;
      // 
      // txtSayi2
      // 
      this.txtSayi2.Location = new System.Drawing.Point(249, 66);
      this.txtSayi2.Name = "txtSayi2";
      this.txtSayi2.Size = new System.Drawing.Size(147, 27);
      this.txtSayi2.TabIndex = 2;
      // 
      // txtSayi1
      // 
      this.txtSayi1.Location = new System.Drawing.Point(30, 66);
      this.txtSayi1.Name = "txtSayi1";
      this.txtSayi1.Size = new System.Drawing.Size(147, 27);
      this.txtSayi1.TabIndex = 3;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(30, 33);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(48, 20);
      this.label1.TabIndex = 4;
      this.label1.Text = "Sayı 1";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(249, 33);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(48, 20);
      this.label2.TabIndex = 5;
      this.label2.Text = "Sayı 2";
      // 
      // btnTopla
      // 
      this.btnTopla.Location = new System.Drawing.Point(30, 121);
      this.btnTopla.Name = "btnTopla";
      this.btnTopla.Size = new System.Drawing.Size(87, 53);
      this.btnTopla.TabIndex = 6;
      this.btnTopla.Text = "+";
      this.btnTopla.UseVisualStyleBackColor = true;
      this.btnTopla.Click += new System.EventHandler(this.btnTopla_Click);
      // 
      // txtSonuc
      // 
      this.txtSonuc.Location = new System.Drawing.Point(416, 66);
      this.txtSonuc.Name = "txtSonuc";
      this.txtSonuc.Size = new System.Drawing.Size(147, 27);
      this.txtSonuc.TabIndex = 7;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(416, 33);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(49, 20);
      this.label3.TabIndex = 8;
      this.label3.Text = "Sonuç";
      // 
      // btnCikart
      // 
      this.btnCikart.Location = new System.Drawing.Point(123, 121);
      this.btnCikart.Name = "btnCikart";
      this.btnCikart.Size = new System.Drawing.Size(87, 53);
      this.btnCikart.TabIndex = 9;
      this.btnCikart.Text = "-";
      this.btnCikart.UseVisualStyleBackColor = true;
      this.btnCikart.Click += new System.EventHandler(this.btnCikart_Click);
      // 
      // btnCarp
      // 
      this.btnCarp.Location = new System.Drawing.Point(216, 121);
      this.btnCarp.Name = "btnCarp";
      this.btnCarp.Size = new System.Drawing.Size(87, 53);
      this.btnCarp.TabIndex = 10;
      this.btnCarp.Text = "*";
      this.btnCarp.UseVisualStyleBackColor = true;
      this.btnCarp.Click += new System.EventHandler(this.btnCarp_Click);
      // 
      // btnBol
      // 
      this.btnBol.Location = new System.Drawing.Point(309, 121);
      this.btnBol.Name = "btnBol";
      this.btnBol.Size = new System.Drawing.Size(87, 53);
      this.btnBol.TabIndex = 11;
      this.btnBol.Text = "/";
      this.btnBol.UseVisualStyleBackColor = true;
      this.btnBol.Click += new System.EventHandler(this.btnBol_Click);
      // 
      // txtOperator
      // 
      this.txtOperator.Location = new System.Drawing.Point(190, 66);
      this.txtOperator.Name = "txtOperator";
      this.txtOperator.Size = new System.Drawing.Size(46, 27);
      this.txtOperator.TabIndex = 12;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(188, 33);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(29, 20);
      this.label4.TabIndex = 13;
      this.label4.Text = "Op";
      // 
      // btnHesapla
      // 
      this.btnHesapla.Location = new System.Drawing.Point(416, 121);
      this.btnHesapla.Name = "btnHesapla";
      this.btnHesapla.Size = new System.Drawing.Size(87, 53);
      this.btnHesapla.TabIndex = 14;
      this.btnHesapla.Text = "Hesapla";
      this.btnHesapla.UseVisualStyleBackColor = true;
      this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
      // 
      // btnMetotTest
      // 
      this.btnMetotTest.Location = new System.Drawing.Point(843, 91);
      this.btnMetotTest.Name = "btnMetotTest";
      this.btnMetotTest.Size = new System.Drawing.Size(152, 106);
      this.btnMetotTest.TabIndex = 15;
      this.btnMetotTest.Text = "Metot Test";
      this.btnMetotTest.UseVisualStyleBackColor = true;
      this.btnMetotTest.Click += new System.EventHandler(this.btnMetotTest_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1145, 646);
      this.Controls.Add(this.btnMetotTest);
      this.Controls.Add(this.btnHesapla);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.txtOperator);
      this.Controls.Add(this.btnBol);
      this.Controls.Add(this.btnCarp);
      this.Controls.Add(this.btnCikart);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.txtSonuc);
      this.Controls.Add(this.btnTopla);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.txtSayi1);
      this.Controls.Add(this.txtSayi2);
      this.Controls.Add(this.txtMesaj);
      this.Controls.Add(this.btnMesaj);
      this.Name = "Form1";
      this.Text = "Bizim Form";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private Button btnMesaj;
    private TextBox txtMesaj;
    private TextBox txtSayi2;
    private TextBox txtSayi1;
    private Label label1;
    private Label label2;
    private Button btnTopla;
    private TextBox txtSonuc;
    private Label label3;
    private Button btnCikart;
    private Button btnCarp;
    private Button btnBol;
    private TextBox txtOperator;
    private Label label4;
    private Button btnHesapla;
    private Button btnMetotTest;
  }
}