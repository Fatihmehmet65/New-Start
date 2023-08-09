using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matematik
{
    internal class Program
    {
        static void Main(string[] args)
        {

            DortIslem dortIslem = new DortIslem();

            dortIslem.Topla(2,3);

            DortIslem dortIslem1 = new DortIslem();
            dortIslem1.Ekle("karpuz","kavun",55);
        }
    }
}
