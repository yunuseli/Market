namespace Ornekler.Projeler.DigerOrnekler
{
  partial class RenkSecimi
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
      this.btnPa = new System.Windows.Forms.Button();
      this.btnYO = new System.Windows.Forms.Button();
      this.lblEtiket = new System.Windows.Forms.Label();
      this.btnYa = new System.Windows.Forms.Button();
      this.panel1 = new System.Windows.Forms.Panel();
      this.lblYO = new System.Windows.Forms.Label();
      this.lblYA = new System.Windows.Forms.Label();
      this.lblPA = new System.Windows.Forms.Label();
      this.pnlRenkTest = new System.Windows.Forms.Panel();
      this.colorDialog1 = new System.Windows.Forms.ColorDialog();
      this.panel1.SuspendLayout();
      this.pnlRenkTest.SuspendLayout();
      this.SuspendLayout();
      // 
      // btnPa
      // 
      this.btnPa.Location = new System.Drawing.Point(14, 16);
      this.btnPa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.btnPa.Name = "btnPa";
      this.btnPa.Size = new System.Drawing.Size(207, 31);
      this.btnPa.TabIndex = 0;
      this.btnPa.Text = "Panel arkaplan rengini seç";
      this.btnPa.UseVisualStyleBackColor = true;
      this.btnPa.Click += new System.EventHandler(this.btnPa_Click);
      // 
      // btnYO
      // 
      this.btnYO.Location = new System.Drawing.Point(14, 93);
      this.btnYO.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.btnYO.Name = "btnYO";
      this.btnYO.Size = new System.Drawing.Size(207, 31);
      this.btnYO.TabIndex = 1;
      this.btnYO.Text = "Yazı rengini seç";
      this.btnYO.UseVisualStyleBackColor = true;
      this.btnYO.Click += new System.EventHandler(this.btnYO_Click);
      // 
      // lblEtiket
      // 
      this.lblEtiket.AutoSize = true;
      this.lblEtiket.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.lblEtiket.Location = new System.Drawing.Point(58, 92);
      this.lblEtiket.Name = "lblEtiket";
      this.lblEtiket.Size = new System.Drawing.Size(360, 70);
      this.lblEtiket.TabIndex = 2;
      this.lblEtiket.Text = "0123456789";
      // 
      // btnYa
      // 
      this.btnYa.Location = new System.Drawing.Point(14, 55);
      this.btnYa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.btnYa.Name = "btnYa";
      this.btnYa.Size = new System.Drawing.Size(207, 31);
      this.btnYa.TabIndex = 3;
      this.btnYa.Text = "Yazı arkaplan rengini seç";
      this.btnYa.UseVisualStyleBackColor = true;
      this.btnYa.Click += new System.EventHandler(this.btnYa_Click);
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.lblYO);
      this.panel1.Controls.Add(this.lblYA);
      this.panel1.Controls.Add(this.lblPA);
      this.panel1.Controls.Add(this.btnYO);
      this.panel1.Controls.Add(this.btnYa);
      this.panel1.Controls.Add(this.btnPa);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel1.Location = new System.Drawing.Point(0, 0);
      this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(481, 133);
      this.panel1.TabIndex = 4;
      // 
      // lblYO
      // 
      this.lblYO.AutoSize = true;
      this.lblYO.Location = new System.Drawing.Point(227, 99);
      this.lblYO.Name = "lblYO";
      this.lblYO.Size = new System.Drawing.Size(50, 20);
      this.lblYO.TabIndex = 6;
      this.lblYO.Text = "label3";
      // 
      // lblYA
      // 
      this.lblYA.AutoSize = true;
      this.lblYA.Location = new System.Drawing.Point(227, 60);
      this.lblYA.Name = "lblYA";
      this.lblYA.Size = new System.Drawing.Size(50, 20);
      this.lblYA.TabIndex = 5;
      this.lblYA.Text = "label2";
      // 
      // lblPA
      // 
      this.lblPA.AutoSize = true;
      this.lblPA.Location = new System.Drawing.Point(227, 21);
      this.lblPA.Name = "lblPA";
      this.lblPA.Size = new System.Drawing.Size(50, 20);
      this.lblPA.TabIndex = 4;
      this.lblPA.Text = "label1";
      // 
      // pnlRenkTest
      // 
      this.pnlRenkTest.Controls.Add(this.lblEtiket);
      this.pnlRenkTest.Dock = System.Windows.Forms.DockStyle.Fill;
      this.pnlRenkTest.Location = new System.Drawing.Point(0, 133);
      this.pnlRenkTest.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.pnlRenkTest.Name = "pnlRenkTest";
      this.pnlRenkTest.Size = new System.Drawing.Size(481, 276);
      this.pnlRenkTest.TabIndex = 5;
      // 
      // RenkSecimi
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(481, 409);
      this.Controls.Add(this.pnlRenkTest);
      this.Controls.Add(this.panel1);
      this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.Name = "RenkSecimi";
      this.Text = "RenkSecimi";
      this.Load += new System.EventHandler(this.RenkSecimi_Load);
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.pnlRenkTest.ResumeLayout(false);
      this.pnlRenkTest.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private Button btnPa;
    private Button btnYO;
    private Label lblEtiket;
    private Button btnYa;
    private Panel panel1;
    private Label lblYO;
    private Label lblYA;
    private Label lblPA;
    private Panel pnlRenkTest;
    private ColorDialog colorDialog1;
  }
}