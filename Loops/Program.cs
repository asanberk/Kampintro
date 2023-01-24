namespace Loops
{

    class Program
    {

        static void Main(string[] args)
        {
            //Array dizi
            string[] kurslar = new string[] {"Yazılım Geliştirme kampı","Programlamaya başlangıç için temel kurs","Java","Python","C#","C++" };


            //Döngüler-loops
            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("Sayfa sonu-footer");   

            //Foreach dizilere uygulanır.
            foreach (string kurs in kurslar) 
            {
                Console.WriteLine(kurs);
            }

        }
    }

}

