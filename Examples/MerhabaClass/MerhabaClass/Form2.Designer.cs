namespace MerhabaClass
{
  partial class Form2
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
      this.button4 = new System.Windows.Forms.Button();
      this.textBox2 = new System.Windows.Forms.TextBox();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // button4
      // 
      this.button4.Location = new System.Drawing.Point(412, 211);
      this.button4.Name = "button4";
      this.button4.Size = new System.Drawing.Size(151, 29);
      this.button4.TabIndex = 8;
      this.button4.Text = "Sınıf toplama";
      this.button4.UseVisualStyleBackColor = true;
      this.button4.Click += new System.EventHandler(this.button4_Click);
      // 
      // textBox2
      // 
      this.textBox2.Location = new System.Drawing.Point(265, 213);
      this.textBox2.Name = "textBox2";
      this.textBox2.Size = new System.Drawing.Size(125, 27);
      this.textBox2.TabIndex = 7;
      // 
      // textBox1
      // 
      this.textBox1.Location = new System.Drawing.Point(121, 209);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(125, 27);
      this.textBox1.TabIndex = 6;
      // 
      // Form2
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.button4);
      this.Controls.Add(this.textBox2);
      this.Controls.Add(this.textBox1);
      this.Name = "Form2";
      this.Text = "Form2";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private Button button4;
    private TextBox textBox2;
    private TextBox textBox1;
  }
}