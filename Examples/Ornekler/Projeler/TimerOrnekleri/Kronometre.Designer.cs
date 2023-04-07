namespace Ornekler.Projeler.TimerOrnekleri
{
  partial class Kronometre
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
      this.lblDakika = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.lblSaniye = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.lblSalise = new System.Windows.Forms.Label();
      this.tmrKronometre = new System.Windows.Forms.Timer(this.components);
      this.btnBaslat = new System.Windows.Forms.Button();
      this.btnDurdur = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // lblDakika
      // 
      this.lblDakika.AutoSize = true;
      this.lblDakika.Font = new System.Drawing.Font("Segoe UI", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.lblDakika.Location = new System.Drawing.Point(2, 12);
      this.lblDakika.Name = "lblDakika";
      this.lblDakika.Size = new System.Drawing.Size(197, 159);
      this.lblDakika.TabIndex = 0;
      this.lblDakika.Text = "00";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Segoe UI", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.label2.Location = new System.Drawing.Point(157, 3);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(93, 159);
      this.label2.TabIndex = 1;
      this.label2.Text = ":";
      // 
      // lblSaniye
      // 
      this.lblSaniye.AutoSize = true;
      this.lblSaniye.Font = new System.Drawing.Font("Segoe UI", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.lblSaniye.Location = new System.Drawing.Point(219, 12);
      this.lblSaniye.Name = "lblSaniye";
      this.lblSaniye.Size = new System.Drawing.Size(197, 159);
      this.lblSaniye.TabIndex = 2;
      this.lblSaniye.Text = "00";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font("Segoe UI", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.label4.Location = new System.Drawing.Point(374, 3);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(93, 159);
      this.label4.TabIndex = 3;
      this.label4.Text = ":";
      // 
      // lblSalise
      // 
      this.lblSalise.AutoSize = true;
      this.lblSalise.Font = new System.Drawing.Font("Segoe UI", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.lblSalise.Location = new System.Drawing.Point(437, 12);
      this.lblSalise.Name = "lblSalise";
      this.lblSalise.Size = new System.Drawing.Size(197, 159);
      this.lblSalise.TabIndex = 4;
      this.lblSalise.Text = "00";
      // 
      // tmrKronometre
      // 
      this.tmrKronometre.Interval = 10;
      this.tmrKronometre.Tick += new System.EventHandler(this.tmrKronometre_Tick);
      // 
      // btnBaslat
      // 
      this.btnBaslat.Location = new System.Drawing.Point(219, 175);
      this.btnBaslat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.btnBaslat.Name = "btnBaslat";
      this.btnBaslat.Size = new System.Drawing.Size(112, 72);
      this.btnBaslat.TabIndex = 5;
      this.btnBaslat.Text = "Başlat";
      this.btnBaslat.UseVisualStyleBackColor = true;
      this.btnBaslat.Click += new System.EventHandler(this.btnBaslat_Click);
      // 
      // btnDurdur
      // 
      this.btnDurdur.Location = new System.Drawing.Point(338, 175);
      this.btnDurdur.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.btnDurdur.Name = "btnDurdur";
      this.btnDurdur.Size = new System.Drawing.Size(117, 72);
      this.btnDurdur.TabIndex = 6;
      this.btnDurdur.Text = "Durdur";
      this.btnDurdur.UseVisualStyleBackColor = true;
      this.btnDurdur.Click += new System.EventHandler(this.btnDurdur_Click);
      // 
      // Kronometre
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.SystemColors.Control;
      this.ClientSize = new System.Drawing.Size(640, 277);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.btnDurdur);
      this.Controls.Add(this.btnBaslat);
      this.Controls.Add(this.lblSalise);
      this.Controls.Add(this.lblSaniye);
      this.Controls.Add(this.lblDakika);
      this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.Name = "Kronometre";
      this.Text = "Kronometre";
      this.Load += new System.EventHandler(this.Kronometre_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private Label lblDakika;
    private Label label2;
    private Label lblSaniye;
    private Label label4;
    private Label lblSalise;
    private System.Windows.Forms.Timer tmrKronometre;
    private Button btnBaslat;
    private Button btnDurdur;
  }
}