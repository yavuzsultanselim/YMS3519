using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_CreatinolSingleton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Singleton singleton = new Singleton();
            //Singleton db = Singleton.Sinif;

            //int sonuc=db.Topla(5, 10);
            //MessageBox.Show(sonuc.ToString());

            Singleton2 db = Singleton2.Instance;
            MessageBox.Show(db.Yaz("Merhaba"));

        }
    }
}
