using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace VeriYapılarıProjem
{
    public partial class Form101 : Form
    {
        private FormOda101 formOda101;
        private Form102 form102;
        private Form103 form103;
        private Form104 form104;
        private Form105 form105;
        private Form106 form106;
        private Form107 form107;
        private Form108 form108;
        private Form109 form109;
        private Form110 form110;
        public List<string[]> listviewBilgilerKaydetme()
        //Girilen Müşteri Bilgilerini Oda Sayfalarına Aktarmak için Kaydettim.
        {
            List<string[]> bilgiler = new List<string[]>();

            foreach (ListViewItem item in listView1.Items)
            {
                string[] itemBilgiler = new string[item.SubItems.Count];
                for (int i = 0; i < item.SubItems.Count; i++)
                {
                    itemBilgiler[i] = item.SubItems[i].Text;
                }
                bilgiler.Add(itemBilgiler);
            }

            return bilgiler;
        }

        public Form101()
        {
            InitializeComponent();

            form102 = new Form102();

        }
        public void musterisayisi()
        //Müşteri Sayası Hesaplayan Metod.
        {
            int musterisayisi = listView1.Items.Count;
            label11.Text = Convert.ToString(musterisayisi);
        }
        private bool OdaDoluMu(string odaNo)
        {
            // Odaların kaç kişilik olduğunu gösterdik.
            int maxMusteri = 0;
            int musteriSayisi = 0;
            if (odaNo == "101")
            {
                maxMusteri = 1;
            }
            else if (odaNo == "102")
            {
                maxMusteri = 1;
            }
            else if (odaNo == "103")
            {
                maxMusteri = 1;
            }
            else if (odaNo == "104")
            {
                maxMusteri = 2;
            }
            else if (odaNo == "105")
            {
                maxMusteri = 2;
            }
            else if (odaNo == "106")
            {
                maxMusteri = 2;
            }
            else if (odaNo == "107")
            {
                maxMusteri = 2;
            }
            else if (odaNo == "108")
            {
                maxMusteri = 3;
            }
            else if (odaNo == "109")
            {
                maxMusteri = 3;
            }
            else if (odaNo == "110")
            {
                maxMusteri = 3;
            }
            //Odalardaki mevcut musteri sayısını kontrol et
            foreach (ListViewItem item in listView1.Items)
            {
                if (item.SubItems[5].Text == odaNo)
                {
                    musteriSayisi++;
                }
            }
            //Eğer mevcut musteri sayısı maximumdan azsa true dondur,aksı takdırde false dondur
            return musteriSayisi < maxMusteri;
        }

        public void ucrethesaplamasi()
        {
            //Ücretin Hesaplanması İçin Son Çıkış Tarihinden Geliş Tarihini Çıkardım Ve Günlük Ücret Olan 1000 TL İle Çarptım.
            DateTime gelis = Convert.ToDateTime(dateTimePicker1.Text);
            DateTime gidis = Convert.ToDateTime(dateTimePicker2.Text);
            TimeSpan ucret1 = (gidis - gelis) * 1000;
            label12.Text = ucret1.TotalDays.ToString() + " TL ";

        }

        public void odaSorgulama()
        //Odaların Boş Mu Dolu Mu Olduğunu Sorgulayan Ve Buna Renklerini Ayarlayan Metod.
        {
            button6.BackColor = Color.Lime;
            button16.BackColor = Color.Lime;
            button17.BackColor = Color.Lime;
            button15.BackColor = Color.Lime;
            button18.BackColor = Color.Lime;
            button9.BackColor = Color.Lime;
            button10.BackColor = Color.Lime;
            button7.BackColor = Color.Lime;
            button8.BackColor = Color.Lime;
            button12.BackColor = Color.Lime;
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                if (listView1.Items[i].SubItems[5].Text == "101")
                {
                    button6.BackColor = Color.Red;

                }
                else if (listView1.Items[i].SubItems[5].Text == "102")
                {
                    button16.BackColor = Color.Red;
                }
                else if (listView1.Items[i].SubItems[5].Text == "103")
                {
                    button17.BackColor = Color.Red;
                }
                else if (listView1.Items[i].SubItems[5].Text == "104")
                {
                    button15.BackColor = Color.Red;
                }
                else if (listView1.Items[i].SubItems[5].Text == "105")
                {
                    button18.BackColor = Color.Red;
                }
                else if (listView1.Items[i].SubItems[5].Text == "106")
                {
                    button9.BackColor = Color.Red;
                }
                else if (listView1.Items[i].SubItems[5].Text == "107")
                {
                    button10.BackColor = Color.Red;
                }
                else if (listView1.Items[i].SubItems[5].Text == "108")
                {
                    button7.BackColor = Color.Red;
                }
                else if (listView1.Items[i].SubItems[5].Text == "109")
                {
                    button8.BackColor = Color.Red;
                }
                else if (listView1.Items[i].SubItems[5].Text == "110")
                {
                    button12.BackColor = Color.Red;
                }


            }
        }
        public void Form101_Load(object sender, EventArgs e)
        //ListViewdeki Sütunları oluşturdum.
        {
            listView1.Columns.Add("ADI SOYADI", 180);
            listView1.Columns.Add("CİNSİYET", 80);
            listView1.Columns.Add("TELEFON", 120);
            listView1.Columns.Add("MAİL ADRESİ", 160);
            listView1.Columns.Add("T.C. KİMLİK NO", 120);
            listView1.Columns.Add("ODA NO", 90);
            listView1.Columns.Add("ÜCRET", 70);
            listView1.Columns.Add("GELİŞ TARİHİ", 180);
            listView1.Columns.Add("ÇIKIŞ TARİHİ", 180);
            string[] cinsiyet = { "ERKEK", "KADIN" };
            comboBox1.Items.AddRange(cinsiyet);

            musterisayisi();

            if (form102 == null)
            {
                form102 = new Form102();
            }
        }

        public void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        public void button1_Click(object sender, EventArgs e)
        {
            //TextBoxlara Girilen Değerleri Daha Önceden Boş Tanımladığım Değişkenlere Atadım.
            String adsoyad = "", tc = "", cinsiyet = "", telNo = "", mail = "", odaNo = "", gelTarih = "", cikTarih = "", ucrett = "";
            adsoyad = textBox2.Text; tc = textBox1.Text;
            telNo = textBox3.Text; mail = textBox5.Text;
            odaNo = textBox4.Text; gelTarih = dateTimePicker1.Text;
            cinsiyet = comboBox1.Text; cikTarih = dateTimePicker2.Text;

            //Ücretin Hesaplanması İçin Son Çıkış Tarihinden Geliş Tarihini Çıkardım Ve Günlük Ücret Olan 1000 TL İle Çarptım.
            DateTime gelis = Convert.ToDateTime(dateTimePicker1.Text);
            DateTime gidis = Convert.ToDateTime(dateTimePicker2.Text);
            TimeSpan ucret1 = (gidis - gelis) * 1000;
            label12.Text = ucret1.TotalDays.ToString() + " TL ";
            ucrett = label12.Text;

            //Müşteri Bİlgilerini Bu Dizide Kaydettim.
            string[] müsteribilgisi = { adsoyad, cinsiyet, telNo, mail, tc, odaNo, ucrett, gelTarih, cikTarih };

            // Daha Önceden Kayıt Yapılmış Mı Ve Eksik Bilgi Girilmiş Mi Sorguladım. Problem Yoksa Bilgileri Yazdırdım.
            bool kayıtsorgulama = false;
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                if (listView1.Items[i].SubItems[4].Text == textBox1.Text)
                {
                    kayıtsorgulama = true;
                    MessageBox.Show(textBox1.Text + " T.C. KİMLİK NOLU KİŞİ BU ODADA MEVCUTTUR.");
                }
            }
            if (kayıtsorgulama == false)
            {

                ListViewItem lst = new ListViewItem(müsteribilgisi);
                if (tc != " " && adsoyad != "" && cinsiyet != "" && telNo != "" &&
                    odaNo == "101" || odaNo == "102" || odaNo == "104" || odaNo == "103" ||
                    odaNo == "106" || odaNo == "105" || odaNo == "108" || odaNo == "107" ||
                    odaNo == "109" || odaNo == "110")
                {
                    //Odaların dolu olup olmadıgını kontrol et
                    if (textBox4.Text == "101" && OdaDoluMu("101") || textBox4.Text == "102" && OdaDoluMu("102") ||
                        textBox4.Text == "103" && OdaDoluMu("103") || textBox4.Text == "104" && OdaDoluMu("104") ||
                        textBox4.Text == "105" && OdaDoluMu("105") || textBox4.Text == "106" && OdaDoluMu("106") ||
                        textBox4.Text == "107" && OdaDoluMu("107") || textBox4.Text == "108" && OdaDoluMu("108") ||
                        textBox4.Text == "109" && OdaDoluMu("109") || textBox4.Text == "110" && OdaDoluMu("110"))
                    {
                        listView1.Items.Add(lst);
                        // TextBox'ları ve DateTimePicker'ları Temizledim.
                        textBox1.Text = "";
                        textBox2.Text = "";
                        textBox3.Text = "";
                        textBox4.Text = "";
                        textBox5.Text = "";
                        comboBox1.SelectedIndex = -1;
                        dateTimePicker1.Value = DateTime.Now;
                        dateTimePicker2.Value = DateTime.Now;
                        label12.Text = "0 TL";
                    }
                    //Odanın kapasitesi dolduysa ekrana dolu çıktısı verdirdim.
                    else if (textBox4.Text == "101" || textBox4.Text == "102" || textBox4.Text == "103" ||
                        textBox4.Text == "104" || textBox4.Text == "105" || textBox4.Text == "106" ||
                        textBox4.Text == "107" || textBox4.Text == "108" || textBox4.Text == "109" ||
                        textBox4.Text == "110")
                    {
                        MessageBox.Show("Seçilen oda dolu,başka bir oda seçiniz.");
                    }
                }
                else
                    MessageBox.Show("EKSİK YA DA HATALI BİLGİ GİRDİNİZ.");
            }
            odaSorgulama();
            musterisayisi();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //Form110 un bilgilerini açtım.
            List<string[]> data = listviewBilgilerKaydetme();
            List<string[]> filtrelenmisVeri = data.Where(item => item[5] == "110").ToList();

            if (form110 == null || form110.IsDisposed)
            {
                form110 = new Form110();
            }
            form110.listviewBilgilerGetirme(filtrelenmisVeri);
            form110.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Form 101in bilgilerini açtım.
            List<string[]> data = listviewBilgilerKaydetme();
            List<string[]> filtrelenmisVeri = data.Where(item => item[5] == "101").ToList();

            if (formOda101 == null || formOda101.IsDisposed)
            {
                formOda101 = new FormOda101();
            }
            formOda101.listviewBilgilerGetirme(filtrelenmisVeri);
            formOda101.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Kayıtlı olup seçilen müşterileri siler.
            int secilenmusterisaiyisi = listView1.CheckedItems.Count;
            foreach (ListViewItem secilebmusteribilgisi in listView1.CheckedItems)
            {
                secilebmusteribilgisi.Remove();

            }
            MessageBox.Show(secilenmusterisaiyisi.ToString() + " Tane Müşrenin Kaydı Silindi.");
            musterisayisi();
            odaSorgulama();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            odaSorgulama();
            musterisayisi();
        }

        private void button16_Click(object sender, EventArgs e)
        //102 Nolu Oda Bilgilerni Açtım.
        {
            List<string[]> data = listviewBilgilerKaydetme();
            List<string[]> filtrelenmisVeri = data.Where(item => item[5] == "102").ToList();

            if (form102 == null || form102.IsDisposed)
            {
                form102 = new Form102();
            }
            form102.listviewBilgilerGetirme(filtrelenmisVeri);
            form102.Show();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {
            List<string[]> data = listviewBilgilerKaydetme();
            List<string[]> filtrelenmisVeri = data.Where(item => item[5] == "105").ToList();

            if (form105 == null || form105.IsDisposed)
            {
                form105 = new Form105();
            }
            form105.listviewBilgilerGetirme(filtrelenmisVeri);
            form105.Show();

        }

        private void button17_Click(object sender, EventArgs e)
        {
            List<string[]> data = listviewBilgilerKaydetme();
            List<string[]> filtrelenmisVeri = data.Where(item => item[5] == "103").ToList();

            if (form103 == null || form103.IsDisposed)
            {
                form103 = new Form103();
            }
            form103.listviewBilgilerGetirme(filtrelenmisVeri);
            form103.Show();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            List<string[]> data = listviewBilgilerKaydetme();
            List<string[]> filtrelenmisVeri = data.Where(item => item[5] == "104").ToList();

            if (form104 == null || form104.IsDisposed)
            {
                form104 = new Form104();
            }
            form104.listviewBilgilerGetirme(filtrelenmisVeri);
            form104.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            List<string[]> data = listviewBilgilerKaydetme();
            List<string[]> filtrelenmisVeri = data.Where(item => item[5] == "106").ToList();

            if (form106 == null || form106.IsDisposed)
            {
                form106 = new Form106();
            }
            form106.listviewBilgilerGetirme(filtrelenmisVeri);
            form106.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            List<string[]> data = listviewBilgilerKaydetme();
            List<string[]> filtrelenmisVeri = data.Where(item => item[5] == "107").ToList();

            if (form107 == null || form107.IsDisposed)
            {
                form107 = new Form107();
            }
            form107.listviewBilgilerGetirme(filtrelenmisVeri);
            form107.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            List<string[]> data = listviewBilgilerKaydetme();
            List<string[]> filtrelenmisVeri = data.Where(item => item[5] == "108").ToList();

            if (form108 == null || form108.IsDisposed)
            {
                form108 = new Form108();
            }
            form108.listviewBilgilerGetirme(filtrelenmisVeri);
            form108.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            List<string[]> data = listviewBilgilerKaydetme();
            List<string[]> filtrelenmisVeri = data.Where(item => item[5] == "109").ToList();

            if (form109 == null || form109.IsDisposed)
            {
                form109 = new Form109();
            }
            form109.listviewBilgilerGetirme(filtrelenmisVeri);
            form109.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            MessageBox.Show("KIRMIZI RENKLİ ODALAR DOLUDUR.");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            MessageBox.Show("YEŞİL RENKLİ ODALAR BOŞTUR");
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            ucrethesaplamasi();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
