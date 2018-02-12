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
    public partial class Oyun : Form
    {
        public Oyun()
        {
            InitializeComponent();
        }
     
        
        private void Oyun_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle; btnStart.Enabled = true;
        }

        Random rnd = new Random();

        int show;
        void Rastgele()
        {
            show = rnd.Next(1, 4);
        }
        PictureBox pictureBox = new PictureBox();
        PictureBox pictureBox2 = new PictureBox();
        void ResimOlustur()
        {

            pictureBox.Size = new Size(98, 125);
            pictureBox.Location = new Point(430, 197);

            switch (show)
            {
                case 1:
                    pictureBox.ImageLocation = @"..\\..\\Resources\\kagit.png";
                    lblComputer.Text = "Kağıt";
                    break;
                case 2:
                    pictureBox.ImageLocation = @"..\\..\\Resources\\makas.png";
                    lblComputer.Text = "Makas";
                    break;
                case 3:
                    pictureBox.ImageLocation = @"..\\..\\Resources\\tas.png";
                    lblComputer.Text = "Taş";
                    break;
            }

            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Controls.Add(pictureBox);
        }

        private void btnPaper_Click(object sender, EventArgs e)
        {
            pictureBox2.Size = new Size(98, 125);
            pictureBox2.Location = new Point(12, 197);
            pictureBox2.ImageLocation = @"..\\..\\Resources\\kagit.png";
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Controls.Add(pictureBox2);
            lblPlayer.Text = "Kağıt";
            //EnableDisable(3);
        }

        private void btnScissors_Click(object sender, EventArgs e)
        {
            pictureBox2.Size = new Size(98, 125);
            pictureBox2.Location = new Point(12, 197);
            pictureBox2.ImageLocation = @"..\\..\\Resources\\makas.png";
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Controls.Add(pictureBox2);
            lblPlayer.Text = "Makas";
           // EnableDisable(2);
        }

        private void btnRock_Click(object sender, EventArgs e)
        {
            pictureBox2.Size = new Size(98, 125);
            pictureBox2.Location = new Point(12, 197);
            pictureBox2.ImageLocation = @"..\\..\\Resources\\tas.png";
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Controls.Add(pictureBox2);
            lblPlayer.Text = "Taş";
            //EnableDisable(1);
        }

        private void EnableDisable(int H)
        {
            if (H == 1)
            {
                btnPaper.Enabled = false;
                btnScissors.Enabled = false;
                btnStart.Enabled = true;
            }
            else if (H==2)
            {
                btnRock.Enabled = false;
                btnPaper.Enabled = false;
                btnStart.Enabled = true;
            }
            else if (H==3)
            {
                btnRock.Enabled = false;
                btnScissors.Enabled = false;
                btnStart.Enabled = true;
            }
        }
        
                
        private void btnStart_Click(object sender, EventArgs e)
        {
            if (btnPaper.Enabled == true || btnRock.Enabled == true
                || btnScissors.Enabled == true)
                Rastgele();
            ResimOlustur();
            if (lblPlayer.Text == "Taş" && lblComputer.Text == "Makas")
            {
                lblDurum.Text = "Taş makası kırar. Siz kazandınız.";
          
            }
            else if (lblPlayer.Text == "Taş" && lblComputer.Text == "Kağıt")
            {lblDurum.Text = "Kağıt taşı sarar. Bilgisayar kazandı";
            
            }

            else if (lblPlayer.Text == "Makas" && lblComputer.Text == "Taş")
            { lblDurum.Text = "Taş makası kırar. Bilgisayar kazandı.";
            
            }

            else if (lblPlayer.Text == "Makas" && lblComputer.Text == "Kağıt")
            {
                lblDurum.Text = "Makas kağıdı keser. Siz kazandınız.";
              
            }
            else if (lblPlayer.Text == "Kağıt" && lblComputer.Text == "Makas")
                lblDurum.Text = "Makas kağıdı keser. Bilgisayar kazandı.";
            else if (lblPlayer.Text == "Kağıt" && lblComputer.Text == "Taş")
            {
                lblDurum.Text = "Kağıt taşı sarar. Siz kazandınız.";
                
            }
            else
                lblDurum.Text = "Berabere bitti";
            btnRestart.Enabled = true;

        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            DialogResult again = new DialogResult();
            again = MessageBox.Show("Yeniden oynamak ister misiniz?", "Yeniden", MessageBoxButtons.YesNo);
            if (again == DialogResult.Yes)
                Application.Restart();
            else
                Application.Exit();
        }
    }
}
