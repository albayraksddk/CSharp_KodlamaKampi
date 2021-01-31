using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName + " eklendi. ");
        }

        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " güncellendi. ");
        }
        ////Bu şekilde class oluşturduğumuzda bu metodun sonucunu her yerde kullanabiliriz.
        //public int Topla(int sayi1, int sayi2)
        //{
        //    return sayi1 + sayi2;
        //}
        ////Void aslında bir emir komutu gibi çalışır git yap gibi. 
        ////Void ile yapılan classların sonucunu başka bir yerde kullanmak istesek kullanamayız.
        //public void Topla2(int sayi1, int sayi2)
        //{
        //    Console.WriteLine(sayi1 + sayi2);
        //}
    }

}
