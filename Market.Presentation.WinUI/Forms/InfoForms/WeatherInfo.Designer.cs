namespace Market.Presentation.WinUI.Forms.InfoForms
{
  partial class WeatherInfo
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
      this.btnGetData = new System.Windows.Forms.Button();
      this.lblInfo = new System.Windows.Forms.Label();
      this.pbStatus = new System.Windows.Forms.PictureBox();
      this.btnTcmb = new System.Windows.Forms.Button();
      this.dataGridView1 = new System.Windows.Forms.DataGridView();
      ((System.ComponentModel.ISupportInitialize)(this.pbStatus)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
      this.SuspendLayout();
      // 
      // btnGetData
      // 
      this.btnGetData.Location = new System.Drawing.Point(27, 32);
      this.btnGetData.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.btnGetData.Name = "btnGetData";
      this.btnGetData.Size = new System.Drawing.Size(88, 65);
      this.btnGetData.TabIndex = 0;
      this.btnGetData.Text = "Hava Durumu";
      this.btnGetData.UseVisualStyleBackColor = true;
      this.btnGetData.Click += new System.EventHandler(this.btnGetData_Click);
      // 
      // lblInfo
      // 
      this.lblInfo.AutoSize = true;
      this.lblInfo.Location = new System.Drawing.Point(27, 124);
      this.lblInfo.Name = "lblInfo";
      this.lblInfo.Size = new System.Drawing.Size(54, 20);
      this.lblInfo.TabIndex = 1;
      this.lblInfo.Text = "Durum";
      // 
      // pbStatus
      // 
      this.pbStatus.Location = new System.Drawing.Point(27, 207);
      this.pbStatus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.pbStatus.Name = "pbStatus";
      this.pbStatus.Size = new System.Drawing.Size(120, 89);
      this.pbStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.pbStatus.TabIndex = 2;
      this.pbStatus.TabStop = false;
      // 
      // btnTcmb
      // 
      this.btnTcmb.Location = new System.Drawing.Point(280, 32);
      this.btnTcmb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.btnTcmb.Name = "btnTcmb";
      this.btnTcmb.Size = new System.Drawing.Size(122, 65);
      this.btnTcmb.TabIndex = 3;
      this.btnTcmb.Text = "TCMB Döviz Kurları";
      this.btnTcmb.UseVisualStyleBackColor = true;
      this.btnTcmb.Click += new System.EventHandler(this.btnTcmb_Click);
      // 
      // dataGridView1
      // 
      this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Location = new System.Drawing.Point(280, 124);
      this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.RowHeadersWidth = 51;
      this.dataGridView1.RowTemplate.Height = 25;
      this.dataGridView1.Size = new System.Drawing.Size(645, 424);
      this.dataGridView1.TabIndex = 4;
      // 
      // WeatherInfo
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1234, 727);
      this.Controls.Add(this.dataGridView1);
      this.Controls.Add(this.btnTcmb);
      this.Controls.Add(this.pbStatus);
      this.Controls.Add(this.lblInfo);
      this.Controls.Add(this.btnGetData);
      this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.Name = "WeatherInfo";
      this.Text = "WeatherInfo";
      this.Load += new System.EventHandler(this.WeatherInfo_Load);
      ((System.ComponentModel.ISupportInitialize)(this.pbStatus)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private Button btnGetData;
    private Label lblInfo;
    private PictureBox pbStatus;
    private Button btnTcmb;
    private DataGridView dataGridView1;
  }
}