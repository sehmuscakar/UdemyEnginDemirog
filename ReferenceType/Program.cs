//int,decimal,float,enum,boolean value types

int sayi1 = 10;
int sayi2 = 20;

sayi1 = sayi2;

sayi2 = 100;
Console.WriteLine("Sayi 1 :" + sayi1);

//array, class, interface ... referance types // burda ki mesele new lendiği an başlar 
int[] sayilar1 = new int[] { 1, 2, 3, 4, 5, };
int[] sayilar2 = new int[] { 2, 4, 6, 8, 10 };

sayilar1 = sayilar2;

sayilar2[0] = 100;

Console.WriteLine(sayilar1[0]);

//C#'ta çöp toplayıcısı (Garbage Collector - GC), belleği otomatik olarak yönetmek için
//kullanılan bir mekanizmadır. Managed (yönetilen) dillerden biri olan C#, bellek yönetimini geliştiricinin
//manuel olarak yapmasına gerek kalmadan, çöp toplayıcısı aracılığıyla yönetir.



Person person1 = new Person(); //referans numarası veya adreaini değiştiriyoruz atamalarda o yüzden değişmiş olur 

person1.FirstName = "Şehmus";

Person person2 = new Person();


person2 = person1; //değer eşitlemesi değil adres aşitlemesi yapıyoruz burda 

person1.FirstName = "Ali";

Console.WriteLine(person2.FirstName);




Customer customer = new Customer();
Employee employee = new Employee();
employee.FirstName = "Muartttttt";

PersonManager personManager = new PersonManager();



personManager.Add(person1);


//Base class:Person

class Person
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
}

class Customer:Person
{
    public string CreditCardNumber { get; set; }
}

class Employee:Person
{

    public int EmployeeNumber { get; set; }
}

class PersonManager
{
    public void Add(Person person) //referans tipi avantajı sayesinde tek moetdla bu base bağlı olan claslarada eişreibliriz
    {
       Console.WriteLine(person.FirstName);
    }
}


