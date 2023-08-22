using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product();    
            product.Id = 1;
            product.CategoryId = 2;
            product.UnitPrice = 10;
            product.ProductName = "Karpuz";
            product.UnitsInStoks = 7;
            Product product1 = new Product {Id=1,CategoryId=2,UnitPrice=12,ProductName="Karpuz",UnitsInStoks=7 };
            ProductManager productManager = new ProductManager();
            double gelsin=productManager.Price(3.5, 4.5);
            Console.WriteLine("Çarpıldı: "+" "+gelsin);
        }
    }
}
