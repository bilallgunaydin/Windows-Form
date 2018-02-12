using _01_Review.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_Review
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            NorthwindEntities db = new NorthwindEntities();
            #region Tüm Cirom Ne Kadar

            //Tüm Ciron ne kadar
            //var query = (
            //            from p in db.Products
            //            join od in db.Order_Details on p.ProductID equals od.ProductID
            //            select new
            //            {
            //                asd = (double)(p.UnitPrice * od.Quantity) * (1 - od.Discount)
            //            }).Sum(x => x.asd);
            //MessageBox.Show(query.ToString());

            //-----------------------------------------------------
            
        
            //Extendion Method * Lambda Expression
            //dgvTest.DataSource = db.Categories.ToList();
            //dgvTest.DataSource = db.Categories
            //                       .Where(x => x.CategoryID > 5)
            //                       .ToList();
            //-----------------------------------------------------
            //MessageBox.Show(db.Categories
            //                  .Where(x => x.CategoryName == "Beverages")
            //                  .Select(x => x.CategoryID)
            //                  .SingleOrDefault()   //.FirstOrDefault()   Aynı Şey.
            //                  .ToString());
            //-----------------------------------------------------

            //dgvTest.DataSource = db.Products
            //                       .Where(x => x.UnitPrice > 20 && x.UnitPrice < 50)
            //                       .Select(x => new
            //                       {
            //                           x.ProductID,
            //                           x.UnitPrice,
            //                           x.UnitsInStock,
            //                           x.Category.CategoryName,
            //                           x.Supplier.ContactName
            //                       }).ToList();

            //-----------------------------------------------------

            // order ID si verilen siparişlerin product isimleri ve adeti
            //dgvTest.DataSource = db.Order_Details
            //    .Where(x=> x.OrderID < 10500)
            //                       .Select(x => new
            //                       {
            //                           x.OrderID,
            //                           x.Product.ProductName,
            //                           x.UnitPrice,
            //                           x.Quantity
            //                       }).ToList();

            //-----------------------------------------------------
            //Category - Product - OrderDetails

            //UnitPrice' ı 100 ve 100 den fazla olan kategori adı urun adı orderID
            dgvTest.DataSource = db.Categories
                                   .Join(db.Products,
                                         cat => cat.CategoryID,
                                         pro => pro.CategoryID,
                                         (cat, pro) => new { cat, pro })
                                   .Join(db.Order_Details,
                                         catPro => catPro.pro.ProductID,
                                         ord => ord.ProductID,
                                         (catPro, ord) => new { catPro, ord })
                                   .Where(x => x.catPro.pro.UnitPrice >= 100)
                                   .Select(x => new
                                   {
                                       x.catPro.cat.CategoryName,
                                       x.catPro.pro.ProductName,
                                       x.catPro.pro.UnitPrice,
                                       x.ord.OrderID
                                   }).ToList();

            //2.Yazım
            dgvTest.DataSource = db.Order_Details
                                   .Where(x => x.Product.UnitPrice >= 100)
                                   .Select(x => new
                                   {
                                       x.Product.Category.CategoryName,
                                       x.Product.ProductName,
                                       x.Product.UnitPrice,
                                       x.OrderID
                                   }).ToList();


            // Çalışanla amirini Listelet (Lambda tarzı ile)
        





            #endregion
        }
    }
}
