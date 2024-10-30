using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes2
{
    public class ProductManager //veya ProductManager
    {//methods
        // metot , fonksiyon, prosedür bunlar hepsi aynı şey aynı anlama çıkıyor
        //bir class ta o classın özelikleirni  tek değil iş operasyonlarınıda yazabiliriz.
 //reusability: yazdığın kodu birden fazla yerde kullanabilme veya ihitaçı yerde kullabilme
    //kendini tekrar etmemelisin
    //yazılım yaşayan bir organızmadır yarın übür gün uygulamalarımızda direnç göstermemesilazımdır.
        public void Add(Product product) 
        {
            Console.WriteLine("Ürün Eklendi :"+product.ProductName);
        }
    }
}
