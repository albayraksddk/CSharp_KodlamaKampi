using System;

namespace OdevDenemeleri
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            int day = rnd.Next(1,7);


            switch (day)
            {
                case 1:
                    Console.WriteLine("Pazartesi");
                    break;
                case 2:
                    Console.WriteLine("Salı");
                    break;
                case 3:
                    Console.WriteLine("Çarşamba");
                    break;
                case 4:
                    Console.WriteLine("Perşembe");
                    break;
                case 5:
                    Console.WriteLine("Cuma");
                    break;
                case 6:
                    Console.WriteLine("Cumartesi");
                    break;
                case 7:
                    Console.WriteLine("Pazar");
                    break;

                default:
                    Console.WriteLine("Lütfen 1-7 arasında bir sayı giriniz");
                    break;
            }
        }
    }
}
