namespace Ornekler1.Projeler
{
    partial class Siramatik
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
            this.lstSira = new System.Windows.Forms.ListBox();
            this.lstTemsilci1 = new System.Windows.Forms.ListBox();
            this.lstTemsilci2 = new System.Windows.Forms.ListBox();
            this.btnSiraAl = new System.Windows.Forms.Button();
            this.btnTemsilci1 = new System.Windows.Forms.Button();
            this.btnTemsilci2 = new System.Windows.Forms.Button();
            this.btnSifirla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstSira
            // 
            this.lstSira.FormattingEnabled = true;
            this.lstSira.ItemHeight = 15;
            this.lstSira.Location = new System.Drawing.Point(29, 81);
            this.lstSira.Name = "lstSira";
            this.lstSira.Size = new System.Drawing.Size(145, 289);
            this.lstSira.TabIndex = 0;
            // 
            // lstTemsilci1
            // 
            this.lstTemsilci1.FormattingEnabled = true;
            this.lstTemsilci1.ItemHeight = 15;
            this.lstTemsilci1.Location = new System.Drawing.Point(244, 80);
            this.lstTemsilci1.Name = "lstTemsilci1";
            this.lstTemsilci1.Size = new System.Drawing.Size(145, 289);
            this.lstTemsilci1.TabIndex = 1;
            // 
            // lstTemsilci2
            // 
            this.lstTemsilci2.FormattingEnabled = true;
            this.lstTemsilci2.ItemHeight = 15;
            this.lstTemsilci2.Location = new System.Drawing.Point(405, 80);
            this.lstTemsilci2.Name = "lstTemsilci2";
            this.lstTemsilci2.Size = new System.Drawing.Size(145, 289);
            this.lstTemsilci2.TabIndex = 2;
            // 
            // btnSiraAl
            // 
            this.btnSiraAl.Location = new System.Drawing.Point(29, 25);
            this.btnSiraAl.Name = "btnSiraAl";
            this.btnSiraAl.Size = new System.Drawing.Size(75, 50);
            this.btnSiraAl.TabIndex = 3;
            this.btnSiraAl.Text = "Sıra Al";
            this.btnSiraAl.UseVisualStyleBackColor = true;
            this.btnSiraAl.Click += new System.EventHandler(this.btnSiraAl_Click);
            // 
            // btnTemsilci1
            // 
            this.btnTemsilci1.Location = new System.Drawing.Point(244, 24);
            this.btnTemsilci1.Name = "btnTemsilci1";
            this.btnTemsilci1.Size = new System.Drawing.Size(75, 50);
            this.btnTemsilci1.TabIndex = 4;
            this.btnTemsilci1.Text = "Müşteri al temsilci 1";
            this.btnTemsilci1.UseVisualStyleBackColor = true;
            this.btnTemsilci1.Click += new System.EventHandler(this.btnTemsilci1_Click);
            // 
            // btnTemsilci2
            // 
            this.btnTemsilci2.Location = new System.Drawing.Point(405, 24);
            this.btnTemsilci2.Name = "btnTemsilci2";
            this.btnTemsilci2.Size = new System.Drawing.Size(75, 50);
            this.btnTemsilci2.TabIndex = 5;
            this.btnTemsilci2.Text = "Müşteri al temsilci 2";
            this.btnTemsilci2.UseVisualStyleBackColor = true;
            this.btnTemsilci2.Click += new System.EventHandler(this.btnTemsilci2_Click);
            // 
            // btnSifirla
            // 
            this.btnSifirla.Location = new System.Drawing.Point(29, 406);
            this.btnSifirla.Name = "btnSifirla";
            this.btnSifirla.Size = new System.Drawing.Size(83, 45);
            this.btnSifirla.TabIndex = 6;
            this.btnSifirla.Text = "Sıfırla";
            this.btnSifirla.UseVisualStyleBackColor = true;
            this.btnSifirla.Click += new System.EventHandler(this.btnSifirla_Click);
            // 
            // Siramatik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 485);
            this.Controls.Add(this.btnSifirla);
            this.Controls.Add(this.btnTemsilci2);
            this.Controls.Add(this.btnTemsilci1);
            this.Controls.Add(this.btnSiraAl);
            this.Controls.Add(this.lstTemsilci2);
            this.Controls.Add(this.lstTemsilci1);
            this.Controls.Add(this.lstSira);
            this.Name = "Siramatik";
            this.Text = "Siramatik";
            this.Load += new System.EventHandler(this.Siramatik_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox lstSira;
        private ListBox lstTemsilci1;
        private ListBox lstTemsilci2;
        private Button btnSiraAl;
        private Button btnTemsilci1;
        private Button btnTemsilci2;
        private Button btnSifirla;
    }
}