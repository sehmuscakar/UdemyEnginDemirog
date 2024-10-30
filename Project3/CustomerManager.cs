using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3
{
    public class CustomerManager //javada burda Service isimlendirilmesi kullanılır ama burda da yazılabilir
    {
        public CustomerManager()
        {
            customers = new List<Customer>()
            {
                new Customer{Id=1,FirstName="şehmus",LastName="çakar",City="Ankara",Email="@sehmus"},
                new Customer{Id=1,FirstName="murat",LastName="gömüş",City="batman",Email="@murat"},
                new Customer{Id=1,FirstName="ali",LastName="bakır",City="urfa",Email="@ali"},
                new Customer{Id=1,FirstName="merve",LastName="demiz",City="kilis",Email="@merve"},
                new Customer{Id=1,FirstName="ayşe",LastName="yıldız",City="kars",Email="@ayse"},
                new Customer{Id=1,FirstName="kevser",LastName="kara",City="siirt",Email="@kevser"},
                new Customer{Id=1,FirstName="halil",LastName="ak",City="istanbul",Email="@halil"}
            };
        }

        List<Customer> customers;
        public List<Customer> GetAll() // bu metot listfocustomer dönmek zorunda buda aşahıda hazır halde getidiğimiz datayı dönebilir
        {
            //gerçek hayata 
            //Veritabanına bağlanıyoruz
            //ve verilerimizi çekiyoruz
            //şuan kendi yazdığımız listelerle  çalışcaz

            //  List<Customer> customers = new List<Customer>() //bu bir liste listenin içindeki elemenaları da bir dizi gibi hızlıca yazabilirsinşz
         
            return customers;//senin metotdundaki imza hangi tipteyse o türde dündürmek zorundasın
        }
        public void Add(Customer customer)
        {
            customers.Add(customer);
        }

    }
}
