using ABC.BusinessLayer.Abstract;
using ABC.DataAccess.Abstract;
using ABC.DataAccess.Concrete.EntityFramework;
using ABC.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC.BusinessLayer.Concrete
{
    public class ProductManager:IProductService
    {
        private IProductDAL _productDal;

        public ProductManager(IProductDAL productDal)
        {
            _productDal = productDal;
        }

        public void Add(Product product)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product product)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllbyCategory(int categoryId)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetProducts()
        {
            return _productDal.GetList();
        }

        public void Update(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
