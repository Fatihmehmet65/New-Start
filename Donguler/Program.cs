using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Donguler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] deneme = new string[]
            {
                "dene1","dene2","dene3"
            };
            for (int i = 0; i < deneme.Length; i++)
            {
                Console.WriteLine(deneme[i]);
                Console.WriteLine("****************");
            }
            Console.WriteLine("eski bitti Foreach Başladık...");
            foreach (string dön in deneme)
            {
                Console.WriteLine(dön);
                Console.WriteLine("*********----------------");
            }
            
        }
    }
}
