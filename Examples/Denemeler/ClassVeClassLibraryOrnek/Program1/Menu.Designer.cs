﻿namespace Program1
{
  partial class Menu
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
      this.button1 = new System.Windows.Forms.Button();
      this.button2 = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(41, 35);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(182, 35);
      this.button1.TabIndex = 0;
      this.button1.Text = "Program1 - Hesap İşleri Formu";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // button2
      // 
      this.button2.Location = new System.Drawing.Point(41, 76);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(182, 35);
      this.button2.TabIndex = 1;
      this.button2.Text = "Program2 - İşlemler Formu";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new System.EventHandler(this.button2_Click);
      // 
      // Menu
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(566, 350);
      this.Controls.Add(this.button2);
      this.Controls.Add(this.button1);
      this.Name = "Menu";
      this.Text = "Menu";
      this.Load += new System.EventHandler(this.Menu_Load);
      this.ResumeLayout(false);

    }

    #endregion

    private Button button1;
    private Button button2;
  }
}