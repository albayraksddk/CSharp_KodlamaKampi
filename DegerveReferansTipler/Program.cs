using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            //design pattern?? - solid yazılım geliştirme prensipleri??
            /*
             * 	Not: Csharp da int, decimal, float, double, bool = bunlar değer tiptir. Array, class ve interface referans tiptir. 
             * 	referans tiplerin değerleri heap te tutulur. 
             * 
             * */
            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            //sayi 1 in değeri burada 30 olarak kalır. Çünkü int değer tiptir. 

            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            //sayilar1[0] elemanı 999 olarak değişir. Çünkü buradaki array referans tiptir. burada sayilar1 heap teki sayilar2 nin referans değerlerini alır.
 

        }
    }
}
