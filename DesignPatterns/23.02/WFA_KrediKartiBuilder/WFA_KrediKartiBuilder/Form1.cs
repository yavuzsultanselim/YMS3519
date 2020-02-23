using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_KrediKartiBuilder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        KrediKartiBuilder krediKart;
        private void button1_Click(object sender, EventArgs e)
        {
            switch (comboBox1.Text)
            {
                case "Visa":
                    krediKart = new VisaconcreteBuilder();
                    break;
            }

            KartKullan kullan = new KartKullan();
            string kartTip = comboBox1.Text;
            kullan.KartiKullan(krediKart, textBox1.Text, kartTip, Convert.ToDecimal(textBox2.Text), radioButton1.Checked);

            ListDoldur();
        }

        public void ListDoldur()
        {
            ListViewItem list = new ListViewItem();
            list.Text = krediKart.Kart.BankaAdi;
            list.SubItems.Add(krediKart.Kart.KartTip);
            list.SubItems.Add(krediKart.Kart.KartLimiti.ToString());
            list.SubItems.Add(krediKart.Kart.TaksitImkani.ToString());
            listView1.Items.Add(list);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        
        }
    }
}
