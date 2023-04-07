namespace Market.Otomasyon
{
  partial class SeriPort
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
      this.btnOku = new System.Windows.Forms.Button();
      this.btnYaz = new System.Windows.Forms.Button();
      this.btnBaglan = new System.Windows.Forms.Button();
      this.txtComPort = new System.Windows.Forms.TextBox();
      this.pbComPort = new System.Windows.Forms.PictureBox();
      this.timerSorgula = new System.Windows.Forms.Timer(this.components);
      this.cbOku = new System.Windows.Forms.CheckBox();
      this.label1 = new System.Windows.Forms.Label();
      this.pbG1 = new System.Windows.Forms.PictureBox();
      this.pbG2 = new System.Windows.Forms.PictureBox();
      this.pbG3 = new System.Windows.Forms.PictureBox();
      this.pbG4 = new System.Windows.Forms.PictureBox();
      this.label2 = new System.Windows.Forms.Label();
      this.pbC4 = new System.Windows.Forms.PictureBox();
      this.pbC3 = new System.Windows.Forms.PictureBox();
      this.pbC2 = new System.Windows.Forms.PictureBox();
      this.pbC1 = new System.Windows.Forms.PictureBox();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.txtData = new System.Windows.Forms.TextBox();
      this.richTextBox1 = new System.Windows.Forms.RichTextBox();
      this.txtDosya = new System.Windows.Forms.RichTextBox();
      this.btnDosyaOku = new System.Windows.Forms.Button();
      this.btnDosyaLed = new System.Windows.Forms.Button();
      this.btnDosyaKayit = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.pbComPort)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pbG1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pbG2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pbG3)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pbG4)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pbC4)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pbC3)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pbC2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pbC1)).BeginInit();
      this.SuspendLayout();
      // 
      // btnOku
      // 
      this.btnOku.Location = new System.Drawing.Point(42, 180);
      this.btnOku.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.btnOku.Name = "btnOku";
      this.btnOku.Size = new System.Drawing.Size(98, 31);
      this.btnOku.TabIndex = 0;
      this.btnOku.Text = "Oku";
      this.btnOku.UseVisualStyleBackColor = true;
      this.btnOku.Click += new System.EventHandler(this.btnOku_Click);
      // 
      // btnYaz
      // 
      this.btnYaz.Location = new System.Drawing.Point(27, 372);
      this.btnYaz.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.btnYaz.Name = "btnYaz";
      this.btnYaz.Size = new System.Drawing.Size(86, 31);
      this.btnYaz.TabIndex = 1;
      this.btnYaz.Text = "Yaz";
      this.btnYaz.UseVisualStyleBackColor = true;
      this.btnYaz.Click += new System.EventHandler(this.btnYaz_Click);
      // 
      // btnBaglan
      // 
      this.btnBaglan.Location = new System.Drawing.Point(42, 69);
      this.btnBaglan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.btnBaglan.Name = "btnBaglan";
      this.btnBaglan.Size = new System.Drawing.Size(86, 31);
      this.btnBaglan.TabIndex = 2;
      this.btnBaglan.Text = "Bağlan";
      this.btnBaglan.UseVisualStyleBackColor = true;
      this.btnBaglan.Click += new System.EventHandler(this.btnBaglan_Click);
      // 
      // txtComPort
      // 
      this.txtComPort.Location = new System.Drawing.Point(42, 31);
      this.txtComPort.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.txtComPort.Name = "txtComPort";
      this.txtComPort.Size = new System.Drawing.Size(85, 27);
      this.txtComPort.TabIndex = 3;
      this.txtComPort.Text = "COM5";
      // 
      // pbComPort
      // 
      this.pbComPort.Location = new System.Drawing.Point(137, 32);
      this.pbComPort.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.pbComPort.Name = "pbComPort";
      this.pbComPort.Size = new System.Drawing.Size(35, 29);
      this.pbComPort.TabIndex = 4;
      this.pbComPort.TabStop = false;
      // 
      // timerSorgula
      // 
      this.timerSorgula.Interval = 1000;
      this.timerSorgula.Tick += new System.EventHandler(this.timerSorgula_Tick);
      // 
      // cbOku
      // 
      this.cbOku.AutoSize = true;
      this.cbOku.Location = new System.Drawing.Point(42, 147);
      this.cbOku.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.cbOku.Name = "cbOku";
      this.cbOku.Size = new System.Drawing.Size(105, 24);
      this.cbOku.TabIndex = 5;
      this.cbOku.Text = "Sürekli Oku";
      this.cbOku.UseVisualStyleBackColor = true;
      this.cbOku.CheckedChanged += new System.EventHandler(this.cbOku_CheckedChanged);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(257, 152);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(55, 20);
      this.label1.TabIndex = 6;
      this.label1.Text = "Girişler";
      // 
      // pbG1
      // 
      this.pbG1.Location = new System.Drawing.Point(313, 147);
      this.pbG1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.pbG1.Name = "pbG1";
      this.pbG1.Size = new System.Drawing.Size(38, 44);
      this.pbG1.TabIndex = 7;
      this.pbG1.TabStop = false;
      // 
      // pbG2
      // 
      this.pbG2.Location = new System.Drawing.Point(358, 147);
      this.pbG2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.pbG2.Name = "pbG2";
      this.pbG2.Size = new System.Drawing.Size(38, 44);
      this.pbG2.TabIndex = 8;
      this.pbG2.TabStop = false;
      // 
      // pbG3
      // 
      this.pbG3.Location = new System.Drawing.Point(402, 147);
      this.pbG3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.pbG3.Name = "pbG3";
      this.pbG3.Size = new System.Drawing.Size(38, 44);
      this.pbG3.TabIndex = 9;
      this.pbG3.TabStop = false;
      // 
      // pbG4
      // 
      this.pbG4.Location = new System.Drawing.Point(447, 147);
      this.pbG4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.pbG4.Name = "pbG4";
      this.pbG4.Size = new System.Drawing.Size(38, 44);
      this.pbG4.TabIndex = 10;
      this.pbG4.TabStop = false;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(257, 215);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(56, 20);
      this.label2.TabIndex = 11;
      this.label2.Text = "Çıkışlar";
      // 
      // pbC4
      // 
      this.pbC4.Location = new System.Drawing.Point(447, 203);
      this.pbC4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.pbC4.Name = "pbC4";
      this.pbC4.Size = new System.Drawing.Size(38, 44);
      this.pbC4.TabIndex = 15;
      this.pbC4.TabStop = false;
      // 
      // pbC3
      // 
      this.pbC3.Location = new System.Drawing.Point(402, 203);
      this.pbC3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.pbC3.Name = "pbC3";
      this.pbC3.Size = new System.Drawing.Size(38, 44);
      this.pbC3.TabIndex = 14;
      this.pbC3.TabStop = false;
      // 
      // pbC2
      // 
      this.pbC2.Location = new System.Drawing.Point(358, 203);
      this.pbC2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.pbC2.Name = "pbC2";
      this.pbC2.Size = new System.Drawing.Size(38, 44);
      this.pbC2.TabIndex = 13;
      this.pbC2.TabStop = false;
      // 
      // pbC1
      // 
      this.pbC1.Location = new System.Drawing.Point(313, 203);
      this.pbC1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.pbC1.Name = "pbC1";
      this.pbC1.Size = new System.Drawing.Size(38, 44);
      this.pbC1.TabIndex = 12;
      this.pbC1.TabStop = false;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(326, 108);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(17, 20);
      this.label3.TabIndex = 16;
      this.label3.Text = "1";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(369, 108);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(17, 20);
      this.label4.TabIndex = 17;
      this.label4.Text = "2";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(413, 108);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(17, 20);
      this.label5.TabIndex = 18;
      this.label5.Text = "3";
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(457, 108);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(17, 20);
      this.label6.TabIndex = 19;
      this.label6.Text = "4";
      // 
      // txtData
      // 
      this.txtData.Location = new System.Drawing.Point(27, 333);
      this.txtData.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.txtData.Name = "txtData";
      this.txtData.Size = new System.Drawing.Size(130, 27);
      this.txtData.TabIndex = 20;
      // 
      // richTextBox1
      // 
      this.richTextBox1.Location = new System.Drawing.Point(26, 435);
      this.richTextBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.richTextBox1.Name = "richTextBox1";
      this.richTextBox1.Size = new System.Drawing.Size(182, 253);
      this.richTextBox1.TabIndex = 21;
      this.richTextBox1.Text = "Led Örnek : LED1101";
      // 
      // txtDosya
      // 
      this.txtDosya.Location = new System.Drawing.Point(320, 372);
      this.txtDosya.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.txtDosya.Name = "txtDosya";
      this.txtDosya.Size = new System.Drawing.Size(278, 253);
      this.txtDosya.TabIndex = 22;
      this.txtDosya.Text = "";
      // 
      // btnDosyaOku
      // 
      this.btnDosyaOku.Location = new System.Drawing.Point(320, 333);
      this.btnDosyaOku.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.btnDosyaOku.Name = "btnDosyaOku";
      this.btnDosyaOku.Size = new System.Drawing.Size(75, 31);
      this.btnDosyaOku.TabIndex = 23;
      this.btnDosyaOku.Text = "Dosya";
      this.btnDosyaOku.UseVisualStyleBackColor = true;
      this.btnDosyaOku.Click += new System.EventHandler(this.btnDosyaOku_Click);
      // 
      // btnDosyaLed
      // 
      this.btnDosyaLed.Location = new System.Drawing.Point(853, 348);
      this.btnDosyaLed.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.btnDosyaLed.Name = "btnDosyaLed";
      this.btnDosyaLed.Size = new System.Drawing.Size(86, 31);
      this.btnDosyaLed.TabIndex = 24;
      this.btnDosyaLed.Text = "Led İşlem";
      this.btnDosyaLed.UseVisualStyleBackColor = true;
      this.btnDosyaLed.Click += new System.EventHandler(this.btnDosyaLed_Click);
      // 
      // btnDosyaKayit
      // 
      this.btnDosyaKayit.Location = new System.Drawing.Point(402, 333);
      this.btnDosyaKayit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.btnDosyaKayit.Name = "btnDosyaKayit";
      this.btnDosyaKayit.Size = new System.Drawing.Size(75, 31);
      this.btnDosyaKayit.TabIndex = 25;
      this.btnDosyaKayit.Text = "KAydet";
      this.btnDosyaKayit.UseVisualStyleBackColor = true;
      this.btnDosyaKayit.Click += new System.EventHandler(this.btnDosyaKayit_Click);
      // 
      // SeriPort
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(627, 705);
      this.Controls.Add(this.btnDosyaKayit);
      this.Controls.Add(this.btnDosyaLed);
      this.Controls.Add(this.btnDosyaOku);
      this.Controls.Add(this.txtDosya);
      this.Controls.Add(this.richTextBox1);
      this.Controls.Add(this.txtData);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.pbC4);
      this.Controls.Add(this.pbC3);
      this.Controls.Add(this.pbC2);
      this.Controls.Add(this.pbC1);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.pbG4);
      this.Controls.Add(this.pbG3);
      this.Controls.Add(this.pbG2);
      this.Controls.Add(this.pbG1);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.cbOku);
      this.Controls.Add(this.pbComPort);
      this.Controls.Add(this.txtComPort);
      this.Controls.Add(this.btnBaglan);
      this.Controls.Add(this.btnYaz);
      this.Controls.Add(this.btnOku);
      this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.Name = "SeriPort";
      this.Text = "SeriPort";
      this.Load += new System.EventHandler(this.SeriPort_Load);
      ((System.ComponentModel.ISupportInitialize)(this.pbComPort)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pbG1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pbG2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pbG3)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pbG4)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pbC4)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pbC3)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pbC2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pbC1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private Button btnOku;
    private Button btnYaz;
    private Button btnBaglan;
    private TextBox txtComPort;
    private PictureBox pbComPort;
    private System.Windows.Forms.Timer timerSorgula;
    private CheckBox cbOku;
    private Label label1;
    private PictureBox pbG1;
    private PictureBox pbG2;
    private PictureBox pbG3;
    private PictureBox pbG4;
    private Label label2;
    private PictureBox pbC4;
    private PictureBox pbC3;
    private PictureBox pbC2;
    private PictureBox pbC1;
    private Label label3;
    private Label label4;
    private Label label5;
    private Label label6;
    private TextBox txtData;
    private RichTextBox richTextBox1;
    private RichTextBox txtDosya;
    private Button btnDosyaOku;
    private Button btnDosyaLed;
    private Button btnDosyaKayit;
  }
}