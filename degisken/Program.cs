using System;

namespace degisken
{
    class Program
    {
        static void Main(string[] args)
        {
        
        string str10 ="20";

        int a=12;

        float ortalama=7.5f;

        decimal sayi2=2155.32m;

        int degisken=a+Convert.ToInt32(str10);

        Console.WriteLine(degisken);

        string datetime=DateTime.Now.ToString("dd.MM.yyyy");
         Console.WriteLine(datetime);
        
        string datetime2=DateTime.Now.ToString("dd-MM-yyyy");
         Console.WriteLine(datetime2);
        
        string hour=DateTime.Now.ToString("hh/mm");
         Console.WriteLine(hour);       




        



    


        }
    }
}
