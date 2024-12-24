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
    public partial class SatinAlmaForm : Form
    {
        public SatinAlmaForm()
        {
            InitializeComponent();
        }

        private void BtnAdminGiris_Click(object sender, EventArgs e)
        {
            AdminGirisForm form = new AdminGirisForm();
            form.Show();
            this.Hide();
        }

        private void BtnStoklar_Click(object sender, EventArgs e)
        {
            StokForm frm = new StokForm();
            frm.Show();
        }

        private void BtnRadyoDinle_Click(object sender, EventArgs e)
        {
            RadyoDinleForm frm = new RadyoDinleForm();
            frm.Show();
        }

        private void BtnSifreGuncelle_Click(object sender, EventArgs e)
        {
            SifreGuncelleForm frm = new SifreGuncelleForm();
            frm.Show();
        }

        private void BtnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LblTarih.Text = DateTime.Now.ToLongDateString();
            LblSaat.Text = DateTime.Now.ToLongTimeString();
        }

        private void SatinAlmaForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
