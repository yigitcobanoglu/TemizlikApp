namespace TemizlikApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //ilk aciliþta verileri yükler
            KayitYoneticisi.Yukle();

            cbSýnýf.DisplayMember = "Ad";
            cbSýnýf.DataSource = KayitYoneticisi.Siniflar;

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
                MessageBox.Show("Yeni Ogrenci Eklendi!! :) ");

            }
        }
    }
}
