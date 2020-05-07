using ABC.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ABC.Entity.Concrete;

namespace ABC.DataAccess.Concrete.EntityFramework
{
    public class EfProductDAL : IProductDAL
    {
        public List<Product> GetList()
        {
            throw new NotImplementedException();
        }
    }
}
