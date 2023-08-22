using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product urun1 = new Product();
            Product urun2 = new Product();

            urun1.Urunadi = "Leptop";
            urun1.Id = 1;
            urun1.Fiyatı = 22500;
            urun1.Aciklama = "Teklonolojii Demek";
            urun2.Urunadi = "Monitör";
            urun2.Id = 2;
            urun2.Fiyatı = 19.500;
            urun2.Aciklama = "Yenilik Demek";
            Product musterii = new SepetManager();
            Product[] product=new Product[] { urun1,urun2};
            foreach (var urun in product)
            {
                
                Console.WriteLine(urun.Urunadi+" **** "+urun.Aciklama+" ---- "+urun.Fiyatı);

            }
            //METOT ÇAĞIRMA 

            SepetManager sepet = new SepetManager();
            foreach (var bekle in product)
            {
                sepet.Ekle(urun1);
                Console.WriteLine( "*************");
                sepet.Ekle(urun2);
            }
            
            
            sepet.Ekle(urun1);
            sepet.Ekle(urun2);
            sepet.Ekle(urun1);
        }
    }
}
