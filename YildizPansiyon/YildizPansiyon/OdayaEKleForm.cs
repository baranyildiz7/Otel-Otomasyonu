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
    public partial class OdayaEKleForm : Form
    {
        public OdayaEKleForm()
        {
            InitializeComponent();
        }

        YildizPansiyonEntities ype = new YildizPansiyonEntities();
        

        private void OdayaEKleForm_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;

            dataGridView1.DataSource = ype.vw_MusteriList.ToList();
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            int musteriID = int.Parse(dataGridView1.SelectedCells[0].Value.ToString());
            int odaNo = Properties.Settings.Default.odaNo;

            odalar guncellenecekOda = ype.odalar.Where(x => x.odaNo == odaNo).FirstOrDefault();
            guncellenecekOda.musteriID = musteriID;

            MusteriEkle guncellenecekMusteri = ype.MusteriEkle.Where(x => x.musteriID == musteriID).FirstOrDefault();
            guncellenecekMusteri.odaID = guncellenecekOda.odaID;

            if (ype.SaveChanges() > 0)
            {
                MessageBox.Show("Müşteri Odaya Eklendi", "YILDIZ PANSIYON", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
