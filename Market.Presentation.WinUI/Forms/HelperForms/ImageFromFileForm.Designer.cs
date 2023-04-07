namespace Market.Presentation.WinUI.Forms.HelperForms
{
  partial class ImageFromFileForm
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
      this.pbImage = new System.Windows.Forms.PictureBox();
      this.btnAddPhto = new System.Windows.Forms.Button();
      this.lblPhotoInfo = new System.Windows.Forms.Label();
      this.lblFileInfo = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
      this.SuspendLayout();
      // 
      // btnSave
      // 
      this.btnSave.Location = new System.Drawing.Point(93, 292);
      this.btnSave.Name = "btnSave";
      this.btnSave.Size = new System.Drawing.Size(75, 31);
      this.btnSave.TabIndex = 8;
      this.btnSave.Text = "Ekle";
      this.btnSave.UseVisualStyleBackColor = true;
      this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
      // 
      // btnCancel
      // 
      this.btnCancel.Location = new System.Drawing.Point(12, 292);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new System.Drawing.Size(75, 31);
      this.btnCancel.TabIndex = 9;
      this.btnCancel.Text = "İptal";
      this.btnCancel.UseVisualStyleBackColor = true;
      this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
      // 
      // pbImage
      // 
      this.pbImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.pbImage.Location = new System.Drawing.Point(12, 52);
      this.pbImage.Name = "pbImage";
      this.pbImage.Size = new System.Drawing.Size(160, 176);
      this.pbImage.TabIndex = 102;
      this.pbImage.TabStop = false;
      // 
      // btnAddPhto
      // 
      this.btnAddPhto.Location = new System.Drawing.Point(12, 12);
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
      this.lblPhotoInfo.Location = new System.Drawing.Point(12, 237);
      this.lblPhotoInfo.Name = "lblPhotoInfo";
      this.lblPhotoInfo.Size = new System.Drawing.Size(62, 15);
      this.lblPhotoInfo.TabIndex = 104;
      this.lblPhotoInfo.Text = "ResimBilgi";
      // 
      // lblFileInfo
      // 
      this.lblFileInfo.AutoSize = true;
      this.lblFileInfo.Location = new System.Drawing.Point(12, 261);
      this.lblFileInfo.MinimumSize = new System.Drawing.Size(250, 0);
      this.lblFileInfo.Name = "lblFileInfo";
      this.lblFileInfo.Size = new System.Drawing.Size(250, 15);
      this.lblFileInfo.TabIndex = 105;
      this.lblFileInfo.Text = "DosyaBilgi";
      // 
      // ImageFromFileForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.Bisque;
      this.ClientSize = new System.Drawing.Size(182, 332);
      this.Controls.Add(this.lblFileInfo);
      this.Controls.Add(this.lblPhotoInfo);
      this.Controls.Add(this.btnAddPhto);
      this.Controls.Add(this.pbImage);
      this.Controls.Add(this.btnCancel);
      this.Controls.Add(this.btnSave);
      this.Name = "ImageFromFileForm";
      this.Text = "Foto";
      this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MarketUserCrud_FormClosed);
      this.Load += new System.EventHandler(this.MarketUserCrud_Load);
      ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private Button btnSave;
    private Button btnCancel;
    private PictureBox pbImage;
    private Button btnAddPhto;
    private Label lblPhotoInfo;
    private Label lblFileInfo;
  }
}