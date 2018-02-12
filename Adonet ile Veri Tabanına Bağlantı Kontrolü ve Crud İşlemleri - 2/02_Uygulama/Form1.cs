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
            //1. Yöntem => SqlHelper da SqlConnection instance'ını olusturup direk classdan uygulamaya bağlantı sağlama
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select EmployeeID, FirstName, LastName, BirthDate, City from Employees";
            cmd.Connection = SqlHelper.Connection;
            try
            {
                SqlHelper.Connection.Open();
                SqlDataReader dataReader = cmd.ExecuteReader();  //sorguyu calıstır değeri dataReader e at.
                if (dataReader.HasRows) //dönen değer varsa
                {
                    while (dataReader.Read()) //satırları okuyabildigi surece
                    {
                        //ListBox a Eklerken
                        string fullName = dataReader[1].ToString() + " " + dataReader[2].ToString();
                        lstEmployees.Items.Add(fullName);


                        //ListView a Eklerken
                        ListViewItem li = new ListViewItem();
                        li.Text = dataReader[0].ToString();
                        li.SubItems.Add(dataReader[1].ToString());
                        li.SubItems.Add(dataReader[2].ToString());
                        //li.SubItems.Add(((DateTime)(dataReader[3])).ToShortDateString());
                        li.SubItems.Add(DateTime.Parse(dataReader[3].ToString()).ToShortDateString());
                        li.SubItems.Add(dataReader[4].ToString());

                        lvEmployees.Items.Add(li);

                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                SqlHelper.Connection.Close();
            }
        }
    }
}
