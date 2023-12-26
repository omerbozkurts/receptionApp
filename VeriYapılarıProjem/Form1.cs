namespace VeriYapılarıProjem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //Giriş ekranındaki kullanıcıadi ve şifreyi kontrol ettirdim.
            string kul_adi = "admin";
            string sifre1 = "123456";
            if (TxtKullaniciAdi.Text == kul_adi && TxtSifre.Text == sifre1)
            {
                Form101 yeniForm = new Form101();
                yeniForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre yanlış");
            }
        }

        private void kullaniciAdi_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void TxtSifre_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TxtKullaniciAdi_TextChanged(object sender, EventArgs e)
        {

        }
    }
}