using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //oluşturduğumuz özellik klası olan Urun.cs yardımıyla ürünlerimize tanıttımız özellikleri verdik
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Aciklama = "Amasya Elması";
            urun1.Fiyati = 15;
            urun1.StokAdedi = 150;

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır Karpuzu";
            urun2.StokAdedi = 500;

            Urun urun3 = new Urun();
            urun3.Adi = "Armut";
            urun3.Aciklama = "Yeşil Armut";
            urun3.Fiyati = 12;
            urun3.StokAdedi = 100;


            Urun[] urunler = new Urun[] { urun1, urun2, urun3 };

            foreach (Urun urun in urunler)
            {
                Console.WriteLine("Adı: {0}", urun.Adi);
                Console.WriteLine("Açıklaması: {0}", urun.Aciklama);
                Console.WriteLine("Fiyatı: {0}", urun.Fiyati);
                Console.WriteLine("Kalan Stok Adedi: {0}", urun.StokAdedi);

                Console.WriteLine("----------------------");
            }

            Console.WriteLine("-------------------Metotlar-------------");
            //encapsulation - kapsülleme demek. Ayrı ayrı yazacağımız ve ayrı ayrı düzensiz olacak bir yapıyı kapsül içine sokarak düzenliyoruz.



            //for (int i = 1; i <= urunler.Length; i++)
            //{
            //   Console.WriteLine("Urun{0}: ", i);
            //}



            SepetManager sepetManager = new SepetManager(); // instance - örnek 
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);
            sepetManager.Ekle(urun3);

            Console.WriteLine("++++++++++++++++++++");

            //Bu şekilde yazıldığı zaman class parametrik olmadı. herhangi bir değişiklikte aşağıdaki gibi heryeri değiştirmen lazım.
            sepetManager.Ekle2("Armut", "Yeşil Armut", 12, 100);
            sepetManager.Ekle2("Elma", "Yeşil Elma", 20, 150);
            sepetManager.Ekle2("Karpuz", "Diyarbakir Karpuzu", 9, 500);

        }

    }
}


//Dont repeat your self - DRY - Clean Code - Best Practice 
//Metotlara örnek olarak alışveriş sitelerindeki sepete ekle butonunun arkasındaki yazılım verilebilir.
//Sepete ekle butonunun farklı yerlerde karşımıza çıkması metotlara örnektir.