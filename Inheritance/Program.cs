
//mesele bir annenin evi cocuklarıın sayılabilir ama bir annenin kazağı çocuğunun sayılmaz burdaki mantık bu şekil düşünülebilinir


PersonManager personManager = new PersonManager();
personManager.Add();

CustomerManager customerManager = new CustomerManager();
customerManager.GetBestCustomer();

EmployeeManager employeeManager = new EmployeeManager();
employeeManager.GetBestEmployee();


class PersonManager//genel
{
    public void Add()
    {
        Console.WriteLine("Eklendi");
    }
    public void Upadete()
    {
        Console.WriteLine("Güncellendi");
    }

}

class CustomerManager : PersonManager//müşteri
{
    public void GetBestCustomer()
    {

    }
}

class EmployeeManager : PersonManager
{
    public void GetBestEmployee()
    {

    }
}

class Person
{
    public int Id { get; set; }
    public string NationalIdentity { get; set; }//TCNo
    public string FirstName { get; set; }
    public string LastName { get; set; }

}

class Emmployee:Person
{
    public string EmployeeNumber { get; set; }

}
class Customer
{
    public int CreditCardNumber { get; set; }
}