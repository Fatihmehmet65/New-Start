using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsIntro
{
    internal class MyList<T>
    {
        //Bu Methodda istediğimiz değişken kullanıcıdan alınacağı için T belirledik.
       //new lemek zorundayım
        T[] values;// Methodun Dışında OLuşturduk Çünkü başka Bir Method Yazdığımız Her Taraftan çağırabilelim. 
        //ctor tab+tab (constractor?? class ın ismiyle aynı methoddur ve void yoktur...) yapılacak
        public MyList()
        {
                values = new T[0];//diizyi sıfırlamak lazım...
        }
        public void Add(T item) {

            T[] TempValues=values;//Geçici Kaybolomasını istemediğimiz array
           
            values=new T[values.Length+1];// yeni array oluşturduk.

            for (int i = 0; i < TempValues.Length; i++)
            {
                values[i] = TempValues[i];
            }
            values[values.Length-1] = item;

           
        }
        public int Lenght {
            get { return values.Length; }
        }
    }
}
