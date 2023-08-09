using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_Start
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string S = "SENİ SEVİYORUM";
            Kurs kurs1 = new Kurs();
            Kurs kurs2 = new Kurs();
            Kurs kurs3 = new Kurs();
            kurs1.Egitmen = "Fatih sultan mehmet oktay";
            kurs1.IzlenmeOrani = 35;
            kurs1.KursAdi = "C#";
            kurs2.KursAdi = "MVC";
            kurs2.Egitmen = "Mehmet Oktay";
            kurs3.KursAdi = ".NET CORE";
            kurs3.Egitmen = "Fatih Oktay";
            //int A = 5;

            Kurs[] kurslar = new Kurs[]
                {
                    kurs1, kurs2, kurs3
                };
            foreach (var kurss in kurslar)
            {
                Console.WriteLine(kurss.KursAdi+" : "+ kurss.Egitmen);
            }

        }
    }
    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }

    }
}
