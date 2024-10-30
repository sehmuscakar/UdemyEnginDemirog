using Project4.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project4.DataAccess
{
    public class EfProductDal : IProductDal
    {
        List<Product> _products;//(field)
        public EfProductDal()
        {
            _products = new List<Product>() //bunun içinde eğer bişey yoksa daha boştur biz şablonu oluşturduk içini doldurmadık daha , bu aslında List<ProductDal> _product=new List<Product>
            {
                new Product{Id=1,ProductName="Acer EF Bilgisiyar",QuantityPerUnit="32 Gb Ram",UnitPrice=10000,UnitsInStock=2},
                new Product{Id=2,ProductName="Asus EF Bilgisiyar",QuantityPerUnit="32 Gb Ram",UnitPrice=10000,UnitsInStock=3},
                new Product{Id=3,ProductName="HP EF Bilgisiyar",QuantityPerUnit="32 Gb Ram",UnitPrice=10000,UnitsInStock=4},
                new Product{Id=4,ProductName="MAC EF Bilgisiyar",QuantityPerUnit="32 Gb Ram",UnitPrice=10000,UnitsInStock=5},
                new Product{Id=5,ProductName="Dell EF Bilgisiyar",QuantityPerUnit="32 Gb Ram",UnitPrice=10000,UnitsInStock=6}
            };
        }

        public void Add(Product product)
        {
            Console.WriteLine("EF ile eklendi");
        }

        public void Delete(Product entity)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Product entity)
        {
            throw new NotImplementedException();
        }
    }
}
