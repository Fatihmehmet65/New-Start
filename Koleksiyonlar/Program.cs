using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koleksiyonlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] isimler = new string[]
            {
                "engin","fatih","veli", "ege"
            };


            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);
            List<string> isimler1 = new List<string> { "Engin", "Mehmet Fatih", "Veli ", "Vahit" };
            isimler1.Add("İzzet");
            for (int i = 0; i <= (isimler1.Count)-2; i++)
            {
                Console.WriteLine((i + 1) + "ci Kişi :" + isimler[i]);
            }
            Console.WriteLine(isimler1[0]);
            Console.WriteLine(isimler1[1]);
            Console.WriteLine(isimler1[2]);
            Console.WriteLine(isimler1[3]);
            Console.WriteLine(isimler1[4]);

        }


    }
}
