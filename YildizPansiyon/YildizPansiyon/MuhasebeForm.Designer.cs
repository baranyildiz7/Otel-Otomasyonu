namespace YildizPansiyon
{
    partial class MuhasebeForm
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
            this.LblSaat = new System.Windows.Forms.Label();
            this.LblTarih = new System.Windows.Forms.Label();
            this.BtnRadyoDinle = new System.Windows.Forms.Button();
            this.BtnStoklar = new System.Windows.Forms.Button();
            this.BtnGelirGider = new System.Windows.Forms.Button();
            this.BtnAdminGiris = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.BtnSifreGuncelle = new System.Windows.Forms.Button();
            this.BtnCikis = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LblSaat
            // 
            this.LblSaat.AutoSize = true;
            this.LblSaat.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblSaat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblSaat.Location = new System.Drawing.Point(978, 129);
            this.LblSaat.Name = "LblSaat";
            this.LblSaat.Size = new System.Drawing.Size(96, 33);
            this.LblSaat.TabIndex = 21;
            this.LblSaat.Text = "label2";
            // 
            // LblTarih
            // 
            this.LblTarih.AutoSize = true;
            this.LblTarih.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblTarih.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblTarih.Location = new System.Drawing.Point(908, 54);
            this.LblTarih.Name = "LblTarih";
            this.LblTarih.Size = new System.Drawing.Size(96, 33);
            this.LblTarih.TabIndex = 20;
            this.LblTarih.Text = "label1";
            // 
            // BtnRadyoDinle
            // 
            this.BtnRadyoDinle.BackColor = System.Drawing.Color.Gainsboro;
            this.BtnRadyoDinle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnRadyoDinle.Location = new System.Drawing.Point(21, 359);
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
            this.BtnStoklar.Location = new System.Drawing.Point(683, 146);
            this.BtnStoklar.Name = "BtnStoklar";
            this.BtnStoklar.Size = new System.Drawing.Size(173, 133);
            this.BtnStoklar.TabIndex = 16;
            this.BtnStoklar.Text = "Faturalar";
            this.BtnStoklar.UseVisualStyleBackColor = false;
            this.BtnStoklar.Click += new System.EventHandler(this.BtnStoklar_Click);
            // 
            // BtnGelirGider
            // 
            this.BtnGelirGider.BackColor = System.Drawing.Color.Gainsboro;
            this.BtnGelirGider.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnGelirGider.Location = new System.Drawing.Point(347, 146);
            this.BtnGelirGider.Name = "BtnGelirGider";
            this.BtnGelirGider.Size = new System.Drawing.Size(173, 133);
            this.BtnGelirGider.TabIndex = 15;
            this.BtnGelirGider.Text = "Gelir-Gider Formu";
            this.BtnGelirGider.UseVisualStyleBackColor = false;
            this.BtnGelirGider.Click += new System.EventHandler(this.BtnGelirGider_Click);
            // 
            // BtnAdminGiris
            // 
            this.BtnAdminGiris.BackColor = System.Drawing.Color.Gainsboro;
            this.BtnAdminGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnAdminGiris.Location = new System.Drawing.Point(21, 146);
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
            this.BtnSifreGuncelle.Location = new System.Drawing.Point(347, 370);
            this.BtnSifreGuncelle.Name = "BtnSifreGuncelle";
            this.BtnSifreGuncelle.Size = new System.Drawing.Size(173, 133);
            this.BtnSifreGuncelle.TabIndex = 23;
            this.BtnSifreGuncelle.Text = "Şifre Güncelle";
            this.BtnSifreGuncelle.UseVisualStyleBackColor = false;
            this.BtnSifreGuncelle.Click += new System.EventHandler(this.BtnSifreGuncelle_Click);
            // 
            // BtnCikis
            // 
            this.BtnCikis.BackColor = System.Drawing.Color.Red;
            this.BtnCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnCikis.Location = new System.Drawing.Point(683, 370);
            this.BtnCikis.Name = "BtnCikis";
            this.BtnCikis.Size = new System.Drawing.Size(173, 133);
            this.BtnCikis.TabIndex = 19;
            this.BtnCikis.Text = "Çıkış";
            this.BtnCikis.UseVisualStyleBackColor = false;
            this.BtnCikis.Click += new System.EventHandler(this.BtnCikis_Click);
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
            // MuhasebeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1251, 663);
            this.Controls.Add(this.LblSaat);
            this.Controls.Add(this.LblTarih);
            this.Controls.Add(this.BtnRadyoDinle);
            this.Controls.Add(this.BtnStoklar);
            this.Controls.Add(this.BtnGelirGider);
            this.Controls.Add(this.BtnAdminGiris);
            this.Controls.Add(this.BtnSifreGuncelle);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnCikis);
            this.Name = "MuhasebeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Muhasebe";
            this.Load += new System.EventHandler(this.MuhasebeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblSaat;
        private System.Windows.Forms.Label LblTarih;
        private System.Windows.Forms.Button BtnRadyoDinle;
        private System.Windows.Forms.Button BtnStoklar;
        private System.Windows.Forms.Button BtnGelirGider;
        private System.Windows.Forms.Button BtnAdminGiris;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button BtnSifreGuncelle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnCikis;
    }
}