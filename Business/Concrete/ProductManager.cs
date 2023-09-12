using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Concrete.InMemory;
using DataAccess.Abstract;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        private IProductDal _productDal;//_productDal a ampulden generate constructor dediğimizde alttaki injection geliyor

        public ProductManager(IProductDal productDal)//burası constructor injection yaptığımız yer
        {
            _productDal = productDal;
        }

        public List<Product> GetAll()
        {
            //İş kodları burada yazılıyor
            return _productDal.GetAll();
        }

        public List<Product> GetAllByCategoryId(int id)
        {
            return _productDal.GetAll(p => p.CategoryId == id);
        }

        public List<Product> GetByUnitPrice(decimal min, decimal max)
        {
            return _productDal.GetAll(p=>p.UnitPrice >= min && p.UnitPrice <= max);
        }
    }
}
