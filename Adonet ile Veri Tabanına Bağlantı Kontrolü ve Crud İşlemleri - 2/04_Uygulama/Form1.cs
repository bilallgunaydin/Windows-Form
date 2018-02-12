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

namespace _04_Uygulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int id;
        private void Form1_Load(object sender, EventArgs e)
        {
            Yenile();
        }

        private void Yenile()
        {

            lvCategories.Items.Clear();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select CategoryID, CategoryName, Description from Categories";
            cmd.Connection = SqlHelper.cnn;
            try
            {
                SqlHelper.cnn.Open();
                SqlDataReader dataReader = cmd.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        Category cat = new Category();
                        //Data Maping
                        cat.CategoryID = (int)dataReader[0];
                        cat.CategoryName = (string)dataReader[1];
                        cat.Description = (string)dataReader[2];

                        //ListView a eklemek için
                        ListViewItem li = new ListViewItem();
                        li.Tag = cat;
                        li.Text = cat.CategoryID.ToString();
                        li.SubItems.Add(cat.CategoryName);
                        li.SubItems.Add(cat.Description);

                        lvCategories.Items.Add(li);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cmd.Connection.Close();
                //SqlHelper.cnn.Close();              //  <-- Buda aynı şey
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Category cat = (Category)lvCategories.SelectedItems[0].Tag;
            txtName.Text = cat.CategoryName;
            txtDesc.Text = cat.Description;
            id = cat.CategoryID;          
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = string.Format("update Categories set CategoryName='{0}', Description='{1}' where CategoryID={2}",txtName.Text, txtDesc.Text,id);
            cmd.Connection = SqlHelper.cnn;
            try
            {              
                cmd.Connection.Open();               
                //SqlHelper.cnn.Open();
                int gelenDeger = cmd.ExecuteNonQuery();
                if (gelenDeger > 0)
                {
                    MessageBox.Show("Güncelleme işlemi Başarılı");
                }
                else
                {
                    MessageBox.Show("Güncelleme gerçekleştirilemedi!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cmd.Connection.Close();
                Yenile();
            }      
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Category cat = (Category)lvCategories.SelectedItems[0].Tag;       
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = string.Format("delete from Categories Where CategoryName='{0}' AND Description like '{1}'",cat.CategoryName,cat.Description);
            cmd.Connection = SqlHelper.cnn;
            try
            {
                cmd.Connection.Open();
                int gelenDeger = cmd.ExecuteNonQuery();
                if (gelenDeger > 0)
                {
                    MessageBox.Show("Silme işlemi Başarılı");
                }
                else
                {
                    MessageBox.Show("Silinemedi..");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cmd.Connection.Close();
                Yenile();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = string.Format("insert into Categories (CategoryName, [Description]) Values ('{0}','{1}')", txtName.Text, txtDesc.Text);
            cmd.Connection = SqlHelper.cnn;
            try
            {
                cmd.Connection.Open();
                int gelenDeger = cmd.ExecuteNonQuery();
                if (gelenDeger > 0)
                {
                    MessageBox.Show("Kayıt işlemi Başarılı");
                }
                else
                {
                    MessageBox.Show("Kayıt gerçekleştirilemedi!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cmd.Connection.Close();
                Yenile();
            }
        }
    }
}
