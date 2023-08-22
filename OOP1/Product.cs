using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    internal class Product
    {
        public string ProductName { get; set; }

        public int  Id { get; set; }
        //Ürün Fiyatı
        public double UnitPrice { get; set; }
        //
        public int CategoryId { get; set; }
        //Birim Stok Adedi
        public int UnitsInStoks { get; set; }

    }
}
