using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kredi
{
    internal class SmsLogerService : IloggerService
    {
        public void Log()
        {
            Console.WriteLine("SMS Loglandı.");
        }
    }
}
