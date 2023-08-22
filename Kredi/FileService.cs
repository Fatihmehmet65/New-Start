using System;

namespace Kredi
{
    internal class FileService : IloggerService
    {
        public void Log()
        {
            Console.WriteLine("Dosya Servis Loglandı");
        }
    }
}
