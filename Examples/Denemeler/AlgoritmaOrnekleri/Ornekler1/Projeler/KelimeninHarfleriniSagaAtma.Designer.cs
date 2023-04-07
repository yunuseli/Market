namespace Ornekler1.Projeler
{
    partial class KelimeninHarfleriniSagaAtma
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
            this.btnYazdır = new System.Windows.Forms.Button();
            this.lblKelime = new System.Windows.Forms.Label();
            this.buttonY2 = new System.Windows.Forms.Button();
            this.buttonY3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnYazdır
            // 
            this.btnYazdır.Location = new System.Drawing.Point(12, 12);
            this.btnYazdır.Name = "btnYazdır";
            this.btnYazdır.Size = new System.Drawing.Size(79, 62);
            this.btnYazdır.TabIndex = 2;
            this.btnYazdır.Text = "Yöntem 1";
            this.btnYazdır.UseVisualStyleBackColor = true;
            this.btnYazdır.Click += new System.EventHandler(this.btnYazdır_Click);
            // 
            // lblKelime
            // 
            this.lblKelime.AutoSize = true;
            this.lblKelime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblKelime.Location = new System.Drawing.Point(117, 25);
            this.lblKelime.Name = "lblKelime";
            this.lblKelime.Size = new System.Drawing.Size(57, 21);
            this.lblKelime.TabIndex = 3;
            this.lblKelime.Text = "label2";
            // 
            // buttonY2
            // 
            this.buttonY2.Location = new System.Drawing.Point(12, 80);
            this.buttonY2.Name = "buttonY2";
            this.buttonY2.Size = new System.Drawing.Size(79, 62);
            this.buttonY2.TabIndex = 4;
            this.buttonY2.Text = "Yöntem 2";
            this.buttonY2.UseVisualStyleBackColor = true;
            this.buttonY2.Click += new System.EventHandler(this.buttonY2_Click);
            // 
            // buttonY3
            // 
            this.buttonY3.Location = new System.Drawing.Point(12, 148);
            this.buttonY3.Name = "buttonY3";
            this.buttonY3.Size = new System.Drawing.Size(79, 62);
            this.buttonY3.TabIndex = 5;
            this.buttonY3.Text = "Yöntem 3";
            this.buttonY3.UseVisualStyleBackColor = true;
            this.buttonY3.Click += new System.EventHandler(this.buttonY3_Click);
            // 
            // KelimeninHarfleriniSagaAtma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 339);
            this.Controls.Add(this.buttonY3);
            this.Controls.Add(this.buttonY2);
            this.Controls.Add(this.lblKelime);
            this.Controls.Add(this.btnYazdır);
            this.Name = "KelimeninHarfleriniSagaAtma";
            this.Text = "KelimeninHarfleriniSagaAtma";
            this.Load += new System.EventHandler(this.KelimeninHarfleriniSagaAtma_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btnYazdır;
        private Label lblKelime;
        private Button buttonY2;
        private Button buttonY3;
    }
}