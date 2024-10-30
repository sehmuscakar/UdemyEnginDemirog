using Project4.DataAccess;
using Project4.Entities;

namespace Project4.Business
{
    //yazdığımız kodları refactor edecez yani kodları değiştirecez en uygun halie getiecez gibi bir anlamı var herhalde
    public class ProductManager : IProductService
    {
        IProductDal _productDal;
        public ProductManager(IProductDal productDal)//burda dışarıdan gleen yani hangi katmandan çağırılmışsa new lenmişse
        {
            _productDal = productDal;
        }

        public void Add(Product product)
        {
            if (product.ProductName=="Laptop")
            {
                throw new Exception("Laptop ekleyemezsiniz");
            }
            _productDal.Add(product);
        }

        public List<Product> GetAll()
        {
            //    ProductDal productDal = new ProductDal();
            // EfProductDal efProductDal = new EfProductDal(); //burda ayrı ayrı herzaman gidip classları değiştirmeyiz zor olur bunun yerine daha sürdürelebilirlik için interfacelerden gideriz ctordan paremtre göndeririz ınterfaceyi

            // burada iş kodları yazılr 
            // return productDal.GetAll();
            return _productDal.GetAll();
        }
    }
}
