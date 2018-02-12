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

namespace _01_View
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
      
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select CategoryName,CategorySales from [Category Sales for 1997]";
            cmd.Connection = SqlHelper.cnn;

            SqlHelper.cnn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
           

                while (reader.Read())
                {
                    ListViewItem li = new ListViewItem();
                li.Text = reader[0].ToString();
                li.SubItems.Add(reader[1].ToString());

                lv1.Items.Add(li);
                }
            
        }
    }
}
