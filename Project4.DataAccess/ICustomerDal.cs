using Project4.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project4.DataAccess
{
    public interface ICustomerDal : IEntityRepository<Customer>
    {
        //eğer generic yapı kullanamazsan böyle tek tek yazmak zorunda kalırsın 
        //List<Customer> GetAll();

        //List<Customer> Get(int id);
        //void Add(Customer custamer);

        //void Update(Customer custamer);

        //void Delete(Customer custamer);
    }
}
