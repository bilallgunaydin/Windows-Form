using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _160824_TasKagıtMakasOyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "Taş - Kağıt - Makas karşılaştırma oyununa hoşgeldiniz. \n Oyuna girmek için giriş tuşuna basınız.";
            
            //Uygulama açıldığında kullanıcının formu küçültmesini veya büyütmesini engellemek için yazdığım kod.
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Oyun oyun = new Oyun();
            oyun.Show();
            Hide();
        }
    }
}
