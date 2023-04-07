namespace MerhabaClass2
{
  partial class Form1
  {
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.button5 = new System.Windows.Forms.Button();
      this.textBox2 = new System.Windows.Forms.TextBox();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // button5
      // 
      this.button5.Location = new System.Drawing.Point(417, 241);
      this.button5.Name = "button5";
      this.button5.Size = new System.Drawing.Size(262, 29);
      this.button5.TabIndex = 9;
      this.button5.Text = "Class Library Topla";
      this.button5.UseVisualStyleBackColor = true;
      this.button5.Click += new System.EventHandler(this.button5_Click);
      // 
      // textBox2
      // 
      this.textBox2.Location = new System.Drawing.Point(265, 185);
      this.textBox2.Name = "textBox2";
      this.textBox2.Size = new System.Drawing.Size(125, 27);
      this.textBox2.TabIndex = 8;
      // 
      // textBox1
      // 
      this.textBox1.Location = new System.Drawing.Point(121, 181);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(125, 27);
      this.textBox1.TabIndex = 7;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.button5);
      this.Controls.Add(this.textBox2);
      this.Controls.Add(this.textBox1);
      this.Name = "Form1";
      this.Text = "Form1";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private Button button5;
    private TextBox textBox2;
    private TextBox textBox1;
  }
}