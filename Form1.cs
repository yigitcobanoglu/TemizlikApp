namespace TemizlikApp
{
    public partial class Form1 : Form
    {
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
            foreach (var secilen in lbOgrenci.SelectedItems)
            {
                if (lbTemizlikSýrasý.Items.Contains(secilen))
                {
                    lbTemizlikSýrasý.Items.Add(secilen);
                }
            }
        }

        private void btnCýkar_Click(object sender, EventArgs e)
        {
            while (lbTemizlikSýrasý.SelectedItems.Count > 0)
            {
                lbTemizlikSýrasý.Items.Remove(lbTemizlikSýrasý.SelectedItems);
            }
        }

        private void btnOnayla_Click(object sender, EventArgs e)
        {
            if (lbTemizlikSýrasý.Items.Count == 0)
            {
                MessageBox.Show("Temizlik sýrasý için en az bir öðrenci seçmelisiniz.");
                return;
            }

            string mesaj = "bu hafta temizlik yapacak öðrenciler: \n";
            foreach (var ogrenci in lbTemizlikSýrasý.Items)
            {
                mesaj += $"-{ogrenci}\n";
            }

            MessageBox.Show(mesaj, "Onaylandý");
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
        }

        private void cbSinif_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbOgrenci_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }
    }
}

