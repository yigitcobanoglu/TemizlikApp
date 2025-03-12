namespace TemizlikApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //ilk acili�ta verileri y�kler
            KayitYoneticisi.Yukle();

            cbS�n�f.DisplayMember = "Ad";
            cbS�n�f.DataSource = KayitYoneticisi.Siniflar;

        }

        private void btnYeniS�n�f_Click(object sender, EventArgs e)
        {
            FrmYeniS�n�f form = new();
            var cevap = form.ShowDialog();
            if(cevap== DialogResult.OK)
            {
                MessageBox.Show("Yeni S�n�f Eklendi!! :) ");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
