namespace Ornekler.Projeler.RandomOrnekler
{
  partial class ZarOyunu
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
      this.components = new System.ComponentModel.Container();
      this.btnZarAt = new System.Windows.Forms.Button();
      this.pictureBoxZar = new System.Windows.Forms.PictureBox();
      this.btnZarAtThread = new System.Windows.Forms.Button();
      this.btnZarAtTimer = new System.Windows.Forms.Button();
      this.timerZar = new System.Windows.Forms.Timer(this.components);
      ((System.ComponentModel.ISupportInitialize)(this.pictureBoxZar)).BeginInit();
      this.SuspendLayout();
      // 
      // btnZarAt
      // 
      this.btnZarAt.Location = new System.Drawing.Point(49, 155);
      this.btnZarAt.Name = "btnZarAt";
      this.btnZarAt.Size = new System.Drawing.Size(96, 50);
      this.btnZarAt.TabIndex = 0;
      this.btnZarAt.Text = "Zar at";
      this.btnZarAt.UseVisualStyleBackColor = true;
      this.btnZarAt.Click += new System.EventHandler(this.btnZarAt_Click);
      // 
      // pictureBoxZar
      // 
      this.pictureBoxZar.Image = global::Ornekler.Properties.Resources.zar6;
      this.pictureBoxZar.Location = new System.Drawing.Point(21, 12);
      this.pictureBoxZar.Name = "pictureBoxZar";
      this.pictureBoxZar.Size = new System.Drawing.Size(148, 122);
      this.pictureBoxZar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.pictureBoxZar.TabIndex = 1;
      this.pictureBoxZar.TabStop = false;
      // 
      // btnZarAtThread
      // 
      this.btnZarAtThread.Location = new System.Drawing.Point(51, 211);
      this.btnZarAtThread.Name = "btnZarAtThread";
      this.btnZarAtThread.Size = new System.Drawing.Size(94, 50);
      this.btnZarAtThread.TabIndex = 2;
      this.btnZarAtThread.Text = "Zar at Thread";
      this.btnZarAtThread.UseVisualStyleBackColor = true;
      this.btnZarAtThread.Click += new System.EventHandler(this.btnZarAtThread_Click);
      // 
      // btnZarAtTimer
      // 
      this.btnZarAtTimer.Location = new System.Drawing.Point(51, 267);
      this.btnZarAtTimer.Name = "btnZarAtTimer";
      this.btnZarAtTimer.Size = new System.Drawing.Size(100, 50);
      this.btnZarAtTimer.TabIndex = 3;
      this.btnZarAtTimer.Text = "Zar at Timer";
      this.btnZarAtTimer.UseVisualStyleBackColor = true;
      this.btnZarAtTimer.Click += new System.EventHandler(this.btnZarAtTimer_Click);
      // 
      // timerZar
      // 
      this.timerZar.Interval = 200;
      this.timerZar.Tick += new System.EventHandler(this.timerZar_Tick);
      // 
      // ZarOyunu
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(188, 342);
      this.Controls.Add(this.btnZarAtTimer);
      this.Controls.Add(this.btnZarAtThread);
      this.Controls.Add(this.pictureBoxZar);
      this.Controls.Add(this.btnZarAt);
      this.Name = "ZarOyunu";
      this.Text = "ZarOyunu";
      this.Load += new System.EventHandler(this.ZarOyunu_Load);
      ((System.ComponentModel.ISupportInitialize)(this.pictureBoxZar)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private Button btnZarAt;
    private PictureBox pictureBoxZar;
    private Button btnZarAtThread;
    private Button btnZarAtTimer;
    private System.Windows.Forms.Timer timerZar;
  }
}