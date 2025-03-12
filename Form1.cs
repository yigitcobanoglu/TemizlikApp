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
            if(cevap== DialogResult.OK)
            {
                MessageBox.Show("Yeni Sýnýf Eklendi!! :) ");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
