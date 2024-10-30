

using Project4.Business;
using Project4.DataAccess;
using Project4.Entities;

ProductManager productManager = new ProductManager(new XmlProductDal());
productManager.GetAll();


foreach (var product in productManager.GetAll())//bu for gibi değil arka planda otomatikmen alır index numaralarını
{
   Console.WriteLine(product.ProductName);
}

//productManager.Add(new Product() { Id = 1, ProductName = "Masa", QuantityPerUnit = "4 ayaklı masa", UnitPrice = 1001, UnitsInStock = 5 });


Test(productManager);

static void Test(ProductManager productManager)
{
    try
    {
        productManager.Add(new Product() { Id = 1, ProductName = "LaptoP", QuantityPerUnit = "4 ayaklı masa", UnitPrice = 1001, UnitsInStock = 5 });
    }
    catch (Exception exception)
    {
        Console.WriteLine(exception.Message); // bu şekil ile uygulamayı kırmadan hata mesajımızı aldık.
    }
}

