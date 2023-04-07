namespace Market.Presentation.WinUI
{
  partial class Login
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
      this.label1 = new System.Windows.Forms.Label();
      this.buttonCancel = new System.Windows.Forms.Button();
      this.label4 = new System.Windows.Forms.Label();
      this.textBoxPassword = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.textBoxEmail = new System.Windows.Forms.TextBox();
      this.buttonLogin = new System.Windows.Forms.Button();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.label1.ForeColor = System.Drawing.Color.RosyBrown;
      this.label1.Location = new System.Drawing.Point(85, 21);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(387, 54);
      this.label1.TabIndex = 36;
      this.label1.Text = "BİRAZIDA BURADA";
      // 
      // buttonCancel
      // 
      this.buttonCancel.Location = new System.Drawing.Point(169, 177);
      this.buttonCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.buttonCancel.Name = "buttonCancel";
      this.buttonCancel.Size = new System.Drawing.Size(89, 51);
      this.buttonCancel.TabIndex = 35;
      this.buttonCancel.Text = "İptal";
      this.buttonCancel.UseVisualStyleBackColor = true;
      this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(120, 143);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(39, 20);
      this.label4.TabIndex = 34;
      this.label4.Text = "Şifre";
      // 
      // textBoxPassword
      // 
      this.textBoxPassword.Location = new System.Drawing.Point(169, 139);
      this.textBoxPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.textBoxPassword.Name = "textBoxPassword";
      this.textBoxPassword.PasswordChar = '*';
      this.textBoxPassword.Size = new System.Drawing.Size(201, 27);
      this.textBoxPassword.TabIndex = 33;
      this.textBoxPassword.UseSystemPasswordChar = true;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(121, 104);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(46, 20);
      this.label3.TabIndex = 32;
      this.label3.Text = "Email";
      // 
      // textBoxEmail
      // 
      this.textBoxEmail.Location = new System.Drawing.Point(169, 100);
      this.textBoxEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.textBoxEmail.Name = "textBoxEmail";
      this.textBoxEmail.Size = new System.Drawing.Size(201, 27);
      this.textBoxEmail.TabIndex = 31;
      // 
      // buttonLogin
      // 
      this.buttonLogin.BackColor = System.Drawing.Color.LightBlue;
      this.buttonLogin.Location = new System.Drawing.Point(265, 177);
      this.buttonLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.buttonLogin.Name = "buttonLogin";
      this.buttonLogin.Size = new System.Drawing.Size(105, 51);
      this.buttonLogin.TabIndex = 30;
      this.buttonLogin.Text = "Giriş Yap";
      this.buttonLogin.UseVisualStyleBackColor = false;
      this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
      // 
      // pictureBox1
      // 
      this.pictureBox1.Image = global::Market.Presentation.WinUI.Properties.Resources.shop;
      this.pictureBox1.Location = new System.Drawing.Point(13, 15);
      this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(65, 67);
      this.pictureBox1.TabIndex = 37;
      this.pictureBox1.TabStop = false;
      // 
      // Login
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(477, 239);
      this.Controls.Add(this.pictureBox1);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.buttonCancel);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.textBoxPassword);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.textBoxEmail);
      this.Controls.Add(this.buttonLogin);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "Login";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Market - Giriş";
      this.Load += new System.EventHandler(this.Form_Load);
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private Label label1;
    private Button buttonCancel;
    private Label label4;
    private TextBox textBoxPassword;
    private Label label3;
    private TextBox textBoxEmail;
    private Button buttonLogin;
    private PictureBox pictureBox1;
  }
}