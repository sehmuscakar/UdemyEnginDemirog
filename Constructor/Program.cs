

//Customer customer1 = new Customer() { Id=1,FirstName="şehmus",LastName="çakar",City="diyarbekr"};
//Customer customer2 = new Customer { Id=2,FirstName="murat",LastName="akın",City="adana"};
//Customer customer3 = new Customer ();
//customer3.Id = 3;
//customer3.FirstName = "merve";
//customer3.LastName = "güzel";
//customer3.City = "malatya"; // bu üç instance da aynı görevii görüyor verileri dolduryor 

Customer customer4 = new Customer(4, "akın", "yeliz", "muş");

Console.WriteLine(customer4.FirstName);



class Customer
{
    public Customer(int Id,string firtsName,string lastName,string city)
    {
        Console.WriteLine("Yapıcı Fonksiyon çalıştı");
        FirstName = firtsName; //atama işlmelerini yapmadan önce kontrol edebilirsin 
    }

    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string City { get; set; }
}