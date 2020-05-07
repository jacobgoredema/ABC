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
    public class ProductManager
    {
        private IProductDAL _productDal;

        public ProductManager(IProductDAL productDal)
        {
            _productDal = productDal;
        }

        public List<Product> GetProducts()
        {
            return _productDal.GetList();
        }
    }
}
