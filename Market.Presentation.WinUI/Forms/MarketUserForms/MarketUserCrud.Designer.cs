namespace Market.Presentation.WinUI.Forms.MarketUserForms
{
  partial class MarketUserCrud
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
      this.btnSave = new System.Windows.Forms.Button();
      this.btnCancel = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.txtName = new System.Windows.Forms.TextBox();
      this.dtBirthDate = new System.Windows.Forms.DateTimePicker();
      this.txtPassword = new System.Windows.Forms.TextBox();
      this.txtEmail = new System.Windows.Forms.TextBox();
      this.txtSurName = new System.Windows.Forms.TextBox();
      this.label5 = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.label7 = new System.Windows.Forms.Label();
      this.label8 = new System.Windows.Forms.Label();
      this.label9 = new System.Windows.Forms.Label();
      this.lblIslem = new System.Windows.Forms.Label();
      this.rbActive = new System.Windows.Forms.RadioButton();
      this.rbPassive = new System.Windows.Forms.RadioButton();
      this.label2 = new System.Windows.Forms.Label();
      this.pbImage = new System.Windows.Forms.PictureBox();
      this.btnAddPhto = new System.Windows.Forms.Button();
      this.lblPhotoInfo = new System.Windows.Forms.Label();
      this.lblFileInfo = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
      this.SuspendLayout();
      // 
      // btnSave
      // 
      this.btnSave.Location = new System.Drawing.Point(162, 274);
      this.btnSave.Name = "btnSave";
      this.btnSave.Size = new System.Drawing.Size(75, 44);
      this.btnSave.TabIndex = 8;
      this.btnSave.Text = "Kaydet";
      this.btnSave.UseVisualStyleBackColor = true;
      this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
      // 
      // btnCancel
      // 
      this.btnCancel.Location = new System.Drawing.Point(81, 274);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new System.Drawing.Size(75, 44);
      this.btnCancel.TabIndex = 9;
      this.btnCancel.Text = "İptal";
      this.btnCancel.UseVisualStyleBackColor = true;
      this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(27, 14);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(35, 15);
      this.label1.TabIndex = 100;
      this.label1.Text = "İşlem";
      // 
      // txtName
      // 
      this.txtName.Location = new System.Drawing.Point(106, 65);
      this.txtName.Name = "txtName";
      this.txtName.Size = new System.Drawing.Size(200, 23);
      this.txtName.TabIndex = 3;
      // 
      // dtBirthDate
      // 
      this.dtBirthDate.Location = new System.Drawing.Point(106, 181);
      this.dtBirthDate.Name = "dtBirthDate";
      this.dtBirthDate.Size = new System.Drawing.Size(200, 23);
      this.dtBirthDate.TabIndex = 7;
      // 
      // txtPassword
      // 
      this.txtPassword.Location = new System.Drawing.Point(106, 152);
      this.txtPassword.Name = "txtPassword";
      this.txtPassword.Size = new System.Drawing.Size(200, 23);
      this.txtPassword.TabIndex = 6;
      // 
      // txtEmail
      // 
      this.txtEmail.Location = new System.Drawing.Point(106, 123);
      this.txtEmail.Name = "txtEmail";
      this.txtEmail.Size = new System.Drawing.Size(200, 23);
      this.txtEmail.TabIndex = 5;
      // 
      // txtSurName
      // 
      this.txtSurName.Location = new System.Drawing.Point(106, 94);
      this.txtSurName.Name = "txtSurName";
      this.txtSurName.Size = new System.Drawing.Size(200, 23);
      this.txtSurName.TabIndex = 4;
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(24, 187);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(78, 15);
      this.label5.TabIndex = 100;
      this.label5.Text = "Doğum Tarihi";
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(24, 155);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(30, 15);
      this.label6.TabIndex = 100;
      this.label6.Text = "Şifre";
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Location = new System.Drawing.Point(24, 126);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(36, 15);
      this.label7.TabIndex = 100;
      this.label7.Text = "Email";
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Location = new System.Drawing.Point(24, 97);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(39, 15);
      this.label8.TabIndex = 100;
      this.label8.Text = "Soyad";
      // 
      // label9
      // 
      this.label9.AutoSize = true;
      this.label9.Location = new System.Drawing.Point(24, 68);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(22, 15);
      this.label9.TabIndex = 100;
      this.label9.Text = "Ad";
      // 
      // lblIslem
      // 
      this.lblIslem.AutoSize = true;
      this.lblIslem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.lblIslem.Location = new System.Drawing.Point(77, 9);
      this.lblIslem.Name = "lblIslem";
      this.lblIslem.Size = new System.Drawing.Size(51, 21);
      this.lblIslem.TabIndex = 100;
      this.lblIslem.Text = "işlem";
      // 
      // rbActive
      // 
      this.rbActive.AutoSize = true;
      this.rbActive.Location = new System.Drawing.Point(106, 40);
      this.rbActive.Name = "rbActive";
      this.rbActive.Size = new System.Drawing.Size(50, 19);
      this.rbActive.TabIndex = 1;
      this.rbActive.TabStop = true;
      this.rbActive.Text = "Aktif";
      this.rbActive.UseVisualStyleBackColor = true;
      // 
      // rbPassive
      // 
      this.rbPassive.AutoSize = true;
      this.rbPassive.Location = new System.Drawing.Point(162, 40);
      this.rbPassive.Name = "rbPassive";
      this.rbPassive.Size = new System.Drawing.Size(50, 19);
      this.rbPassive.TabIndex = 2;
      this.rbPassive.TabStop = true;
      this.rbPassive.Text = "Pasif";
      this.rbPassive.UseVisualStyleBackColor = true;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(24, 42);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(44, 15);
      this.label2.TabIndex = 101;
      this.label2.Text = "Durum";
      // 
      // pbImage
      // 
      this.pbImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.pbImage.Location = new System.Drawing.Point(325, 65);
      this.pbImage.Name = "pbImage";
      this.pbImage.Size = new System.Drawing.Size(160, 176);
      this.pbImage.TabIndex = 102;
      this.pbImage.TabStop = false;
      // 
      // btnAddPhto
      // 
      this.btnAddPhto.Location = new System.Drawing.Point(325, 25);
      this.btnAddPhto.Name = "btnAddPhto";
      this.btnAddPhto.Size = new System.Drawing.Size(160, 31);
      this.btnAddPhto.TabIndex = 103;
      this.btnAddPhto.Text = "Fotoğraf Yükle";
      this.btnAddPhto.UseVisualStyleBackColor = true;
      this.btnAddPhto.Click += new System.EventHandler(this.btnAddPhto_Click);
      // 
      // lblPhotoInfo
      // 
      this.lblPhotoInfo.AutoSize = true;
      this.lblPhotoInfo.Location = new System.Drawing.Point(325, 250);
      this.lblPhotoInfo.Name = "lblPhotoInfo";
      this.lblPhotoInfo.Size = new System.Drawing.Size(62, 15);
      this.lblPhotoInfo.TabIndex = 104;
      this.lblPhotoInfo.Text = "ResimBilgi";
      // 
      // lblFileInfo
      // 
      this.lblFileInfo.AutoSize = true;
      this.lblFileInfo.Location = new System.Drawing.Point(325, 274);
      this.lblFileInfo.MinimumSize = new System.Drawing.Size(250, 0);
      this.lblFileInfo.Name = "lblFileInfo";
      this.lblFileInfo.Size = new System.Drawing.Size(250, 15);
      this.lblFileInfo.TabIndex = 105;
      this.lblFileInfo.Text = "DosyaBilgi";
      // 
      // MarketUserCrud
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.LightGray;
      this.ClientSize = new System.Drawing.Size(501, 375);
      this.Controls.Add(this.lblFileInfo);
      this.Controls.Add(this.lblPhotoInfo);
      this.Controls.Add(this.btnAddPhto);
      this.Controls.Add(this.pbImage);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.rbPassive);
      this.Controls.Add(this.rbActive);
      this.Controls.Add(this.lblIslem);
      this.Controls.Add(this.label9);
      this.Controls.Add(this.label8);
      this.Controls.Add(this.label7);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.txtSurName);
      this.Controls.Add(this.txtEmail);
      this.Controls.Add(this.txtPassword);
      this.Controls.Add(this.dtBirthDate);
      this.Controls.Add(this.txtName);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.btnCancel);
      this.Controls.Add(this.btnSave);
      this.Name = "MarketUserCrud";
      this.Text = "Kullanıcı İşlemleri";
      this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MarketUserCrud_FormClosed);
      this.Load += new System.EventHandler(this.MarketUserCrud_Load);
      ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private Button btnSave;
    private Button btnCancel;
    private Label label1;
    private TextBox txtName;
    private DateTimePicker dtBirthDate;
    private TextBox txtPassword;
    private TextBox txtEmail;
    private TextBox txtSurName;
    private Label label5;
    private Label label6;
    private Label label7;
    private Label label8;
    private Label label9;
    private Label lblIslem;
    private RadioButton rbActive;
    private RadioButton rbPassive;
    private Label label2;
    private PictureBox pbImage;
    private Button btnAddPhto;
    private Label lblPhotoInfo;
    private Label lblFileInfo;
  }
}