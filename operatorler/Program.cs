using System;

namespace operatorler
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("-------Mantıksal İfadeler---------");

            bool isSuccess=true;
            bool isComplited=false;

            if(isSuccess && isComplited);
                Console.WriteLine("Perfect");
            
            if(isSuccess||isComplited);
                Console.WriteLine("Well Done");
            
            if(isSuccess&&!isComplited);
                Console.WriteLine("Not Bad");



            int a =3;
            int b=3;

            bool sonuc=a<b;

            Console.WriteLine(sonuc);
            sonuc= a>b;
            Console.WriteLine(sonuc);
            sonuc= a<b;
            Console.WriteLine(sonuc);
            sonuc= a>=b;
            Console.WriteLine(sonuc);
            sonuc= a<=b;
            Console.WriteLine(sonuc);
            
            Console.WriteLine("-------Aritmetik İfadeler---------");
            int sayi1=10;
            int sayi2=5;
            int sonucsayi=sayi1/sayi2;

            Console.WriteLine(sonucsayi);
            sonucsayi=sayi1-sayi2;
             Console.WriteLine(sonucsayi);
             sonucsayi=sayi1*sayi2;
             Console.WriteLine(sonucsayi);
            sayi1+=9;
            Console.WriteLine("sayi1 = "+sayi1);

            Console.WriteLine("-------mod---------");
             int mod=19%6;
             Console.WriteLine(mod);






        }
    }
}
