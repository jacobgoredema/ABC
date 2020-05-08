using ABC.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC.BusinessLayer.Abstract
{
    public interface IProductService
    {
        List<Product> GetAll();
        List<Product> GetAllbyCategory(int categoryId);
        void Add(Product product);
        void Delete(Product product);
        void Update(Product product);
    }
}
