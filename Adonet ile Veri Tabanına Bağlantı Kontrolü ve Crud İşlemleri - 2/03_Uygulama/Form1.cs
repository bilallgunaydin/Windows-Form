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

namespace _03_Uygulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtCount_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select distinct ShipCountry from Orders";
            cmd.Connection = SqlHelper.cnn;

            try
            {
                SqlHelper.cnn.Open();
                SqlDataReader dataReader = cmd.ExecuteReader();
                if (dataReader.HasRows)  //dönen değer varmı diye kontrol ediyoruz
                {
                    while (dataReader.Read())   //okudugu surece dön
                    {
                        cmbCountry.Items.Add(dataReader[0].ToString());
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                SqlHelper.cnn.Close();
            }
        }

        private void cmbCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            string country = cmbCountry.SelectedItem.ToString();
            SqlCommand cmd = new SqlCommand();
            //cmd.CommandText = "select * from Orders where ShipCountry='" + country + "'";
            cmd.CommandText = string.Format("select count(OrderID) from Orders where ShipCountry='{0}'", country);
            cmd.Connection = SqlHelper.cnn;

            //buda aynı sey
            SqlCommand cmd2 = new SqlCommand
                (string.Format("select count(OrderID) from Orders where ShipCountry='{0}'", country), SqlHelper.cnn);


            SqlHelper.cnn.Open();
            object gelenDeger = cmd.ExecuteScalar();
            SqlHelper.cnn.Close();
            txtCount.Text = gelenDeger.ToString();
            
        }
    }
}
