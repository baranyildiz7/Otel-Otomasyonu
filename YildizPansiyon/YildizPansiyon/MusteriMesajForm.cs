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
    public partial class MusteriMesajForm : Form
    {
        public MusteriMesajForm()
        {
            InitializeComponent();
        }

        YildizPansiyonEntities ype = new YildizPansiyonEntities();

        private void Listele()
        {
            dataGridView1.Refresh();
            dataGridView1.DataSource = ype.vw_MesajList.ToList();
        }

        private void MusteriMesajForm_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;

            Listele();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            musteriMesaj yeniMesaj = new musteriMesaj();

            yeniMesaj.ad = TxtAd.Text;
            yeniMesaj.soyad = TxtSoyad.Text;
            yeniMesaj.mesaj = RichTxtMesaj.Text;

            ype.musteriMesaj.Add(yeniMesaj);

            if(ype.SaveChanges() == 1)
            {
                MessageBox.Show("Başarıyla Kaydedildi", "YILDIZ PANSIYON", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            Listele();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtAd.Text = dataGridView1.CurrentRow.Cells["Ad"].Value.ToString();
            TxtSoyad.Text = dataGridView1.CurrentRow.Cells["Soyad"].Value.ToString();
            RichTxtMesaj.Text = dataGridView1.CurrentRow.Cells["Mesaj"].Value.ToString();
        }
    }
}
