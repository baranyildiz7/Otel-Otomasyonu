using System.Drawing;
using System;
using System.Windows.Forms;

namespace YildizPansiyon
{
    partial class FaturaForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        // Bileşenler
        private TextBox txtFaturaNo;
        private DateTimePicker dtpFaturaTarihi;
        private ComboBox cmbMusteri;
        private TextBox txtVergiDairesi;
        private TextBox txtVergiNo;
        private MaskedTextBox mskdTxtTelefon;
        private DataGridView dataGridView1;
        private Label lblAraToplam;
        private Label lblKdv;
        private Label lblGenelToplam;
        private Button btnEkle;
        private Button btnKaydet;

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
            this.lblFaturaNo = new System.Windows.Forms.Label();
            this.txtFaturaNo = new System.Windows.Forms.TextBox();
            this.lblFaturaTarihi = new System.Windows.Forms.Label();
            this.dtpFaturaTarihi = new System.Windows.Forms.DateTimePicker();
            this.lblMusteri = new System.Windows.Forms.Label();
            this.cmbMusteri = new System.Windows.Forms.ComboBox();
            this.lblVergiDairesi = new System.Windows.Forms.Label();
            this.txtVergiDairesi = new System.Windows.Forms.TextBox();
            this.lblVergiNo = new System.Windows.Forms.Label();
            this.txtVergiNo = new System.Windows.Forms.TextBox();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.mskdTxtTelefon = new System.Windows.Forms.MaskedTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblAraToplam = new System.Windows.Forms.Label();
            this.lblKdv = new System.Windows.Forms.Label();
            this.lblGenelToplam = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFaturaNo
            // 
            this.lblFaturaNo.AutoSize = true;
            this.lblFaturaNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFaturaNo.Location = new System.Drawing.Point(52, 56);
            this.lblFaturaNo.Name = "lblFaturaNo";
            this.lblFaturaNo.Size = new System.Drawing.Size(104, 25);
            this.lblFaturaNo.TabIndex = 0;
            this.lblFaturaNo.Text = "Fatura No:";
            // 
            // txtFaturaNo
            // 
            this.txtFaturaNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtFaturaNo.Location = new System.Drawing.Point(226, 51);
            this.txtFaturaNo.Name = "txtFaturaNo";
            this.txtFaturaNo.Size = new System.Drawing.Size(300, 30);
            this.txtFaturaNo.TabIndex = 1;
            // 
            // lblFaturaTarihi
            // 
            this.lblFaturaTarihi.AutoSize = true;
            this.lblFaturaTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFaturaTarihi.Location = new System.Drawing.Point(52, 96);
            this.lblFaturaTarihi.Name = "lblFaturaTarihi";
            this.lblFaturaTarihi.Size = new System.Drawing.Size(128, 25);
            this.lblFaturaTarihi.TabIndex = 2;
            this.lblFaturaTarihi.Text = "Fatura Tarihi:";
            // 
            // dtpFaturaTarihi
            // 
            this.dtpFaturaTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpFaturaTarihi.Location = new System.Drawing.Point(226, 91);
            this.dtpFaturaTarihi.Name = "dtpFaturaTarihi";
            this.dtpFaturaTarihi.Size = new System.Drawing.Size(300, 30);
            this.dtpFaturaTarihi.TabIndex = 3;
            // 
            // lblMusteri
            // 
            this.lblMusteri.AutoSize = true;
            this.lblMusteri.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMusteri.Location = new System.Drawing.Point(52, 136);
            this.lblMusteri.Name = "lblMusteri";
            this.lblMusteri.Size = new System.Drawing.Size(137, 25);
            this.lblMusteri.TabIndex = 4;
            this.lblMusteri.Text = "Müşteri/Firma:";
            // 
            // cmbMusteri
            // 
            this.cmbMusteri.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbMusteri.Items.AddRange(new object[] {
            "Marubeni",
            "Ülker"});
            this.cmbMusteri.Location = new System.Drawing.Point(226, 131);
            this.cmbMusteri.Name = "cmbMusteri";
            this.cmbMusteri.Size = new System.Drawing.Size(300, 33);
            this.cmbMusteri.TabIndex = 5;
            // 
            // lblVergiDairesi
            // 
            this.lblVergiDairesi.AutoSize = true;
            this.lblVergiDairesi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblVergiDairesi.Location = new System.Drawing.Point(52, 176);
            this.lblVergiDairesi.Name = "lblVergiDairesi";
            this.lblVergiDairesi.Size = new System.Drawing.Size(129, 25);
            this.lblVergiDairesi.TabIndex = 6;
            this.lblVergiDairesi.Text = "Vergi Dairesi:";
            // 
            // txtVergiDairesi
            // 
            this.txtVergiDairesi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtVergiDairesi.Location = new System.Drawing.Point(226, 171);
            this.txtVergiDairesi.Name = "txtVergiDairesi";
            this.txtVergiDairesi.Size = new System.Drawing.Size(300, 30);
            this.txtVergiDairesi.TabIndex = 7;
            // 
            // lblVergiNo
            // 
            this.lblVergiNo.AutoSize = true;
            this.lblVergiNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblVergiNo.Location = new System.Drawing.Point(52, 216);
            this.lblVergiNo.Name = "lblVergiNo";
            this.lblVergiNo.Size = new System.Drawing.Size(94, 25);
            this.lblVergiNo.TabIndex = 8;
            this.lblVergiNo.Text = "Vergi No:";
            // 
            // txtVergiNo
            // 
            this.txtVergiNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtVergiNo.Location = new System.Drawing.Point(226, 211);
            this.txtVergiNo.Name = "txtVergiNo";
            this.txtVergiNo.Size = new System.Drawing.Size(300, 30);
            this.txtVergiNo.TabIndex = 9;
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTelefon.Location = new System.Drawing.Point(52, 256);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(84, 25);
            this.lblTelefon.TabIndex = 10;
            this.lblTelefon.Text = "Telefon:";
            // 
            // mskdTxtTelefon
            // 
            this.mskdTxtTelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskdTxtTelefon.Location = new System.Drawing.Point(226, 251);
            this.mskdTxtTelefon.Mask = "(999) 000-0000";
            this.mskdTxtTelefon.Name = "mskdTxtTelefon";
            this.mskdTxtTelefon.Size = new System.Drawing.Size(300, 30);
            this.mskdTxtTelefon.TabIndex = 11;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeight = 29;
            this.dataGridView1.Location = new System.Drawing.Point(53, 318);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(677, 200);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            // 
            // lblAraToplam
            // 
            this.lblAraToplam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAraToplam.Location = new System.Drawing.Point(12, 9);
            this.lblAraToplam.Name = "lblAraToplam";
            this.lblAraToplam.Size = new System.Drawing.Size(100, 23);
            this.lblAraToplam.TabIndex = 13;
            // 
            // lblKdv
            // 
            this.lblKdv.Location = new System.Drawing.Point(0, 0);
            this.lblKdv.Name = "lblKdv";
            this.lblKdv.Size = new System.Drawing.Size(100, 23);
            this.lblKdv.TabIndex = 14;
            // 
            // lblGenelToplam
            // 
            this.lblGenelToplam.Location = new System.Drawing.Point(0, 0);
            this.lblGenelToplam.Name = "lblGenelToplam";
            this.lblGenelToplam.Size = new System.Drawing.Size(100, 23);
            this.lblGenelToplam.TabIndex = 15;
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.Location = new System.Drawing.Point(53, 538);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(101, 32);
            this.btnEkle.TabIndex = 16;
            this.btnEkle.Text = "Ürün Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.Location = new System.Drawing.Point(162, 538);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(167, 32);
            this.btnKaydet.TabIndex = 17;
            this.btnKaydet.Text = "Faturayı Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::YildizPansiyon.Properties.Resources.YildizPansiyon_Logo_Photoroom1;
            this.pictureBox1.Location = new System.Drawing.Point(730, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(273, 247);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // FaturaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(169)))), ((int)(((byte)(175)))));
            this.ClientSize = new System.Drawing.Size(1015, 602);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblFaturaNo);
            this.Controls.Add(this.txtFaturaNo);
            this.Controls.Add(this.lblFaturaTarihi);
            this.Controls.Add(this.dtpFaturaTarihi);
            this.Controls.Add(this.lblMusteri);
            this.Controls.Add(this.cmbMusteri);
            this.Controls.Add(this.lblVergiDairesi);
            this.Controls.Add(this.txtVergiDairesi);
            this.Controls.Add(this.lblVergiNo);
            this.Controls.Add(this.txtVergiNo);
            this.Controls.Add(this.lblTelefon);
            this.Controls.Add(this.mskdTxtTelefon);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblAraToplam);
            this.Controls.Add(this.lblKdv);
            this.Controls.Add(this.lblGenelToplam);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnKaydet);
            this.Name = "FaturaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fatura Formu";
            this.Load += new System.EventHandler(this.FaturaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblFaturaNo;
        private Label lblFaturaTarihi;
        private Label lblMusteri;
        private Label lblVergiDairesi;
        private Label lblVergiNo;
        private Label lblTelefon;
        private PictureBox pictureBox1;
    }
}