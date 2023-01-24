using System;

namespace DegerVeReferansTipler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //-------------ÖNEMLİ----------------
            //int,decimal,fload,double,bool = değer tip
            //array,class,interpore = referans tip

            int sayi1 = 10;
            int sayi2 = 20;
            sayi1 = sayi2;
            sayi2 = 65;
            //Burda sayi1  cevap 20 çünkü değer tip

            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            //Burda sayilar[0] 999 olur çünkü referans tip












        }
    }
}
