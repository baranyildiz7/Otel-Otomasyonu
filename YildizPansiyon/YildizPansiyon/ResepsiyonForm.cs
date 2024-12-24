using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YildizPansiyon
{
    public partial class ResepsiyonForm : Form
    {
        public ResepsiyonForm()
        {
            InitializeComponent();
        }

        private void BtnAdminGiris_Click(object sender, EventArgs e)
        {
            AdminGirisForm form = new AdminGirisForm();
            form.Show();
            this.Hide();
        }

        private void BtnSifreGuncelle_Click(object sender, EventArgs e)
        {
            SifreGuncelleForm frm = new SifreGuncelleForm();
            frm.Show();
        }

        private void BtnYeniMusteri_Click(object sender, EventArgs e)
        {
            YeniMusteriForm form = new YeniMusteriForm();
            form.Show();
        }

        private void BtnOdalar_Click(object sender, EventArgs e)
        {
            OdalarForm form = new OdalarForm();
            form.Show();
        }

        private void BtnMusteriler_Click(object sender, EventArgs e)
        {
            MusterilerForm form = new MusterilerForm();
            form.Show();
        }

        private void BtnMusteriMesajlar_Click(object sender, EventArgs e)
        {
            MusteriMesajForm frm = new MusteriMesajForm();
            frm.Show();
        }

        private void BtnRadyoDinle_Click(object sender, EventArgs e)
        {
            RadyoDinleForm frm = new RadyoDinleForm();
            frm.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LblTarih.Text = DateTime.Now.ToLongDateString();
            LblSaat.Text = DateTime.Now.ToLongTimeString();
        }

        private void ResepsiyonForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void BtnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
