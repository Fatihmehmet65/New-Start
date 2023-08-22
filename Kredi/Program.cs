using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kredi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IKrediHesapla krediHesapla = new EvKredisi();
            IKrediHesapla evkredisi = new EvKredisi();
            IKrediHesapla arackredisi=new AracKredisi();
            KrediBasvuruManager krediBasvuruManager=new KrediBasvuruManager();
            IloggerService ıloggerService = new DataBaseService();
            IKrediHesapla esnafkredi=new EvKredisi();
            IloggerService fileservice = new FileService();
           IloggerService smsservis=new SmsLogerService();
            List<IloggerService> ıloggerServices2=new List<IloggerService>()
            { smsservis,fileservice,ıloggerService};
            //fileservice.Log();
            krediBasvuruManager.BasvuruYap(new EsnafKredisi(),ıloggerServices2);

            //evkredisi.Hesapla();
            //arackredisi.Hesapla();
            //Burda Liste Oluşturararak Sınırsız elamanları kendi içinde hesap yaparak çağırdık.
            List<IKrediHesapla> kredis=new List<IKrediHesapla>() { evkredisi,arackredisi};
            List<IloggerService> ıloggerServices = new List<IloggerService>();
            KrediOnBilgilendirme krediOnBilgilendirme =new KrediOnBilgilendirme();
            //krediOnBilgilendirme.OnbilgilendirmeYap(kredis);
        }
    }
}
