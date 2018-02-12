using _02_CRUD.Data;
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

namespace _02_CRUD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        NorthwindEntities db = new NorthwindEntities();
        private void Form1_Load(object sender, EventArgs e)
        {
            GetCategories();
        }

        private void GetCategories()
        {
            dgvCategories.DataSource = db.Categories.ToList();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {


            #region 1.Yöntem
            //Category cat = new Category();
            //cat.CategoryName = txtCategoryName.Text;
            //cat.Description = txtDescription.Text;
            //db.Categories.Add(cat);
            //db.SaveChanges(); // değişiklikleri database ede kaydet.
            //GetCategories();


            #endregion

            #region 2.Töntem
      //db.Categories.Add(new Category { CategoryName = txtCategoryName.Text, Description = txtDescription.Text });
      //db.SaveChanges();
      //GetCategories();



            #endregion

            #region 3.Yöntem
      //db.Database.ExecuteSqlCommand("insert into Categories(CategoryName, Description) values(@ad, @desc)",
      //    new SqlParameter("@ad", txtCategoryName.Text),
      //    new SqlParameter("@desc", txtDescription.Text));
      //GetCategories();
            
      #endregion

            #region 4.Yöntem SP ile Ekleme

            /*
             create proc sp_CategoryAdd
                (
                @name varchar(50),
                @desc varchar(100)
                )
                as
                begin
                insert into Categories( CategoryName, [Description] ) values (@name, @desc)
                end
             */

            db.sp_CategoryAdd(txtCategoryName.Text, txtDescription.Text);
            GetCategories();

            #endregion

        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvCategories.SelectedRows.Count > 0)
            {
                int id = (int)dgvCategories.SelectedRows[0].Cells["CategoryID"].Value;
                Category cat = db.Categories.Where(x => x.CategoryID == id).FirstOrDefault();

                db.Categories.Remove(cat);
                db.SaveChanges();
                GetCategories();
            }
        }

        Category guncellenecek;
        private void güncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id = (int)dgvCategories.SelectedRows[0].Cells["CategoryID"].Value;
            guncellenecek = db.Categories
                              .Where(x => x.CategoryID == id)
                              .FirstOrDefault();
            txtCategoryName.Text = guncellenecek.CategoryName;
            txtDescription.Text = guncellenecek.Description;
            btnSave.Visible = false;
            btnEdit.Visible = true;
            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            guncellenecek.CategoryName = txtCategoryName.Text;
            guncellenecek.Description = txtDescription.Text;
            db.SaveChanges();
            GetCategories();
            txtCategoryName.Text = "";
            txtDescription.Text = "";
            btnSave.Visible = true;
            btnEdit.Visible = false;
        }
        // Products tablosu aynı şekilde yapılacak.
        // Category kısmını daha onceden combobox a getiricez.
        // 
        
    }
}
