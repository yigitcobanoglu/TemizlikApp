using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TemizlikApp
{
    public partial class OgrenciEkle : Form
    {
        public OgrenciEkle()
        {
            InitializeComponent();
            cbSinif.DisplayMember = "Ad";
            cbSinif.ValueMember = "Id";
            cbSinif.DataSource = KayitYoneticisi.Siniflar;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if(cbSinif.SelectedValue == null)
            {
                MessageBox.Show("Lütfen sınıf seçiniz.");
                return;
            }

            Ogrenci yeni = new();
            yeni.Id = Guid.NewGuid().ToString();
            yeni.Ad = txtAd.Text;
            yeni.Soyad = txtSoyAd.Text;
            yeni.Numara = Convert.ToInt32(mtxtNumara.Text);

            yeni.SinifId = cbSinif.SelectedValue.ToString();

            KayitYoneticisi.Ogrenciler.Add(yeni);
            KayitYoneticisi.Kaydet();
            DialogResult = DialogResult.OK;
        }

        private void cbSinif_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void OgrenciEkle_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
