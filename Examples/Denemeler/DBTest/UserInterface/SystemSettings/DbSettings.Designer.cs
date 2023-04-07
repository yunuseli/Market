namespace DBTest.UserInterface.SystemSettings
{
  partial class DbSettings
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
      this.buttonPrepare = new System.Windows.Forms.Button();
      this.textBoxServer = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.textBoxDatabase = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.textBoxUser = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.textBoxPassword = new System.Windows.Forms.TextBox();
      this.richTextBoxSql = new System.Windows.Forms.RichTextBox();
      this.buttonSave = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // buttonPrepare
      // 
      this.buttonPrepare.Location = new System.Drawing.Point(206, 147);
      this.buttonPrepare.Name = "buttonPrepare";
      this.buttonPrepare.Size = new System.Drawing.Size(112, 38);
      this.buttonPrepare.TabIndex = 0;
      this.buttonPrepare.Text = "Hazırla";
      this.buttonPrepare.UseVisualStyleBackColor = true;
      this.buttonPrepare.Click += new System.EventHandler(this.buttonPrepare_Click);
      // 
      // textBoxServer
      // 
      this.textBoxServer.Location = new System.Drawing.Point(79, 31);
      this.textBoxServer.Name = "textBoxServer";
      this.textBoxServer.Size = new System.Drawing.Size(239, 23);
      this.textBoxServer.TabIndex = 1;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(22, 34);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(39, 15);
      this.label1.TabIndex = 2;
      this.label1.Text = "Server";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(23, 63);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(55, 15);
      this.label2.TabIndex = 4;
      this.label2.Text = "Database";
      // 
      // textBoxDatabase
      // 
      this.textBoxDatabase.Location = new System.Drawing.Point(79, 60);
      this.textBoxDatabase.Name = "textBoxDatabase";
      this.textBoxDatabase.Size = new System.Drawing.Size(239, 23);
      this.textBoxDatabase.TabIndex = 3;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(23, 92);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(30, 15);
      this.label3.TabIndex = 6;
      this.label3.Text = "User";
      // 
      // textBoxUser
      // 
      this.textBoxUser.Location = new System.Drawing.Point(79, 89);
      this.textBoxUser.Name = "textBoxUser";
      this.textBoxUser.Size = new System.Drawing.Size(239, 23);
      this.textBoxUser.TabIndex = 5;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(22, 121);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(57, 15);
      this.label4.TabIndex = 8;
      this.label4.Text = "Password";
      // 
      // textBoxPassword
      // 
      this.textBoxPassword.Location = new System.Drawing.Point(79, 118);
      this.textBoxPassword.Name = "textBoxPassword";
      this.textBoxPassword.Size = new System.Drawing.Size(239, 23);
      this.textBoxPassword.TabIndex = 7;
      // 
      // richTextBoxSql
      // 
      this.richTextBoxSql.Location = new System.Drawing.Point(79, 191);
      this.richTextBoxSql.Name = "richTextBoxSql";
      this.richTextBoxSql.Size = new System.Drawing.Size(239, 96);
      this.richTextBoxSql.TabIndex = 9;
      this.richTextBoxSql.Text = "";
      // 
      // buttonSave
      // 
      this.buttonSave.Location = new System.Drawing.Point(206, 293);
      this.buttonSave.Name = "buttonSave";
      this.buttonSave.Size = new System.Drawing.Size(112, 38);
      this.buttonSave.TabIndex = 10;
      this.buttonSave.Text = "Kaydet";
      this.buttonSave.UseVisualStyleBackColor = true;
      this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
      // 
      // DbSettings
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(334, 346);
      this.Controls.Add(this.buttonSave);
      this.Controls.Add(this.richTextBoxSql);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.textBoxPassword);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.textBoxUser);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.textBoxDatabase);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.textBoxServer);
      this.Controls.Add(this.buttonPrepare);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "DbSettings";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Veri Tabanı Ayarları";
      this.Load += new System.EventHandler(this.DbSettings_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private Button buttonPrepare;
    private TextBox textBoxServer;
    private Label label1;
    private Label label2;
    private TextBox textBoxDatabase;
    private Label label3;
    private TextBox textBoxUser;
    private Label label4;
    private TextBox textBoxPassword;
    private RichTextBox richTextBoxSql;
    private Button buttonSave;
  }
}