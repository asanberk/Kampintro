using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    internal class SepetManager
    {
        //syntax - yazım şekilleri
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Sepete eklendi ;" + urun.Adi);
        }

        //Bunu kullanma çünkü herhangi bir değişiklikte patlarsın
        public void Ekle2(string urunAdi , string aciklama , double fiyat)
        {
            Console.WriteLine("Sepete eklendi;" + urunAdi);
        }

    }
}
