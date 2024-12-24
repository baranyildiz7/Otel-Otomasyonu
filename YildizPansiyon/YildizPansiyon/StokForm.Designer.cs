using System;
using System.Windows.Forms;

namespace YildizPansiyon
{
    partial class StokForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        // Form bileşenleri
        private TextBox txtUrunAdi;
        private ComboBox cmbKategori;
        private TextBox txtMiktar;
        private ComboBox cmbBirim;
        private TextBox txtMinStok;
        private TextBox txtTedarikci;
        private DateTimePicker dtpTedarikTarihi;
        private TextBox txtAciklama;
        private DataGridView dataGridView1;
        private Button btnEkle;
        private Button btnGuncelle;
        private Button btnSil;

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
            this.txtUrunAdi = new System.Windows.Forms.TextBox();
            this.cmbKategori = new System.Windows.Forms.ComboBox();
            this.txtMiktar = new System.Windows.Forms.TextBox();
            this.cmbBirim = new System.Windows.Forms.ComboBox();
            this.txtMinStok = new System.Windows.Forms.TextBox();
            this.txtTedarikci = new System.Windows.Forms.TextBox();
            this.dtpTedarikTarihi = new System.Windows.Forms.DateTimePicker();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.lblUrunAdi = new System.Windows.Forms.Label();
            this.lblKategori = new System.Windows.Forms.Label();
            this.lblMiktar = new System.Windows.Forms.Label();
            this.lblBirim = new System.Windows.Forms.Label();
            this.lblMinStok = new System.Windows.Forms.Label();
            this.lblTedarikci = new System.Windows.Forms.Label();
            this.lblTedarikTarihi = new System.Windows.Forms.Label();
            this.lblAciklama = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CmbID = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUrunAdi.Location = new System.Drawing.Point(156, 54);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Size = new System.Drawing.Size(200, 30);
            this.txtUrunAdi.TabIndex = 1;
            // 
            // cmbKategori
            // 
            this.cmbKategori.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbKategori.Items.AddRange(new object[] {
            "Temizlik",
            "Mutfak",
            "Tekstil",
            "Elektrik"});
            this.cmbKategori.Location = new System.Drawing.Point(156, 94);
            this.cmbKategori.Name = "cmbKategori";
            this.cmbKategori.Size = new System.Drawing.Size(121, 33);
            this.cmbKategori.TabIndex = 3;
            // 
            // txtMiktar
            // 
            this.txtMiktar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMiktar.Location = new System.Drawing.Point(156, 134);
            this.txtMiktar.Name = "txtMiktar";
            this.txtMiktar.Size = new System.Drawing.Size(100, 30);
            this.txtMiktar.TabIndex = 5;
            // 
            // cmbBirim
            // 
            this.cmbBirim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbBirim.Items.AddRange(new object[] {
            "Adet",
            "Litre",
            "Kilogram",
            "Koli"});
            this.cmbBirim.Location = new System.Drawing.Point(156, 174);
            this.cmbBirim.Name = "cmbBirim";
            this.cmbBirim.Size = new System.Drawing.Size(121, 33);
            this.cmbBirim.TabIndex = 7;
            // 
            // txtMinStok
            // 
            this.txtMinStok.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMinStok.Location = new System.Drawing.Point(156, 214);
            this.txtMinStok.Name = "txtMinStok";
            this.txtMinStok.Size = new System.Drawing.Size(100, 30);
            this.txtMinStok.TabIndex = 9;
            // 
            // txtTedarikci
            // 
            this.txtTedarikci.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTedarikci.Location = new System.Drawing.Point(156, 254);
            this.txtTedarikci.Name = "txtTedarikci";
            this.txtTedarikci.Size = new System.Drawing.Size(100, 30);
            this.txtTedarikci.TabIndex = 11;
            // 
            // dtpTedarikTarihi
            // 
            this.dtpTedarikTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpTedarikTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTedarikTarihi.Location = new System.Drawing.Point(156, 294);
            this.dtpTedarikTarihi.Name = "dtpTedarikTarihi";
            this.dtpTedarikTarihi.Size = new System.Drawing.Size(200, 30);
            this.dtpTedarikTarihi.TabIndex = 13;
            // 
            // txtAciklama
            // 
            this.txtAciklama.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAciklama.Location = new System.Drawing.Point(156, 334);
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(400, 30);
            this.txtAciklama.TabIndex = 15;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeight = 29;
            this.dataGridView1.Location = new System.Drawing.Point(48, 391);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(884, 246);
            this.dataGridView1.TabIndex = 16;
            // 
            // btnEkle
            // 
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.Location = new System.Drawing.Point(48, 655);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(131, 36);
            this.btnEkle.TabIndex = 17;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.Location = new System.Drawing.Point(206, 657);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(130, 32);
            this.btnGuncelle.TabIndex = 18;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Location = new System.Drawing.Point(360, 657);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(131, 32);
            this.btnSil.TabIndex = 19;
            this.btnSil.Text = "Sil";
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // lblUrunAdi
            // 
            this.lblUrunAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUrunAdi.Location = new System.Drawing.Point(50, 57);
            this.lblUrunAdi.Name = "lblUrunAdi";
            this.lblUrunAdi.Size = new System.Drawing.Size(100, 23);
            this.lblUrunAdi.TabIndex = 0;
            this.lblUrunAdi.Text = "Ürün Adı:";
            // 
            // lblKategori
            // 
            this.lblKategori.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKategori.Location = new System.Drawing.Point(50, 97);
            this.lblKategori.Name = "lblKategori";
            this.lblKategori.Size = new System.Drawing.Size(100, 33);
            this.lblKategori.TabIndex = 2;
            this.lblKategori.Text = "Kategori:";
            // 
            // lblMiktar
            // 
            this.lblMiktar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMiktar.Location = new System.Drawing.Point(50, 134);
            this.lblMiktar.Name = "lblMiktar";
            this.lblMiktar.Size = new System.Drawing.Size(100, 23);
            this.lblMiktar.TabIndex = 4;
            this.lblMiktar.Text = "Miktar:";
            // 
            // lblBirim
            // 
            this.lblBirim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBirim.Location = new System.Drawing.Point(50, 174);
            this.lblBirim.Name = "lblBirim";
            this.lblBirim.Size = new System.Drawing.Size(100, 23);
            this.lblBirim.TabIndex = 6;
            this.lblBirim.Text = "Birim:";
            // 
            // lblMinStok
            // 
            this.lblMinStok.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMinStok.Location = new System.Drawing.Point(50, 214);
            this.lblMinStok.Name = "lblMinStok";
            this.lblMinStok.Size = new System.Drawing.Size(100, 23);
            this.lblMinStok.TabIndex = 8;
            this.lblMinStok.Text = "Min Stok:";
            // 
            // lblTedarikci
            // 
            this.lblTedarikci.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTedarikci.Location = new System.Drawing.Point(50, 254);
            this.lblTedarikci.Name = "lblTedarikci";
            this.lblTedarikci.Size = new System.Drawing.Size(100, 23);
            this.lblTedarikci.TabIndex = 10;
            this.lblTedarikci.Text = "Tedarikçi:";
            // 
            // lblTedarikTarihi
            // 
            this.lblTedarikTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTedarikTarihi.Location = new System.Drawing.Point(50, 294);
            this.lblTedarikTarihi.Name = "lblTedarikTarihi";
            this.lblTedarikTarihi.Size = new System.Drawing.Size(100, 23);
            this.lblTedarikTarihi.TabIndex = 12;
            this.lblTedarikTarihi.Text = "Tedarik Tarihi:";
            // 
            // lblAciklama
            // 
            this.lblAciklama.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAciklama.Location = new System.Drawing.Point(50, 334);
            this.lblAciklama.Name = "lblAciklama";
            this.lblAciklama.Size = new System.Drawing.Size(102, 30);
            this.lblAciklama.TabIndex = 14;
            this.lblAciklama.Text = "Açıklama:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(50, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün ID:";
            // 
            // CmbID
            // 
            this.CmbID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CmbID.FormattingEnabled = true;
            this.CmbID.Location = new System.Drawing.Point(156, 12);
            this.CmbID.Name = "CmbID";
            this.CmbID.Size = new System.Drawing.Size(121, 33);
            this.CmbID.TabIndex = 20;
            // 
            // StokForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 726);
            this.Controls.Add(this.CmbID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblUrunAdi);
            this.Controls.Add(this.txtUrunAdi);
            this.Controls.Add(this.lblKategori);
            this.Controls.Add(this.cmbKategori);
            this.Controls.Add(this.lblMiktar);
            this.Controls.Add(this.txtMiktar);
            this.Controls.Add(this.lblBirim);
            this.Controls.Add(this.cmbBirim);
            this.Controls.Add(this.lblMinStok);
            this.Controls.Add(this.txtMinStok);
            this.Controls.Add(this.lblTedarikci);
            this.Controls.Add(this.txtTedarikci);
            this.Controls.Add(this.lblTedarikTarihi);
            this.Controls.Add(this.dtpTedarikTarihi);
            this.Controls.Add(this.lblAciklama);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Name = "StokForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stok Yönetim Formu";
            this.Load += new System.EventHandler(this.StokForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblUrunAdi;
        private Label lblKategori;
        private Label lblMiktar;
        private Label lblBirim;
        private Label lblMinStok;
        private Label lblTedarikci;
        private Label lblTedarikTarihi;
        private Label lblAciklama;
        private Label label1;
        private ComboBox CmbID;
    }
}