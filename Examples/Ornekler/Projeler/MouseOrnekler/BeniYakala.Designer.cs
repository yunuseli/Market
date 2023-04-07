namespace Ornekler.Projeler.MouseOrnekler
{
  partial class BeniYakala
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
      this.btnYakala = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // btnYakala
      // 
      this.btnYakala.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.btnYakala.Location = new System.Drawing.Point(2, 4);
      this.btnYakala.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.btnYakala.Name = "btnYakala";
      this.btnYakala.Size = new System.Drawing.Size(75, 60);
      this.btnYakala.TabIndex = 0;
      this.btnYakala.Text = "Beni\r\nYakala";
      this.btnYakala.UseVisualStyleBackColor = true;
      this.btnYakala.Click += new System.EventHandler(this.btnYakala_Click);
      this.btnYakala.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnYakala_MouseClick);
      this.btnYakala.MouseEnter += new System.EventHandler(this.btnYakala_MouseEnter);
      this.btnYakala.MouseHover += new System.EventHandler(this.btnYakala_MouseHover);
      // 
      // BeniYakala
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(259, 169);
      this.Controls.Add(this.btnYakala);
      this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.Name = "BeniYakala";
      this.Text = "Beni Yakala";
      this.Load += new System.EventHandler(this.BeniYakala_Load);
      this.SizeChanged += new System.EventHandler(this.BeniYakala_SizeChanged);
      this.ResumeLayout(false);

    }

    #endregion

    private Button btnYakala;
  }
}