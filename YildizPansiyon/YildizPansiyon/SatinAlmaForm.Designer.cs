namespace YildizPansiyon
{
    partial class SatinAlmaForm
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
            this.BtnRadyoDinle = new System.Windows.Forms.Button();
            this.BtnStoklar = new System.Windows.Forms.Button();
            this.BtnAdminGiris = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.BtnSifreGuncelle = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnCikis = new System.Windows.Forms.Button();
            this.LblSaat = new System.Windows.Forms.Label();
            this.LblTarih = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnRadyoDinle
            // 
            this.BtnRadyoDinle.BackColor = System.Drawing.Color.Gainsboro;
            this.BtnRadyoDinle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnRadyoDinle.Location = new System.Drawing.Point(72, 366);
            this.BtnRadyoDinle.Name = "BtnRadyoDinle";
            this.BtnRadyoDinle.Size = new System.Drawing.Size(173, 133);
            this.BtnRadyoDinle.TabIndex = 18;
            this.BtnRadyoDinle.Text = "Radyo Dinle";
            this.BtnRadyoDinle.UseVisualStyleBackColor = false;
            this.BtnRadyoDinle.Click += new System.EventHandler(this.BtnRadyoDinle_Click);
            // 
            // BtnStoklar
            // 
            this.BtnStoklar.BackColor = System.Drawing.Color.Gainsboro;
            this.BtnStoklar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnStoklar.Location = new System.Drawing.Point(514, 142);
            this.BtnStoklar.Name = "BtnStoklar";
            this.BtnStoklar.Size = new System.Drawing.Size(173, 133);
            this.BtnStoklar.TabIndex = 16;
            this.BtnStoklar.Text = "Stoklar";
            this.BtnStoklar.UseVisualStyleBackColor = false;
            this.BtnStoklar.Click += new System.EventHandler(this.BtnStoklar_Click);
            // 
            // BtnAdminGiris
            // 
            this.BtnAdminGiris.BackColor = System.Drawing.Color.Gainsboro;
            this.BtnAdminGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnAdminGiris.Location = new System.Drawing.Point(227, 142);
            this.BtnAdminGiris.Name = "BtnAdminGiris";
            this.BtnAdminGiris.Size = new System.Drawing.Size(173, 133);
            this.BtnAdminGiris.TabIndex = 13;
            this.BtnAdminGiris.Text = "Admin Giriş";
            this.BtnAdminGiris.UseVisualStyleBackColor = false;
            this.BtnAdminGiris.Click += new System.EventHandler(this.BtnAdminGiris_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // BtnSifreGuncelle
            // 
            this.BtnSifreGuncelle.BackColor = System.Drawing.Color.Gainsboro;
            this.BtnSifreGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnSifreGuncelle.Location = new System.Drawing.Point(376, 366);
            this.BtnSifreGuncelle.Name = "BtnSifreGuncelle";
            this.BtnSifreGuncelle.Size = new System.Drawing.Size(173, 133);
            this.BtnSifreGuncelle.TabIndex = 23;
            this.BtnSifreGuncelle.Text = "Şifre Güncelle";
            this.BtnSifreGuncelle.UseVisualStyleBackColor = false;
            this.BtnSifreGuncelle.Click += new System.EventHandler(this.BtnSifreGuncelle_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::YildizPansiyon.Properties.Resources.yildiz_gif;
            this.pictureBox1.Location = new System.Drawing.Point(885, 361);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(345, 248);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // BtnCikis
            // 
            this.BtnCikis.BackColor = System.Drawing.Color.Red;
            this.BtnCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnCikis.Location = new System.Drawing.Point(666, 366);
            this.BtnCikis.Name = "BtnCikis";
            this.BtnCikis.Size = new System.Drawing.Size(173, 133);
            this.BtnCikis.TabIndex = 19;
            this.BtnCikis.Text = "Çıkış";
            this.BtnCikis.UseVisualStyleBackColor = false;
            this.BtnCikis.Click += new System.EventHandler(this.BtnCikis_Click);
            // 
            // LblSaat
            // 
            this.LblSaat.AutoSize = true;
            this.LblSaat.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblSaat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblSaat.Location = new System.Drawing.Point(983, 133);
            this.LblSaat.Name = "LblSaat";
            this.LblSaat.Size = new System.Drawing.Size(96, 33);
            this.LblSaat.TabIndex = 36;
            this.LblSaat.Text = "label2";
            // 
            // LblTarih
            // 
            this.LblTarih.AutoSize = true;
            this.LblTarih.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblTarih.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblTarih.Location = new System.Drawing.Point(909, 55);
            this.LblTarih.Name = "LblTarih";
            this.LblTarih.Size = new System.Drawing.Size(96, 33);
            this.LblTarih.TabIndex = 35;
            this.LblTarih.Text = "label1";
            // 
            // SatinAlmaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1251, 663);
            this.Controls.Add(this.LblSaat);
            this.Controls.Add(this.LblTarih);
            this.Controls.Add(this.BtnRadyoDinle);
            this.Controls.Add(this.BtnStoklar);
            this.Controls.Add(this.BtnAdminGiris);
            this.Controls.Add(this.BtnSifreGuncelle);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnCikis);
            this.Name = "SatinAlmaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Satın Alma";
            this.Load += new System.EventHandler(this.SatinAlmaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnRadyoDinle;
        private System.Windows.Forms.Button BtnStoklar;
        private System.Windows.Forms.Button BtnAdminGiris;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button BtnSifreGuncelle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnCikis;
        private System.Windows.Forms.Label LblSaat;
        private System.Windows.Forms.Label LblTarih;
    }
}