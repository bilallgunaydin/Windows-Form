using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_Review
{
    class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int UnitsInStock { get; set; }
        public double UnitPrice { get; set; }
        public bool Discontinued { get; set; }
        public int CategoryID { get; set; }
    }
    class Category
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public override string ToString()
        {
            {
                return CategoryName;
            }
        }
    }
}
