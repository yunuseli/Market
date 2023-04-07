namespace IlkProje
{
  partial class AnaEkran
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
      this.label1 = new System.Windows.Forms.Label();
      this.buttonDers1 = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(21, 77);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(155, 45);
      this.label1.TabIndex = 0;
      this.label1.Text = "WinForms ilk ders\r\nArayüz - FormsApp\r\nTextbox ve Button Kullanımı";
      // 
      // buttonDers1
      // 
      this.buttonDers1.Location = new System.Drawing.Point(21, 28);
      this.buttonDers1.Name = "buttonDers1";
      this.buttonDers1.Size = new System.Drawing.Size(155, 34);
      this.buttonDers1.TabIndex = 1;
      this.buttonDers1.Text = "Ders 1";
      this.buttonDers1.UseVisualStyleBackColor = true;
      this.buttonDers1.Click += new System.EventHandler(this.buttonDers1_Click);
      // 
      // AnaEkran
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1003, 537);
      this.Controls.Add(this.buttonDers1);
      this.Controls.Add(this.label1);
      this.Name = "AnaEkran";
      this.Text = "AnaEkran";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private Label label1;
    private Button buttonDers1;
  }
}