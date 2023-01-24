using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matematik
{
    internal class DortIslem
    {
        public void Topla(int sayi1,int sayi2) 
        {
            int toplam = sayi1 + sayi2;
            Console.WriteLine("Sonuç=" + toplam);
         
        }

        public void Çıkarma(int sayi1,int sayi2) 
        {
            int çıkarma = sayi1 - sayi2;

            Console.WriteLine("Sonuç=" + çıkarma);
                     
        }
        public void Çarpma(int sayi1, int sayi2)
        {
            int çarpım= sayi1 * sayi2;
            Console.WriteLine("Sonuç=" + çarpım);

        }

        public void Bölme(int sayi1, int sayi2)
        {
            float bölüm = sayi1 / sayi2;
            Console.WriteLine("Sonuç=" + bölüm);

        }

    }
}
