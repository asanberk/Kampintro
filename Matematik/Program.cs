using System.Security.Claims;

namespace Matematik
{

    class Program
    {
       
        static void Main(string[] args)
        {
           DortIslem dortIslem= new DortIslem();
            dortIslem.Topla(5,6);
            dortIslem.Çıkarma(5,6);
            dortIslem.Çarpma(5,6);
            dortIslem.Bölme(10,2);
           



        }
    }
}