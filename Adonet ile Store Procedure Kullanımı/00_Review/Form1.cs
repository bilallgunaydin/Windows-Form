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

namespace _00_Review
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Listele();
        }
        List<Category> catList;
        Product updatePro;

        private void Listele()
        {
            lvProducts.Items.Clear();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select ProductID,ProductName,UnitsInStock,UnitPrice,Discontinued,CategoryID from Products";
            cmd.Connection = SqlHelper.cnn;
            try
            {
                cmd.Connection.Open();
                SqlDataReader dataReader = cmd.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        Product product = new Product();
                        product.ProductID = (int)dataReader[0];
                        product.ProductName = (string)dataReader[1];
                        product.UnitsInStock = int.Parse(dataReader[2].ToString());
                        product.UnitPrice = double.Parse(dataReader[3].ToString());
                        product.Discontinued = (bool)dataReader[4];  //satılıyormu? oldugundan bool
                        product.CategoryID = (int)dataReader[5];

                        ListViewItem li = new ListViewItem();
                        li.Tag = product;
                        li.Text = (product.ProductID.ToString());
                        li.SubItems.Add(product.ProductName);
                        li.SubItems.Add(product.UnitsInStock.ToString());
                        li.SubItems.Add(product.UnitPrice.ToString());
                        li.SubItems.Add(product.Discontinued.ToString());

                        lvProducts.Items.Add(li);
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
            }
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {

            txtName.Text = "";
            txtPrice.Text = "";
            txtStock.Text = "";

            grpAdd.Visible = true;
            KategorileriGetir();

        }
        private void btnSave_Click(object sender, EventArgs e)
        {

            Category cat = (Category)cmbCategory.SelectedValue;
            if (btnSave.Text == "Kaydet")
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = string.Format("insert into Products(ProductName,UnitsInStock, UnitPrice, Discontinued, CategoryID) values('{0}', {1}, {2}, '{3}', {4})",
                    txtName.Text, txtStock.Text, txtPrice.Text, "true", cat.CategoryID);

                cmd.Connection = SqlHelper.cnn;

                try
                {
                    cmd.Connection.Open();
                    int etkilenen = cmd.ExecuteNonQuery();//sorguyu calıstır etkilenen satır sayısını döndür. (ve değişkene at)
                    if (etkilenen > 0)
                    {
                        MessageBox.Show("Ürün basarıyla eklendi.");
                    }
                    else
                    {
                        MessageBox.Show("insert işleminde bir hata olustu..");
                    }
                    cmd.Connection.Close();
                    grpAdd.Visible = false;
                    cmbCategory.DataSource = null;
                    Listele();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    cmd.Connection.Close();
                }
            }
            else
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = string.Format("update Products set ProductName='{0}', UnitsInStock={1}, UnitPrice={2}, CategoryID={3} where ProductID={4}",
                   txtName.Text, txtStock.Text, txtPrice.Text, cat.CategoryID, updatePro.ProductID);

                cmd.Connection = SqlHelper.cnn;

                try
                {
                    cmd.Connection.Open();
                    int etkilenen = cmd.ExecuteNonQuery();//sorguyu calıstır etkilenen satır sayısını döndür.
                    if (etkilenen > 0)
                    {
                        MessageBox.Show("Ürün basarıyla Güncellendi.");
                    }
                    else
                    {
                        MessageBox.Show("insert işleminde bir hata olustu..");
                    }
                    cmd.Connection.Close();
                    grpAdd.Visible = false;
                    cmbCategory.DataSource = null;
                    Listele();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    cmd.Connection.Close();
                }
            }

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            updatePro = (Product)lvProducts.SelectedItems[0].Tag;

            SqlCommand cmd = new SqlCommand(string.Format("delete from Products where ProductID={0}", updatePro.ProductID), SqlHelper.cnn);

            DialogResult DRs = MessageBox.Show("Silmek istediğinize emin misiniz?", "Sil", MessageBoxButtons.YesNo);

            if (DRs == DialogResult.Yes)
            {
                SqlHelper.cnn.Open();
                cmd.ExecuteNonQuery();
                SqlHelper.cnn.Close();
                Listele();
            }


        }

        private void güncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KategorileriGetir();
            updatePro = (Product)lvProducts.SelectedItems[0].Tag;
            grpAdd.Visible = true;
            txtName.Text = updatePro.ProductName;
            txtStock.Text = updatePro.UnitsInStock.ToString();
            txtPrice.Text = updatePro.UnitPrice.ToString();

            foreach (Category item in catList)
            {
                if (item.CategoryID == updatePro.CategoryID)
                {

                    cmbCategory.SelectedItem = item;
                }
            }
            btnSave.Text = "Güncelle";



        }

        private void KategorileriGetir()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select CategoryID, CategoryName from Categories";
            cmd.Connection = SqlHelper.cnn;

            cmd.Connection.Open();
            SqlDataReader dataReader = cmd.ExecuteReader();
            if (dataReader.HasRows)
            {
                catList = new List<Category>();
                while (dataReader.Read())
                {
                    Category cat = new Category();
                    cat.CategoryID = (int)dataReader[0];
                    cat.CategoryName = (string)dataReader[1];
                    catList.Add(cat);
                }
                cmbCategory.DataSource = catList;       //DataSource'a koleksiyon göndermek kuraldır.
            }
            cmd.Connection.Close();
        }



    }
}
