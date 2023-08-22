using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    internal class SepetManager:Product
    {

        public void Ekle(Product urun)
        {
            Console.WriteLine("TEBRİKLER.SEPETE EKLENDİ!"+urun.Urunadi);
        }
        
    }
    
}
