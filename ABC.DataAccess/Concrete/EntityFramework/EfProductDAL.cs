using ABC.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ABC.Entity.Concrete;
using System.Linq.Expressions;
using ABC.Core.DataAccess;
using ABC.DataAccess.Concrete.EntityFramework.Context;
using ABC.Core.DataAccess.EntityFramework;

namespace ABC.DataAccess.Concrete
{
    public class EfProductDAL : EfEntityRepositoryBase<Product, NorthwindContext>, IProductDAL
    {
        // special methods related to product
    }
}
