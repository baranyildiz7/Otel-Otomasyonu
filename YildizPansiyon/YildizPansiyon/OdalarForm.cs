using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YildizPansiyon
{
    public partial class OdalarForm : Form
    {
        public OdalarForm()
        {
            InitializeComponent();
        }

        YildizPansiyonEntities ype = new YildizPansiyonEntities();

        private void OdalarForm_Load(object sender, EventArgs e)
        {
            foreach (odalar oda in ype.odalar.ToList())
            {
                if (oda.odaNo == 101)
                {
                    if (oda.musteriID != null)
                    {
                        BtnOda101.BackColor = Color.Red;
                        BtnOda101.Enabled = false;
                        MusteriEkle musteri = ype.MusteriEkle.FirstOrDefault(x => x.musteriID == oda.musteriID);
                        BtnOda101.Text = musteri.musteriAdi + " " + musteri.musteriSoyadi;
                    }
                }
                else if (oda.odaNo == 102)
                {
                    if (oda.musteriID != null)
                    {
                        BtnOda102.BackColor = Color.Red;
                        BtnOda102.Enabled = false;
                        MusteriEkle musteri = ype.MusteriEkle.FirstOrDefault(x => x.musteriID == oda.musteriID);
                        BtnOda102.Text = musteri.musteriAdi + " " + musteri.musteriSoyadi;
                    }
                }
                else if (oda.odaNo == 103)
                {
                    if (oda.musteriID != null)
                    {
                        BtnOda103.BackColor = Color.Red;
                        BtnOda103.Enabled = false;
                        MusteriEkle musteri = ype.MusteriEkle.FirstOrDefault(x => x.musteriID == oda.musteriID);
                        BtnOda103.Text = musteri.musteriAdi + " " + musteri.musteriSoyadi;
                    }
                }
                else if (oda.odaNo == 104)
                {
                    if (oda.musteriID != null)
                    {
                        BtnOda104.BackColor = Color.Red;
                        BtnOda104.Enabled = false;
                        MusteriEkle musteri = ype.MusteriEkle.FirstOrDefault(x => x.musteriID == oda.musteriID);
                        BtnOda104.Text = musteri.musteriAdi + " " + musteri.musteriSoyadi;
                    }
                }
                else if (oda.odaNo == 105)
                {
                    if (oda.musteriID != null)
                    {
                        BtnOda105.BackColor = Color.Red;
                        BtnOda105.Enabled = false;
                        MusteriEkle musteri = ype.MusteriEkle.FirstOrDefault(x => x.musteriID == oda.musteriID);
                        BtnOda105.Text = musteri.musteriAdi + " " + musteri.musteriSoyadi;
                    }
                }
                else if (oda.odaNo == 106)
                {
                    if (oda.musteriID != null)
                    {
                        BtnOda106.BackColor = Color.Red;
                        BtnOda106.Enabled = false;
                        MusteriEkle musteri = ype.MusteriEkle.FirstOrDefault(x => x.musteriID == oda.musteriID);
                        BtnOda106.Text = musteri.musteriAdi + " " + musteri.musteriSoyadi;
                    }
                }
                else if (oda.odaNo == 107)
                {
                    if (oda.musteriID != null)
                    {
                        BtnOda107.BackColor = Color.Red;
                        BtnOda107.Enabled = false;
                        MusteriEkle musteri = ype.MusteriEkle.FirstOrDefault(x => x.musteriID == oda.musteriID);
                        BtnOda107.Text = musteri.musteriAdi + " " + musteri.musteriSoyadi;
                    }
                }
                else if (oda.odaNo == 108)
                {
                    if (oda.musteriID != null)
                    {
                        BtnOda108.BackColor = Color.Red;
                        BtnOda108.Enabled = false;
                        MusteriEkle musteri = ype.MusteriEkle.FirstOrDefault(x => x.musteriID == oda.musteriID);
                        BtnOda108.Text = musteri.musteriAdi + " " + musteri.musteriSoyadi;
                    }
                }
                else if (oda.odaNo == 109)
                {
                    if (oda.musteriID != null)
                    {
                        BtnOda109.BackColor = Color.Red;
                        BtnOda109.Enabled = false;
                        MusteriEkle musteri = ype.MusteriEkle.FirstOrDefault(x => x.musteriID == oda.musteriID);
                        BtnOda109.Text = musteri.musteriAdi + " " + musteri.musteriSoyadi;
                    }
                }

            }
        }

        private void BtnOda102_Click(object sender, EventArgs e)
        {

        }
    }
}
