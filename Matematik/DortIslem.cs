using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matematik
{
    internal class DortIslem
    {
        public void Topla(int sayi1, int sayi2) {
        
            int topla=sayi1 + sayi2;
            Console.WriteLine("TOPLaM : "+topla);
        }
        public void Ekle(string Aciklama,string UrunAdi,double Fiyatı)
        {
            Console.WriteLine("tmmdır 4 işlem"+"**"+ Aciklama+" /"+UrunAdi+"/"+ Fiyatı);
        }
    }
}
