using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    internal class ProductManager:Product
    {
        public void Add()
        {
            Console.WriteLine("Merhaba Dünya...");
        }
        public double Price(double sayi1, double sayi2)
        {
            return sayi1*sayi2;
        }
    }
}
