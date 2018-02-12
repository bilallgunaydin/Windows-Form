using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace _160906_HafızaOyunu
{
    public partial class Form1 : Form
    {

        List<oyuncuKayıt> oyuncuKayıtlar = new List<oyuncuKayıt>();
        public Form1()
        {
            InitializeComponent();
        }


        int sure = 123;
        
        public string OyuncuGlobal;

        DialogResult DRs = new DialogResult();
        Random rnd = new Random();
        int rand = 101;
        int rand2 = 101;
        int rand3 = 101;
        int rand4 = 101;
        int rand5 = 101;

        
        

        Button button;
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Stop();
            timer3.Stop();


            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    button = new Button();

                    button.Name = "btn" + ((10 * i) + j);
                    button.Text = "";
                    button.Size = new Size(45, 45);
                    button.Location = new Point(20 + (45 * i), 10 + (45 * j));
                    button.BackColor = Control.DefaultBackColor;
                    button.Click += button_Click;

                    this.Controls.Add(button);

                    
                }
            }
        }
        int kalanHak = 5;
        int puan = 0;
        int yesil = 0;
        void button_Click(object sender, EventArgs e)
        {
            if (kalanHak != 0)
            {
                Button btn = (Button)sender;
                if (btn.Name == "btn" + rand ||
                    btn.Name == "btn" + rand2 ||
                    btn.Name == "btn" + rand3 ||
                    btn.Name == "btn" + rand4 ||
                    btn.Name == "btn" + rand5)
                {
                    btn.BackColor = Color.Green;
                    puan = puan + 10;
                    yesil = yesil + 1;
                    lblPuan.Text = "Puan : " + puan.ToString();

                    btn.Enabled = false;

                    if (yesil == 5)
                    {
                        MessageBox.Show("Tebrikler. Oyun bitti\nPuanınız : " + puan.ToString());

                        foreach (object item in this.Controls)
                        {
                            if (item is Button)
                            {
                                Button btn1 = (Button)item;

                                btn1.Enabled = true;
                            }
                        }

                        FormGiris girisEkrani = new FormGiris();

                        oyuncuKayıt oynK = new oyuncuKayıt();
                        oynK.OyuncuAdı = OyuncuGlobal;
                        oynK.skor = puan.ToString();
                        ListViewItem oyuncuSkor = new ListViewItem();
                        oyuncuSkor.Text = oynK.OyuncuAdı;
                        oyuncuSkor.SubItems.Add(oynK.skor);
                        girisEkrani.lvOyuncuSkor.Items.Add(oyuncuSkor);
                        oyuncuKayıtlar.Add(oynK);

                      
                        
                        FileStream dosyaAkısı = File.Create("Puanlar.xml");
                        XmlSerializer xmlKaydet = new XmlSerializer(typeof(List<oyuncuKayıt>));
                        xmlKaydet.Serialize(dosyaAkısı, oyuncuKayıtlar);
                        dosyaAkısı.Close();
                        this.Hide();
                        girisEkrani.Show();
                    }







                }
                else
                {
                    btn.BackColor = Color.Red;
                    kalanHak = kalanHak - 1;
                    btn.Enabled = false;

                }
            }
            else
            {
                DRs = MessageBox.Show("oyun bitti. Puanınız: "+puan.ToString() + "\nBidaha ?","Uyarı",MessageBoxButtons.YesNo);
                if (DRs == DialogResult.Yes)
                {
                    Application.Restart();
                }
                else
                {
                    Application.Exit();
                }
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            
            rand = rnd.Next(0, 100);

            rand2 = rnd.Next(0, 100);
            if (rand2 == rand)
            {
                rand2 = rnd.Next(0, 100);
                return;
            }

            rand3 = rnd.Next(0, 100);
            if (rand3 == rand || rand3 == rand2)
            {
                rand3 = rnd.Next(0, 100);
                return;
            }

            rand4 = rnd.Next(0, 100);
            if (rand4 == rand || rand4 == rand2 || rand4 == rand3)
            {
                rand4 = rnd.Next(0, 100);
                return;
            }

            rand5 = rnd.Next(0, 100);
            if (rand5 == rand || rand5 == rand2 || rand5 == rand3 || rand5 == rand4)
            {
                rand5 = rnd.Next(0, 100);
                return;
            }

  

            timer2.Stop();
        }
        
        int renkMod = 1;
        int kacKez = 5;
        private void timer1_Tick(object sender, EventArgs e)
        {
            
                if (kacKez >= 0)
                {
                    if (renkMod % 2 == 1)
                    {
                        foreach (object item in this.Controls)
                        {
                            if (item is Button)
                            {
                                Button btn = (Button)item;
                                if (btn.Name == "btn" + rand.ToString() ||
                                    btn.Name == "btn" + rand2.ToString() ||
                                    btn.Name == "btn" + rand3.ToString() ||
                                    btn.Name == "btn" + rand4.ToString() ||
                                    btn.Name == "btn" + rand5.ToString())
                                {
                                    btn.BackColor = Color.Gray;
                                }
                            }
                        }
                        renkMod = 0;
                    }
                    else
                    {
                        foreach (object item in this.Controls)
                        {
                            if (item is Button)
                            {
                                Button btn = (Button)item;
                                if (btn.Name == "btn" + rand.ToString() ||
                                btn.Name == "btn" + rand2.ToString() ||
                                btn.Name == "btn" + rand3.ToString() ||
                                btn.Name == "btn" + rand4.ToString() ||
                                btn.Name == "btn" + rand5.ToString())
                                {
                                    btn.BackColor = Control.DefaultBackColor;
                                }
                            }
                        }
                        renkMod = 1;
                    }
                    kacKez = kacKez - 1;
                }  
        }

        private void rbtnKolay_CheckedChanged(object sender, EventArgs e)
        {

            timer1.Interval = 1000;
            sure = 100;
            timer1.Start();
            timer2.Start();
            timer3.Start();
        }

        private void rbtnOrta_CheckedChanged(object sender, EventArgs e)
        {
            timer1.Interval = 500;
            sure = 60;
            timer1.Start();
            timer2.Start();
            timer3.Start();

        }

        private void rbtnZor_CheckedChanged(object sender, EventArgs e)
        {
            timer1.Interval = 100;
            sure = 30;
            timer1.Start();
            timer2.Start();
            timer3.Start();
            
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
          
            sure = sure - 1;
            lblSure.Text = "Süre : " + sure.ToString();

            if (sure == 0)
            {
                timer3.Stop();
                timer1.Stop();
                timer2.Stop();
                DRs = MessageBox.Show("Süreniz bitti. Puanınız: " + puan.ToString() + "\nBidaha ?", "Uyarı", MessageBoxButtons.YesNo);
                if (DRs == DialogResult.Yes)
                {
                    Application.Restart();
                }
                else
                {
                    Application.Exit();
                }
                
            }
        }

 

    }
}
