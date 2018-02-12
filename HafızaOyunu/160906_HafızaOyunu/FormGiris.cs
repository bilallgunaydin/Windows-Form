using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace _160906_HafızaOyunu
{
    public partial class FormGiris : Form
    {
      Form1 form1 = new Form1();
        public FormGiris()
        {
            InitializeComponent();
        }

        private void btnBasla_Click(object sender, EventArgs e)
        {
            if (!(txtOyuncuAdı.Text.Length > 0))
            {
                MessageBox.Show("İsim Giriniz ");
                return;
            }

            form1.OyuncuGlobal = txtOyuncuAdı.Text;
              

            this.Hide();
            form1.Show();
        }

        private void FormGiris_Load(object sender, EventArgs e)
        {

        }
    }
}
