namespace Market.Presentation.WinUI.Forms.MarketUserForms
{
  partial class MarketUserImage
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
      this.pbImage = new System.Windows.Forms.PictureBox();
      ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
      this.SuspendLayout();
      // 
      // pbImage
      // 
      this.pbImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.pbImage.Dock = System.Windows.Forms.DockStyle.Fill;
      this.pbImage.Location = new System.Drawing.Point(0, 0);
      this.pbImage.Name = "pbImage";
      this.pbImage.Size = new System.Drawing.Size(247, 281);
      this.pbImage.TabIndex = 102;
      this.pbImage.TabStop = false;
      this.pbImage.MouseLeave += new System.EventHandler(this.pbImage_MouseLeave);
      // 
      // MarketUserImage
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.LightGray;
      this.ClientSize = new System.Drawing.Size(247, 281);
      this.Controls.Add(this.pbImage);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Name = "MarketUserImage";
      this.Text = "Kullanıcı İşlemleri";
      this.Load += new System.EventHandler(this.Form_Load);
      ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion
    private PictureBox pbImage;
  }
}