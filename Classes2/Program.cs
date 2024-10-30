

using Classes2;

//İnstance=örnek
//bu classtan belekte bir örneğini oluşturyor yani productManager örneği veya nesne

Product product1 = new Product() {ProductName="Leptop",UnitPrice=5000,UnitsInStock=50 };//ctrl+space tuşları ile hızı bir şekilde yazabilrsin
product1.ProductName = "Leptop2"; // bu şekilde deyazım tarzı var
ProductManager productManager = new ProductManager();
productManager.Add(product1);