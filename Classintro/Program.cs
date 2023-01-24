namespace Classintro
{

    class Program
    {

        static void Main(string[] args)
        {


            Kurs kurs1 = new Kurs();

            kurs1.KursAdi = "C#";

            kurs1.KursEgitmeni = "Engin Demiroğ";

            kurs1.izlenme = 1000;

            Kurs kurs2  = new Kurs();

            kurs2.KursAdi = "Python";

            kurs2.KursEgitmeni = "Ahmet";

            kurs2.izlenme = 320;

            Console.WriteLine(kurs1.KursAdi + " " + kurs1.KursEgitmeni + " " + kurs1.izlenme);

            Console.WriteLine(kurs2.KursAdi + " " + kurs2.KursEgitmeni + " " + kurs2.izlenme);




        }
    }
    class Kurs
    {
        public string KursAdi { get; set; }
        public string KursEgitmeni { get; set; }
        public int izlenme { get; set; }
    }

}
