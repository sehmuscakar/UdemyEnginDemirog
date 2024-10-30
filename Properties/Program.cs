

Product product = new Product();
product.Id = 1;//bu set olayıdır.
Console.WriteLine(product.Id);//buda get olayıdır 

product.UnitsInStock = 50;
Console.WriteLine(product.UnitsInStock);

product.UnitPrice = 500;
Console.WriteLine(product.UnitPrice);








product.Name = "Test";
Console.WriteLine(product.Name);



class Product
{
    private string _name;  

    public string Name     
    {
        get { return _name + "batman"; }  
        set { _name = value; }   //setter içinde mesela kullanıcıdan bir veri aldın diyelim textbox tan girildi. db ye kayıt atmadan önce burda değiştrip oyle kayıt atabilirsn mesela yaş giridn sen bunu +2 ekleyip her kşiinin yaşını iki fazlasını kayıt atabilirisn 
    }




    public int Id { get; set; }
    public string FirstName { get; set; }
    public int UnitPrice { get; set; }
    public int UnitsInStock;

    //bununla ilgili propfull yazark getirebilrisin kısayla ismini filan düzenlemek istersen üzerine gelip değişiklik yapıpı tap tuşu ile ilerle değişir zaten 

    //private string _name;  // Alan (field)

    //public string Name     // Özellik (property)
    //{
    //    get { return _name+"batman"; }    // Getter
    //    set { _name = value; }   // Setter
    //}

    
}