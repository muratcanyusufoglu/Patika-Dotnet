using System;

namespace switch_case
{
    class Program
    {
        static void Main(string[] args)
        {
            int month=DateTime.Now.Month;

            switch(month)
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("Kis Mevsimindesiniz....colddd");
                    break;

                case 3:
                case 4:
                case 5:
                    Console.WriteLine("Bahar Mevsimindesiniz....yesillendi ortalik");
                    break;

                case 6:
                case 7:
                case 8:
                    Console.WriteLine("Yaz geldi....parmak arasi terlikler ciksinn");
                    break;

                case 9:
                case 10:
                case 11:
                    Console.WriteLine("Ve sonbahar....her yerde yaprak var ama her ye");
                    break;

                default:
                    Console.WriteLine("Mevsimsizsiniz.....");
                break;

            }
        }
    }
}
