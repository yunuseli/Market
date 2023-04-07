namespace Ornekler.Projeler.TimerOrnekleri
{
  partial class KaynarSu
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
      this.timer1 = new System.Windows.Forms.Timer(this.components);
      this.btnDusuk = new System.Windows.Forms.Button();
      this.btnOrta = new System.Windows.Forms.Button();
      this.btnYuksek = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.lblAyar = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.lblKaynama = new System.Windows.Forms.Label();
      this.progressBar1 = new System.Windows.Forms.ProgressBar();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.SuspendLayout();
      // 
      // timer1
      // 
      this.timer1.Interval = 1000;
      this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
      // 
      // btnDusuk
      // 
      this.btnDusuk.Location = new System.Drawing.Point(71, 105);
      this.btnDusuk.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.btnDusuk.Name = "btnDusuk";
      this.btnDusuk.Size = new System.Drawing.Size(82, 22);
      this.btnDusuk.TabIndex = 0;
      this.btnDusuk.Text = "Düşük";
      this.btnDusuk.UseVisualStyleBackColor = true;
      this.btnDusuk.Click += new System.EventHandler(this.btnDusuk_Click);
      // 
      // btnOrta
      // 
      this.btnOrta.Location = new System.Drawing.Point(158, 105);
      this.btnOrta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.btnOrta.Name = "btnOrta";
      this.btnOrta.Size = new System.Drawing.Size(82, 22);
      this.btnOrta.TabIndex = 1;
      this.btnOrta.Text = "Orta";
      this.btnOrta.UseVisualStyleBackColor = true;
      this.btnOrta.Click += new System.EventHandler(this.btnOrta_Click);
      // 
      // btnYuksek
      // 
      this.btnYuksek.Location = new System.Drawing.Point(246, 105);
      this.btnYuksek.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.btnYuksek.Name = "btnYuksek";
      this.btnYuksek.Size = new System.Drawing.Size(82, 22);
      this.btnYuksek.TabIndex = 2;
      this.btnYuksek.Text = "Yüksek";
      this.btnYuksek.UseVisualStyleBackColor = true;
      this.btnYuksek.Click += new System.EventHandler(this.btnYuksek_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(90, 162);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(31, 15);
      this.label1.TabIndex = 3;
      this.label1.Text = "Ayar";
      // 
      // lblAyar
      // 
      this.lblAyar.AutoSize = true;
      this.lblAyar.Location = new System.Drawing.Point(208, 162);
      this.lblAyar.Name = "lblAyar";
      this.lblAyar.Size = new System.Drawing.Size(38, 15);
      this.lblAyar.TabIndex = 4;
      this.lblAyar.Text = "label2";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(90, 185);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(99, 15);
      this.label3.TabIndex = 5;
      this.label3.Text = "Kaynama Noktası";
      // 
      // lblKaynama
      // 
      this.lblKaynama.AutoSize = true;
      this.lblKaynama.Location = new System.Drawing.Point(208, 185);
      this.lblKaynama.Name = "lblKaynama";
      this.lblKaynama.Size = new System.Drawing.Size(38, 15);
      this.lblKaynama.TabIndex = 6;
      this.lblKaynama.Text = "label4";
      // 
      // progressBar1
      // 
      this.progressBar1.Location = new System.Drawing.Point(62, 215);
      this.progressBar1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.progressBar1.Name = "progressBar1";
      this.progressBar1.Size = new System.Drawing.Size(300, 56);
      this.progressBar1.TabIndex = 7;
      // 
      // pictureBox1
      // 
      this.pictureBox1.Location = new System.Drawing.Point(72, 36);
      this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(169, 46);
      this.pictureBox1.TabIndex = 8;
      this.pictureBox1.TabStop = false;
      // 
      // KaynarSu
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(408, 300);
      this.Controls.Add(this.pictureBox1);
      this.Controls.Add(this.progressBar1);
      this.Controls.Add(this.lblKaynama);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.lblAyar);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.btnYuksek);
      this.Controls.Add(this.btnOrta);
      this.Controls.Add(this.btnDusuk);
      this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.Name = "KaynarSu";
      this.Text = "KaynarSu";
      this.Load += new System.EventHandler(this.KaynarSu_Load);
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Timer timer1;
    private Button btnDusuk;
    private Button btnOrta;
    private Button btnYuksek;
    private Label label1;
    private Label lblAyar;
    private Label label3;
    private Label lblKaynama;
    private ProgressBar progressBar1;
    private PictureBox pictureBox1;
  }
}