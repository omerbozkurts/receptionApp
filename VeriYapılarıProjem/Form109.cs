using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VeriYapılarıProjem
{
    public partial class Form109 : Form
    {
        private Form109 form109;
        public Form109()
        {
            InitializeComponent();
        }
        public void listviewBilgilerGetirme(List<string[]> bilgiler)
        {
            foreach (var itemBilgiler in bilgiler)
            {
                ListViewItem item102bilgiler = new ListViewItem(itemBilgiler);
                listView1.Items.Add(item102bilgiler);
            }
        }

        private void Form109_Load(object sender, EventArgs e)
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
    }
}
