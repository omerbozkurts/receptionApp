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

    public partial class Form102 : Form
    {
        private Form102 form102;

        public void listviewBilgilerGetirme(List<string[]> bilgiler)
        {
            foreach (var itemBilgiler in bilgiler)
            {
                ListViewItem item102bilgiler = new ListViewItem(itemBilgiler);
                listView1.Items.Add(item102bilgiler);
            }
        }

        public Form102()
        {
            InitializeComponent();

        }

        private void Form102_Load(object sender, EventArgs e)
        {

            Form101 form101 = new Form101();
            List<string[]> data = form101.listviewBilgilerKaydetme();
            listviewBilgilerGetirme(data);
            listView1.Columns.Add("ADI SOYADI", 180);
            listView1.Columns.Add("CİNSİYET", 80);
            listView1.Columns.Add("TELEFON", 120);
            listView1.Columns.Add("MAİL ADRESİ", 160);
            listView1.Columns.Add("T.C. KİMLİK NO", 120);
            listView1.Columns.Add("ODA NO", 90);
            listView1.Columns.Add("ÜCRET", 70);
            listView1.Columns.Add("GELİŞ TARİHİ", 180);
            listView1.Columns.Add("ÇIKIŞ TARİHİ", 180);

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
