using System.ComponentModel;

namespace TemizlikApp
{
    public partial class Form1 : Form
    {
        BindingList<Ogrenci> SeciliOgrenciListesi = new();
        public Form1()
        {
            InitializeComponent();

            //ilk acili�ta verileri y�kler
            KayitYoneticisi.Yukle();

            cbSinif.DisplayMember = "Ad";
            cbSinif.ValueMember = "Id";
            cbSinif.DataSource = KayitYoneticisi.Siniflar;

            lbOgrenci.DisplayMember = "AdSoyad";
            lbOgrenci.ValueMember = "Id";
            lbOgrenci.DataSource = KayitYoneticisi.Ogrenciler;

            lbTemizlikS�ras�.DisplayMember = "AdSoyad";
            lbTemizlikS�ras�.ValueMember = "Id";
            lbTemizlikS�ras�.DataSource = SeciliOgrenciListesi;


        }

        private void btnYeniS�n�f_Click(object sender, EventArgs e)
        {
            FrmYeniS�n�f form = new();
            var cevap = form.ShowDialog();
            if (cevap == DialogResult.OK)
            {
                MessageBox.Show("Yeni S�n�f Eklendi!! :) ");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAtamaYap_Click(object sender, EventArgs e)
        {
            //Se�ili olan? �?renci gibi al (as=gibi)
            //Alamazsan null de?er ver
            Ogrenci ogr = lbOgrenci.SelectedItem as Ogrenci;

            if (ogr != null)
            {

                if (SeciliOgrenciListesi.Contains(ogr))
                {
                    MessageBox.Show("��renci zaten se�ili");
                    return;
                }

                SeciliOgrenciListesi.Add(ogr);
            }
        }

        private void btnC�kar_Click(object sender, EventArgs e)
        {
            //Se�ili olan? �?renci gibi al (as=gibi)
            //Alamazsan null de?er ver
            Ogrenci ogr = lbTemizlikS�ras�.SelectedItem as Ogrenci;

            if (ogr != null)
            {
                SeciliOgrenciListesi.Remove(ogr);
            }
        }

        private void btnOnayla_Click(object sender, EventArgs e)
        {
            if (SeciliOgrenciListesi.Count == 0)
            {
                MessageBox.Show("��renci se�imi yap�n�z");
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
            MessageBox.Show("Kay�t olu�turuldu");
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
                //S?n?f se�ili de?ilse
                lbOgrenci.DataSource = null;
                return;
            }

            //S?n?f se�ili
            string sinifId = cbSinif.SelectedValue.ToString()!;

            //LINQ ile sorgulama
            //Lambda x => x.....
            var liste = KayitYoneticisi.
                Ogrenciler.Where(x => x.SinifId == sinifId).ToList();

            lbOgrenci.DisplayMember = "AdSoyad";
            lbOgrenci.ValueMember = "Id";
            lbOgrenci.DataSource = liste;
        }

        private void cbS�n�f_SelectedValueChanged(object sender, EventArgs e)
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
                //S?n?f se�ili de?ilse
                lbOgrenci.DataSource = null;
                return;
            }

            //S?n?f se�ili
            string sinifId = cbSinif.SelectedValue.ToString();

            var liste = KayitYoneticisi.Ogrenciler
                .Where(x => x.SinifId == sinifId)
                .OrderBy(x => x.TemizlikPuani)
                .Take(2);
            lblBuHaftaSira.Text = "Bu haftaki S�ra:\n";

            if (liste.Count() == 0)
            {
                lblBuHaftaSira.Text += "Temizlik Yapacak Ki�i Yok";
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
                //s�n�f se�ili de�ilse
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
            lblTarih.Text = $"Bug�n {dt:dd} {dt:MMMM} {dt:yyyy} Saat : {dt:HH}:{dt:mm}";
        }
    }
}

