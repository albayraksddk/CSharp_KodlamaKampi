using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        //naming convention - yazım kuralları
        //eğer bir yerde normal parantez kullanılıyorsa orada metot çalışıyordur.
        /*Burada bir metot oluştururken Ekle metodunda Neyi ekleyeceğimizi parantezin içine yazdık. 
         * Yani bu metot için parametre tanımladık. 
         * Burada Buyuk harfle yazılan Urun - clas ın tipini, küçük harfli olan urun ise o metodu kullanmak için verdiği isim
         */

        public void Ekle(Urun urun) //Pythonda def olarak tanımladığımız fonksiyon . burada public void olarak yazılır. 
        {

            Console.WriteLine("Tebrikler!. Sepete Eklendi : {0} {1} ", urun.Adi, urun.Aciklama);
            Console.WriteLine("Kalan Stok: {0}", urun.StokAdedi);
        }

        public void Ekle2(string urunAdi, string aciklama, double fiyat, int stokAdedi)
        {
            Console.WriteLine("Tebrikler!. Sepete Eklendi : " + urunAdi + aciklama);
        }
    }
}
