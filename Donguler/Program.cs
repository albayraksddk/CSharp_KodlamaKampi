using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
            string kurs2 = "Programlamaya başlangıç için temel kurs";
            string kurs3 = "Java";
            string kurs4 = "Python";
            string kurs5 = "C#";

            //array - dizi

            string[] kurslar = new string[]
            {
                //"Yazılım Geliştirici Yetiştirme Kampı","Programlamaya başlangıç için temel kurs","Java", "Python","C#"
                kurs1,kurs2,kurs3,kurs4,kurs5 //değişkenlerin aliaslarını yazabiliriz
             };


            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("For Bitti");
            Console.WriteLine(); //bu şekilde yazıldığında bir satır boşluk bırakır
            Console.WriteLine();


            foreach (string kurs in kurslar) //bu döngü dizilerde uygulanır
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("Sayfa Sonu - Footer");
        }
    }
}
