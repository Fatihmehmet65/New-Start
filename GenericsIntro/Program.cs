using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyList<string> myList = new MyList<string>
            ();
            myList.Add("Fatih");
            myList.Add("Mehmet");

            Console.WriteLine(myList.Lenght);
            myList.Add("Fatih1");
            myList.Add("Mehmet1");
            Console.WriteLine(myList.Lenght);

            //string a=myList.Add("Allah ın izniyle Başaracağım");
            //Console.WriteLine(a);
        }
    }
}
