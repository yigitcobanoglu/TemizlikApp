using System.ComponentModel;

namespace TemizlikApp
{
    public partial class Form1 : Form
    {
        BindingList<Ogrenci> SeciliOgrenciListesi = new();
        public Form1()
        {
            InitializeComponent();

            //ilk aciliþta verileri yükler
            KayitYoneticisi.Yukle();

            cbSinif.DisplayMember = "Ad";
            cbSinif.ValueMember = "Id";
            cbSinif.DataSource = KayitYoneticisi.Siniflar;

            lbOgrenci.DisplayMember = "AdSoyad";
            lbOgrenci.ValueMember = "Id";
            lbOgrenci.DataSource = KayitYoneticisi.Ogrenciler;

            lbTemizlikSýrasý.DisplayMember = "AdSoyad";
            lbTemizlikSýrasý.ValueMember = "Id";
            lbTemizlikSýrasý.DataSource = SeciliOgrenciListesi;


        }

        private void btnYeniSýnýf_Click(object sender, EventArgs e)
        {
            FrmYeniSýnýf form = new();
            var cevap = form.ShowDialog();
            if (cevap == DialogResult.OK)
            {
                MessageBox.Show("Yeni Sýnýf Eklendi!! :) ");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAtamaYap_Click(object sender, EventArgs e)
        {
            //Seçili olan? ö?renci gibi al (as=gibi)
            //Alamazsan null de?er ver
            Ogrenci ogr = lbOgrenci.SelectedItem as Ogrenci;

            if (ogr != null)
            {

                if (SeciliOgrenciListesi.Contains(ogr))
                {
                    MessageBox.Show("Öðrenci zaten seçili");
                    return;
                }

                SeciliOgrenciListesi.Add(ogr);
            }
        }

        private void btnCýkar_Click(object sender, EventArgs e)
        {
            //Seçili olan? ö?renci gibi al (as=gibi)
            //Alamazsan null de?er ver
            Ogrenci ogr = lbTemizlikSýrasý.SelectedItem as Ogrenci;

            if (ogr != null)
            {
                SeciliOgrenciListesi.Remove(ogr);
            }
        }

        private void btnOnayla_Click(object sender, EventArgs e)
        {
            if (SeciliOgrenciListesi.Count == 0)
            {
                MessageBox.Show("Öðrenci seçimi yapýnýz");
                return;
            }

            //Temizlik kayd? olu?tur
            foreach (Ogrenci ogr in SeciliOgrenciListesi)
            {
                TemizlikKaydi kayit = new();
                kayit.Id = Guid.NewGuid().ToString();
                kayit.OgrenciId = ogr.Id;
                kayit.Tarih = dtptarih.Value;

                KayitYoneticisi.TemizlikKayitlari.Add(kayit);
            }

            SeciliOgrenciListesi.Clear();

            KayitYoneticisi.Kaydet();
            Filtrele();
            BuHaftaTemizlikYapacaklar();
            MessageBox.Show("Kayýt oluþturuldu");
        }

        private void btnOgrenciEkle_Click(object sender, EventArgs e)
        {
            OgrenciEkle form = new();
            var cevap = form.ShowDialog();
            if (cevap == DialogResult.OK)
            {
                Filtrele();
            }
        }
        private void Filtrele()
        {
            if (cbSinif.SelectedValue == null)
            {
                //S?n?f seçili de?ilse
                lbOgrenci.DataSource = null;
                return;
            }

            //S?n?f seçili
            string sinifId = cbSinif.SelectedValue.ToString()!;

            //LINQ ile sorgulama
            //Lambda x => x.....
            var liste = KayitYoneticisi.
                Ogrenciler.Where(x => x.SinifId == sinifId).ToList();

            lbOgrenci.DisplayMember = "AdSoyad";
            lbOgrenci.ValueMember = "Id";
            lbOgrenci.DataSource = liste;
        }

        private void cbSýnýf_SelectedValueChanged(object sender, EventArgs e)
        {
            Filtrele();
            BuHaftaTemizlikYapacaklar();
        }

        private void cbSinif_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbOgrenci_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        void BuHaftaTemizlikYapacaklar()
        {
            if (cbSinif.SelectedValue == null)
            {
                //S?n?f seçili de?ilse
                lbOgrenci.DataSource = null;
                return;
            }

            //S?n?f seçili
            string sinifId = cbSinif.SelectedValue.ToString();

            var liste = KayitYoneticisi.Ogrenciler
                .Where(x => x.SinifId == sinifId)
                .OrderBy(x => x.TemizlikPuani)
                .Take(2);
            lblBuHaftaSira.Text = "Bu haftaki Sýra:\n";

            if (liste.Count() == 0)
            {
                lblBuHaftaSira.Text += "Temizlik Yapacak Kiþi Yok";
            }

            foreach (Ogrenci ogr in liste)
            {
                lblBuHaftaSira.Text += $"{ogr.AdSoyad}\n";
            }
        }

        private void btnSec_Click(object sender, EventArgs e)
        {
            if (cbSinif.SelectedValue == null)
            {
                //sýnýf seçili deðilse
                lbOgrenci.DataSource = null;
                return;
            }
            string sinifId = cbSinif.SelectedValue.ToString()!;

            var liste = KayitYoneticisi.Ogrenciler
                .Where(x => x.SinifId == sinifId)
                .OrderBy(x => x.TemizlikPuani)
                .Take(2);
            foreach (Ogrenci ogr in liste)
            {
                if (!SeciliOgrenciListesi.Contains(ogr))
                    SeciliOgrenciListesi.Add(ogr);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            lblTarih.Text = $"Bugün {dt:dd} {dt:MMMM} {dt:yyyy} Saat : {dt:HH}:{dt:mm}";
        }
    }
}

