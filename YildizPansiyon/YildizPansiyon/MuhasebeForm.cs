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
    public partial class MuhasebeForm : Form
    {
        public MuhasebeForm()
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

        private void BtnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnGelirGider_Click(object sender, EventArgs e)
        {
            GelirGiderForm frm = new GelirGiderForm();
            frm.Show();
        }

        private void BtnStoklar_Click(object sender, EventArgs e)
        {
            FaturaForm frm = new FaturaForm();
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

        private void MuhasebeForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
