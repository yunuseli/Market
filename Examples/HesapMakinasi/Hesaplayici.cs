using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HesapMakinasi
{
  public class Hesaplayici : Form
  {
    public Hesaplayici()
    {
      InitializeComponent();
    }


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


    private Button btn3;
    private Button btn2;
    private Button btn1;
    private Button btn4;
    private Button btn5;
    private Button btn6;
    private Button btn7;
    private Button btn8;
    private Button btn9;
    private Button btn0;
    private Button btnComma;
    private Button btnPN;
    private Button btnEqual;
    private Button btnMultiply;
    private Button btnSubtract;
    private Button btnAdd;
    private Button btnDivide;
    private Button btnBackspace;
    private Button btnCE;
    private Button btnC;
    private TextBox txtGiris;
    private Label lblIslem;

    HesapMakinesi hesapMakinesi = new HesapMakinesi();



    private void HesapMak_Load(object sender, EventArgs e)
    {
      this.KeyPreview = true;

      txtGiris.Text = "0";
      txtGiris.TextAlign = HorizontalAlignment.Right;
      txtGiris.Focus();
      txtGiris.Select(txtGiris.Text.Length, 0);

      lblIslem.Text = "";
    }

    private void button_Click(object sender, EventArgs e)
    {
      hesapMakinesi.veriGirisi(((Button)sender).Text);
      txtGiris.Text = hesapMakinesi.girisTextboxDegeri;
      lblIslem.Text = hesapMakinesi.islemLabelDegeri;
      txtGiris.Focus();
      txtGiris.Select(txtGiris.Text.Length, 0);
    }

    private void HesapMak_KeyDown(object sender, KeyEventArgs e)
    {
      // klavyeden basılan tuşu yakalayıp, buton işlemini tetikleme
      switch (e.KeyData)
      {
        case Keys.D0:
          btn0.PerformClick();
          break;
        case Keys.D1:
          btn1.PerformClick();
          break;
        case Keys.D2:
          btn2.PerformClick();
          break;
        case Keys.D3:
          btn3.PerformClick();
          break;
        case Keys.D4:
          btn4.PerformClick();
          break;
        case Keys.D5:
          btn5.PerformClick();
          break;
        case Keys.D6:
          btn6.PerformClick();
          break;
        case Keys.D7:
          btn7.PerformClick();
          break;
        case Keys.D8:
          btn8.PerformClick();
          break;
        case Keys.D9:
          btn9.PerformClick();
          break;

        case Keys.NumPad0:
          btn0.PerformClick();
          break;
        case Keys.NumPad1:
          btn1.PerformClick();
          break;
        case Keys.NumPad2:
          btn2.PerformClick();
          break;
        case Keys.NumPad3:
          btn3.PerformClick();
          break;
        case Keys.NumPad4:
          btn4.PerformClick();
          break;
        case Keys.NumPad5:
          btn5.PerformClick();
          break;
        case Keys.NumPad6:
          btn6.PerformClick();
          break;
        case Keys.NumPad7:
          btn7.PerformClick();
          break;
        case Keys.NumPad8:
          btn8.PerformClick();
          break;
        case Keys.NumPad9:
          btn9.PerformClick();
          break;

        case Keys.Oemcomma:
          btnComma.PerformClick();
          break;
        case Keys.OemPeriod:
          btnComma.PerformClick();
          break;
        case Keys.Decimal:
          btnComma.PerformClick();
          break;

        case Keys.Multiply:
          btnMultiply.PerformClick();
          break;
        case Keys.Add:
          btnAdd.PerformClick();
          break;
        case Keys.Subtract:
          btnSubtract.PerformClick();
          break;
        case Keys.Divide:
          btnDivide.PerformClick();
          break;
        case Keys.OemMinus:
          btnSubtract.PerformClick();
          break;

        default:
          break;
      }

      // klavye tuşunu iptal etme
      e.SuppressKeyPress = true;
    }


    private void InitializeComponent()
    {
      this.btn3 = new System.Windows.Forms.Button();
      this.btn2 = new System.Windows.Forms.Button();
      this.btn1 = new System.Windows.Forms.Button();
      this.btn4 = new System.Windows.Forms.Button();
      this.btn5 = new System.Windows.Forms.Button();
      this.btn6 = new System.Windows.Forms.Button();
      this.btn7 = new System.Windows.Forms.Button();
      this.btn8 = new System.Windows.Forms.Button();
      this.btn9 = new System.Windows.Forms.Button();
      this.btn0 = new System.Windows.Forms.Button();
      this.btnComma = new System.Windows.Forms.Button();
      this.btnPN = new System.Windows.Forms.Button();
      this.btnEqual = new System.Windows.Forms.Button();
      this.btnMultiply = new System.Windows.Forms.Button();
      this.btnSubtract = new System.Windows.Forms.Button();
      this.btnAdd = new System.Windows.Forms.Button();
      this.btnDivide = new System.Windows.Forms.Button();
      this.btnBackspace = new System.Windows.Forms.Button();
      this.btnCE = new System.Windows.Forms.Button();
      this.btnC = new System.Windows.Forms.Button();
      this.txtGiris = new System.Windows.Forms.TextBox();
      this.lblIslem = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // btn3
      // 
      this.btn3.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.btn3.Location = new System.Drawing.Point(172, 305);
      this.btn3.Name = "btn3";
      this.btn3.Size = new System.Drawing.Size(70, 50);
      this.btn3.TabIndex = 0;
      this.btn3.Text = "3";
      this.btn3.UseVisualStyleBackColor = true;
      this.btn3.Click += new System.EventHandler(this.button_Click);
      // 
      // btn2
      // 
      this.btn2.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.btn2.Location = new System.Drawing.Point(96, 305);
      this.btn2.Name = "btn2";
      this.btn2.Size = new System.Drawing.Size(70, 50);
      this.btn2.TabIndex = 1;
      this.btn2.Text = "2";
      this.btn2.UseVisualStyleBackColor = true;
      this.btn2.Click += new System.EventHandler(this.button_Click);
      // 
      // btn1
      // 
      this.btn1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.btn1.Location = new System.Drawing.Point(20, 305);
      this.btn1.Name = "btn1";
      this.btn1.Size = new System.Drawing.Size(70, 50);
      this.btn1.TabIndex = 2;
      this.btn1.Text = "1";
      this.btn1.UseVisualStyleBackColor = true;
      this.btn1.Click += new System.EventHandler(this.button_Click);
      // 
      // btn4
      // 
      this.btn4.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.btn4.Location = new System.Drawing.Point(20, 249);
      this.btn4.Name = "btn4";
      this.btn4.Size = new System.Drawing.Size(70, 50);
      this.btn4.TabIndex = 5;
      this.btn4.Text = "4";
      this.btn4.UseVisualStyleBackColor = true;
      this.btn4.Click += new System.EventHandler(this.button_Click);
      // 
      // btn5
      // 
      this.btn5.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.btn5.Location = new System.Drawing.Point(96, 249);
      this.btn5.Name = "btn5";
      this.btn5.Size = new System.Drawing.Size(70, 50);
      this.btn5.TabIndex = 4;
      this.btn5.Text = "5";
      this.btn5.UseVisualStyleBackColor = true;
      this.btn5.Click += new System.EventHandler(this.button_Click);
      // 
      // btn6
      // 
      this.btn6.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.btn6.Location = new System.Drawing.Point(172, 249);
      this.btn6.Name = "btn6";
      this.btn6.Size = new System.Drawing.Size(70, 50);
      this.btn6.TabIndex = 3;
      this.btn6.Text = "6";
      this.btn6.UseVisualStyleBackColor = true;
      this.btn6.Click += new System.EventHandler(this.button_Click);
      // 
      // btn7
      // 
      this.btn7.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.btn7.Location = new System.Drawing.Point(20, 194);
      this.btn7.Name = "btn7";
      this.btn7.Size = new System.Drawing.Size(70, 50);
      this.btn7.TabIndex = 8;
      this.btn7.Text = "7";
      this.btn7.UseVisualStyleBackColor = true;
      this.btn7.Click += new System.EventHandler(this.button_Click);
      // 
      // btn8
      // 
      this.btn8.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.btn8.Location = new System.Drawing.Point(96, 194);
      this.btn8.Name = "btn8";
      this.btn8.Size = new System.Drawing.Size(70, 50);
      this.btn8.TabIndex = 7;
      this.btn8.Text = "8";
      this.btn8.UseVisualStyleBackColor = true;
      this.btn8.Click += new System.EventHandler(this.button_Click);
      // 
      // btn9
      // 
      this.btn9.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.btn9.Location = new System.Drawing.Point(172, 194);
      this.btn9.Name = "btn9";
      this.btn9.Size = new System.Drawing.Size(70, 50);
      this.btn9.TabIndex = 6;
      this.btn9.Text = "9";
      this.btn9.UseVisualStyleBackColor = true;
      this.btn9.Click += new System.EventHandler(this.button_Click);
      // 
      // btn0
      // 
      this.btn0.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.btn0.Location = new System.Drawing.Point(96, 362);
      this.btn0.Name = "btn0";
      this.btn0.Size = new System.Drawing.Size(70, 50);
      this.btn0.TabIndex = 9;
      this.btn0.Text = "0";
      this.btn0.UseVisualStyleBackColor = true;
      this.btn0.Click += new System.EventHandler(this.button_Click);
      // 
      // btnComma
      // 
      this.btnComma.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.btnComma.Location = new System.Drawing.Point(172, 362);
      this.btnComma.Name = "btnComma";
      this.btnComma.Size = new System.Drawing.Size(70, 50);
      this.btnComma.TabIndex = 10;
      this.btnComma.Text = ",";
      this.btnComma.UseVisualStyleBackColor = true;
      this.btnComma.Click += new System.EventHandler(this.button_Click);
      // 
      // btnPN
      // 
      this.btnPN.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.btnPN.Location = new System.Drawing.Point(20, 362);
      this.btnPN.Name = "btnPN";
      this.btnPN.Size = new System.Drawing.Size(70, 50);
      this.btnPN.TabIndex = 11;
      this.btnPN.Text = "±";
      this.btnPN.UseVisualStyleBackColor = true;
      this.btnPN.Click += new System.EventHandler(this.button_Click);
      // 
      // btnEqual
      // 
      this.btnEqual.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.btnEqual.Location = new System.Drawing.Point(248, 362);
      this.btnEqual.Name = "btnEqual";
      this.btnEqual.Size = new System.Drawing.Size(70, 50);
      this.btnEqual.TabIndex = 15;
      this.btnEqual.Text = "=";
      this.btnEqual.UseVisualStyleBackColor = true;
      this.btnEqual.Click += new System.EventHandler(this.button_Click);
      // 
      // btnMultiply
      // 
      this.btnMultiply.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.btnMultiply.Location = new System.Drawing.Point(248, 194);
      this.btnMultiply.Name = "btnMultiply";
      this.btnMultiply.Size = new System.Drawing.Size(70, 50);
      this.btnMultiply.TabIndex = 14;
      this.btnMultiply.Text = "x";
      this.btnMultiply.UseVisualStyleBackColor = true;
      this.btnMultiply.Click += new System.EventHandler(this.button_Click);
      // 
      // btnSubtract
      // 
      this.btnSubtract.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.btnSubtract.Location = new System.Drawing.Point(248, 249);
      this.btnSubtract.Name = "btnSubtract";
      this.btnSubtract.Size = new System.Drawing.Size(70, 50);
      this.btnSubtract.TabIndex = 13;
      this.btnSubtract.Text = "-";
      this.btnSubtract.UseVisualStyleBackColor = true;
      this.btnSubtract.Click += new System.EventHandler(this.button_Click);
      // 
      // btnAdd
      // 
      this.btnAdd.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.btnAdd.Location = new System.Drawing.Point(248, 305);
      this.btnAdd.Name = "btnAdd";
      this.btnAdd.Size = new System.Drawing.Size(70, 50);
      this.btnAdd.TabIndex = 12;
      this.btnAdd.Text = "+";
      this.btnAdd.UseVisualStyleBackColor = true;
      this.btnAdd.Click += new System.EventHandler(this.button_Click);
      // 
      // btnDivide
      // 
      this.btnDivide.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.btnDivide.Location = new System.Drawing.Point(248, 137);
      this.btnDivide.Name = "btnDivide";
      this.btnDivide.Size = new System.Drawing.Size(70, 50);
      this.btnDivide.TabIndex = 16;
      this.btnDivide.Text = "/";
      this.btnDivide.UseVisualStyleBackColor = true;
      this.btnDivide.Click += new System.EventHandler(this.button_Click);
      // 
      // btnBackspace
      // 
      this.btnBackspace.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.btnBackspace.Location = new System.Drawing.Point(248, 81);
      this.btnBackspace.Name = "btnBackspace";
      this.btnBackspace.Size = new System.Drawing.Size(70, 50);
      this.btnBackspace.TabIndex = 17;
      this.btnBackspace.Text = "«";
      this.btnBackspace.UseVisualStyleBackColor = true;
      this.btnBackspace.Click += new System.EventHandler(this.button_Click);
      // 
      // btnCE
      // 
      this.btnCE.Font = new System.Drawing.Font("Arial", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.btnCE.Location = new System.Drawing.Point(96, 81);
      this.btnCE.Name = "btnCE";
      this.btnCE.Size = new System.Drawing.Size(70, 50);
      this.btnCE.TabIndex = 22;
      this.btnCE.Text = "CE";
      this.btnCE.UseVisualStyleBackColor = true;
      this.btnCE.Click += new System.EventHandler(this.button_Click);
      // 
      // btnC
      // 
      this.btnC.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.btnC.Location = new System.Drawing.Point(172, 81);
      this.btnC.Name = "btnC";
      this.btnC.Size = new System.Drawing.Size(70, 50);
      this.btnC.TabIndex = 21;
      this.btnC.Text = "C";
      this.btnC.UseVisualStyleBackColor = true;
      this.btnC.Click += new System.EventHandler(this.button_Click);
      // 
      // txtGiris
      // 
      this.txtGiris.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.txtGiris.Location = new System.Drawing.Point(20, 44);
      this.txtGiris.Name = "txtGiris";
      this.txtGiris.Size = new System.Drawing.Size(298, 32);
      this.txtGiris.TabIndex = 24;
      // 
      // lblIslem
      // 
      this.lblIslem.Location = new System.Drawing.Point(20, 17);
      this.lblIslem.Name = "lblIslem";
      this.lblIslem.Size = new System.Drawing.Size(298, 23);
      this.lblIslem.TabIndex = 25;
      this.lblIslem.Text = "label1";
      this.lblIslem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // HesapMak
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(331, 423);
      this.Controls.Add(this.lblIslem);
      this.Controls.Add(this.txtGiris);
      this.Controls.Add(this.btnCE);
      this.Controls.Add(this.btnC);
      this.Controls.Add(this.btnBackspace);
      this.Controls.Add(this.btnDivide);
      this.Controls.Add(this.btnEqual);
      this.Controls.Add(this.btnMultiply);
      this.Controls.Add(this.btnSubtract);
      this.Controls.Add(this.btnAdd);
      this.Controls.Add(this.btnPN);
      this.Controls.Add(this.btnComma);
      this.Controls.Add(this.btn0);
      this.Controls.Add(this.btn7);
      this.Controls.Add(this.btn8);
      this.Controls.Add(this.btn9);
      this.Controls.Add(this.btn4);
      this.Controls.Add(this.btn5);
      this.Controls.Add(this.btn6);
      this.Controls.Add(this.btn1);
      this.Controls.Add(this.btn2);
      this.Controls.Add(this.btn3);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
      this.Name = "HesapMak";
      this.Text = "Hesap Makinası";
      this.Load += new System.EventHandler(this.HesapMak_Load);
      this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.HesapMak_KeyDown);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

  }
}
