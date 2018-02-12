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

namespace _02_StoreProcedure
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /*
                SQL E BUNU EKLEDIKTEN SONRA
                ---------------------------
         
                create proc sp_AddEmployee
                (
	                @firstName varchar(20),
	                @lastName varchar(20)
                )
                as
                begin
	                insert into Employees(FirstName, LastName) values (@firstName, @lastName)
	                select EmployeeID from Employees where EmployeeID=(select SCOPE_IDENTITY())
                end
         
         */


        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = SqlHelper.cnn;

            cmd.CommandText = "sp_AddEmployee";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@firstName",txtFirstName.Text);
            cmd.Parameters.AddWithValue("@lastName",txtLastName.Text);

            SqlHelper.cnn.Open();
            object sonuc = cmd.ExecuteScalar();
            SqlHelper.cnn.Close();
            MessageBox.Show("Çalışan eklendi!");
            lblSonuc.Text = sonuc.ToString();
        }
    }
}
