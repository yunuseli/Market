﻿namespace Market.Test.Uygulamalar
{
  partial class WebbServiceTcKimlik
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
      this.btnTC = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // btnTC
      // 
      this.btnTC.Location = new System.Drawing.Point(12, 12);
      this.btnTC.Name = "btnTC";
      this.btnTC.Size = new System.Drawing.Size(157, 23);
      this.btnTC.TabIndex = 1;
      this.btnTC.Text = "TC Kimlik Doğrula";
      this.btnTC.UseVisualStyleBackColor = true;
      this.btnTC.Click += new System.EventHandler(this.btnTC_Click);
      // 
      // WebbServiceTcKimlik
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.btnTC);
      this.Name = "WebbServiceTcKimlik";
      this.Text = "WebbServiceTcKimlik";
      this.Load += new System.EventHandler(this.WebbServiceTcKimlik_Load);
      this.ResumeLayout(false);

    }

    #endregion
    private Button btnTC;
  }
}