using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kredi
{
    internal class KrediOnBilgilendirme
    {
        public void Hesapla()
        {
            throw new NotImplementedException();
        }

        public void OnbilgilendirmeYap(List<IKrediHesapla> krediler)
        {
            foreach (var kredi in krediler) {

                kredi.Hesapla();
            }
        }
    }
}
