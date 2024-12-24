namespace YildizPansiyon
{
    partial class RadyoDinleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RadyoDinleForm));
            this.LinkLbl90lar = new System.Windows.Forms.LinkLabel();
            this.LinkLblKralPop = new System.Windows.Forms.LinkLabel();
            this.LinkLblArabeskFm = new System.Windows.Forms.LinkLabel();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // LinkLbl90lar
            // 
            this.LinkLbl90lar.AutoSize = true;
            this.LinkLbl90lar.Font = new System.Drawing.Font("Arial Black", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LinkLbl90lar.Location = new System.Drawing.Point(11, 502);
            this.LinkLbl90lar.Name = "LinkLbl90lar";
            this.LinkLbl90lar.Size = new System.Drawing.Size(126, 40);
            this.LinkLbl90lar.TabIndex = 1;
            this.LinkLbl90lar.TabStop = true;
            this.LinkLbl90lar.Text = "90\'LAR";
            this.LinkLbl90lar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLbl90lar_LinkClicked);
            // 
            // LinkLblKralPop
            // 
            this.LinkLblKralPop.AutoSize = true;
            this.LinkLblKralPop.Font = new System.Drawing.Font("Arial Black", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LinkLblKralPop.Location = new System.Drawing.Point(252, 502);
            this.LinkLblKralPop.Name = "LinkLblKralPop";
            this.LinkLblKralPop.Size = new System.Drawing.Size(175, 40);
            this.LinkLblKralPop.TabIndex = 2;
            this.LinkLblKralPop.TabStop = true;
            this.LinkLblKralPop.Text = "KRAL POP";
            this.LinkLblKralPop.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLblKralPop_LinkClicked);
            // 
            // LinkLblArabeskFm
            // 
            this.LinkLblArabeskFm.AutoSize = true;
            this.LinkLblArabeskFm.Font = new System.Drawing.Font("Arial Black", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LinkLblArabeskFm.Location = new System.Drawing.Point(495, 502);
            this.LinkLblArabeskFm.Name = "LinkLblArabeskFm";
            this.LinkLblArabeskFm.Size = new System.Drawing.Size(222, 40);
            this.LinkLblArabeskFm.TabIndex = 3;
            this.LinkLblArabeskFm.TabStop = true;
            this.LinkLblArabeskFm.Text = "ARABESK FM";
            this.LinkLblArabeskFm.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLblArabeskFm_LinkClicked);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(12, 12);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(706, 410);
            this.axWindowsMediaPlayer1.TabIndex = 0;
            // 
            // RadyoDinleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(729, 592);
            this.Controls.Add(this.LinkLblArabeskFm);
            this.Controls.Add(this.LinkLblKralPop);
            this.Controls.Add(this.LinkLbl90lar);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RadyoDinleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Radyo Dinle";
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.LinkLabel LinkLbl90lar;
        private System.Windows.Forms.LinkLabel LinkLblKralPop;
        private System.Windows.Forms.LinkLabel LinkLblArabeskFm;
    }
}