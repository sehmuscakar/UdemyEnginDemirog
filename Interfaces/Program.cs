// See https://aka.ms/new-console-template for more information
using System.Runtime.InteropServices;

Console.WriteLine("Hello, World!");
//interfaceler new' lenemez

//sen interfaceyi new leyemezsin sadece tutuğu adres(referans) yerini newleyebilirisn buda hangi adresi newlersen ona göre ilgili kodlar çalışır.





IPersonManager personManager = new CustomerManager(); // burda new lendiğinde heap te bir alan oluşur ve ilegili kodlar çalışır
personManager.Add(); 



ProjectManager projectManager = new ProjectManager();   //dolayısıyla bu şekil sen daha da kontrol altına alabilirsin
projectManager.Add(new CustomerManager());//  sen burda aslında IPersonManager personManager= new CustomerManager(); şu şekilde yapıyorsun 







//class PersonManager
//{//implemented opreation //yani içi doldurulmuş metohod
//    public void Add()
//    {
//        Console.WriteLine("Eklendi.");  
//    }
//}

//class CustomerManager:PersonManager // burda ki kullanılan metot aynı direk ortak yukardaki ile ama interfacede öyle değil .class ta inherits
//{
//}

interface IPersonManager
{
    //unimplemented opreation //yani içi doldurulmamış metohod
    void Add(); //erişim belirticine gerek yok zaten default olarak public tir 
    void Update();
}

class CustomerManager : IPersonManager // interface de implements
{
    public void Add()
    {
        Console.WriteLine("müşteri eklendi");
    }

    public void Update()
    {
        Console.WriteLine("müşteri güncellendi");
    }
}

class EmployeeManager : IPersonManager
{
    public void Add()
    {
        Console.WriteLine("personel eklendi");

    }

    public void Update()
    {
        Console.WriteLine("personel güncellendi");

    }
}

class ProjectManager
{
    public void Add(IPersonManager personManager1)
    {
        personManager1.Add();
    }
}