using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_Uygulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Tavuk tvk = new Tavuk();
            tvk.Tur = "Habeş Tavuğu";
            tvk.GagaBoyu = 3;
            tvk.Renk = "Kırmızı";
            MessageBox.Show(tvk.Yumurtla());

            Marti mrt = new Marti();
            MessageBox.Show(mrt.Yuz());


            IUcabilir i;             // bunu implement ettigimiz butun classların instance ı bu şekilde cekilebilir.
            i = new Karga();
            i = new Marti();
            //i = new Tavuk();   // bu interface'i almadıgı icin alamaz.

            Daire daire = new Daire();
            daire.Cap = 12;
            MessageBox.Show(daire.AlanHesapla().ToString());
            
        }
    }
}