namespace Kampintro
{

    class Program
    {

        static void Main( string[] args)
        {
            //type safety - tip güvenliği
            //Do not repeat yourself - kendini tekrarlama
            //Değer tutucu- alias
            string kategorietiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirişyapmışmı = false;
            double dolarDun = 10.75;
            double dolarBugun = 11.75;

            if (dolarBugun>dolarDun)
            {
                Console.WriteLine("Artış Oku");
            }

            else if (dolarBugun<dolarDun)
            {
                Console.WriteLine("Azalış oKU");
            }
            else
            {
                Console.WriteLine("Eşittir");
            }

            if (sistemeGirişyapmışmı == true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }

            else if (sistemeGirişyapmışmı==false)
            {
                Console.WriteLine("Lütfen Giriş Yapınız");    
            }

           
            Console.WriteLine(kategorietiketi);


        }
    }

}
