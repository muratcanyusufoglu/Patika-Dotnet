using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("İsminizi Giriniz");
            string isim=Console.ReadLine();
            Console.WriteLine("Soyisminizi Giriniz");
            string soyisim=Console.ReadLine();

            Console.WriteLine("Merhaba benim adim "+isim+" "+soyisim );
            
        }
    }
}
