namespace IlkProje
{
  partial class Giris
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
      this.btnLogin = new System.Windows.Forms.Button();
      this.txtUserName = new System.Windows.Forms.TextBox();
      this.txtPassword = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // btnLogin
      // 
      this.btnLogin.BackColor = System.Drawing.Color.Yellow;
      this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.btnLogin.Location = new System.Drawing.Point(362, 38);
      this.btnLogin.Name = "btnLogin";
      this.btnLogin.Size = new System.Drawing.Size(128, 69);
      this.btnLogin.TabIndex = 0;
      this.btnLogin.Text = "Giriş";
      this.btnLogin.UseVisualStyleBackColor = false;
      this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
      // 
      // txtUserName
      // 
      this.txtUserName.Location = new System.Drawing.Point(157, 38);
      this.txtUserName.Name = "txtUserName";
      this.txtUserName.Size = new System.Drawing.Size(190, 27);
      this.txtUserName.TabIndex = 1;
      // 
      // txtPassword
      // 
      this.txtPassword.Location = new System.Drawing.Point(157, 80);
      this.txtPassword.Name = "txtPassword";
      this.txtPassword.PasswordChar = 'x';
      this.txtPassword.Size = new System.Drawing.Size(190, 27);
      this.txtPassword.TabIndex = 2;
      this.txtPassword.UseSystemPasswordChar = true;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(52, 41);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(92, 20);
      this.label1.TabIndex = 3;
      this.label1.Text = "Kullanıcı Adı";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(52, 83);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(39, 20);
      this.label2.TabIndex = 4;
      this.label2.Text = "Şifre";
      // 
      // Giris
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(564, 147);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.txtPassword);
      this.Controls.Add(this.txtUserName);
      this.Controls.Add(this.btnLogin);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "Giris";
      this.Text = "Giris";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private Button btnLogin;
    private TextBox txtUserName;
    private TextBox txtPassword;
    private Label label1;
    private Label label2;
  }
}