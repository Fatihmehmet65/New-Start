using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kredi
{
    internal class DataBaseService : IloggerService
    {
        public void Log()
        {
            Console.WriteLine("Veri Tabanı Servis Loglandı"); 
        }
    }
}
