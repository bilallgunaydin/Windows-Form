using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_Uygulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //SQL Server Authentication
        //SqlConnection cnn = new SqlConnection("server=.;database=Northwind;User ID = brcngn;password=1234;");

        //Windows Authentication
        SqlConnection cnn = new SqlConnection("server=.;database=Northwind;Integrated Security=true;");


        //Server => Data Source
        //User ID => uid
        //Password => pwd

      
        private void Form1_Load(object sender, EventArgs e)
        {

            BaglantiAcKapa();
            
        }

        private void BaglantiAcKapa()
        {
            try
            {
                if (cnn.State == System.Data.ConnectionState.Closed)
                {
                    cnn.Open();
                    label1.Text = "Açık";
                    label1.BackColor = System.Drawing.Color.Blue;
                    label1.ForeColor = System.Drawing.Color.White;
                }
                else
                {
                    cnn.Close();
                    label1.Text = "Kapalı";
                    label1.BackColor = System.Drawing.Color.Red;
                    label1.ForeColor = System.Drawing.Color.White;
                }
            }
            catch (Exception)
            {

                throw;
            }
           
        }

        private void btnBaglantı_Click(object sender, EventArgs e)
        {
            BaglantiAcKapa();
        }
    }
}
