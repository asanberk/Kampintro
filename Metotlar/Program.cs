using System.Security.Claims;

namespace Metotlar
{

    class Program
    {
        //Metotlar tekrar tekrar kullanılmayı sağlayan kod blokları
        //Don't repeat yourself - Clean code - Best Practice
        static void Main(string[] args)
        {
            Urun elma = new Urun();
            elma.Adi = "Elma";
            elma.Fiyati = 10;
            elma.Aciklama = "Amasya Elmasi";

            Urun muz = new Urun();
            muz.Adi = "Muz";
            muz.Fiyati = 20;
            muz.Aciklama = "Akdeniz Muzu";

            Urun portakal= new Urun();
            portakal.Adi = "Portakal";
            portakal.Fiyati = 30;
            portakal.Aciklama = "Sulu portakal";

            Urun[] urunler = new Urun[] {elma,muz,portakal };

            foreach (Urun urun in urunler)
            {
               Console.WriteLine(urun.Adi+" "+urun.Fiyati+" "+urun.Aciklama);
            }

            Console.WriteLine("----------Metotlar-------");
            //Encapsulation
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(elma);
            sepetManager.Ekle(muz);
            sepetManager.Ekle(portakal);

            sepetManager.Ekle2("Armut", "Yeşil armut", 12);
            sepetManager.Ekle2("Elma", "Yeşil elma", 12);
            sepetManager.Ekle2("Karpuz", "Diyarbakır karpuzu", 12);









        }
    }
}