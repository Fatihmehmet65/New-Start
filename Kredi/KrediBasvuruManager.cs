using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kredi
{
    internal class KrediBasvuruManager:IKrediHesapla
    {
        public void BasvuruYap(IKrediHesapla ikredihesapla,List<IloggerService> ıloggerService)
        {
            ikredihesapla.Hesapla();

            foreach (var ıloggerService1 in ıloggerService)
            {
                ıloggerService1.Log();
            }
        }

        public void Hesapla()
        {
            throw new NotImplementedException();
        }
    }
}
