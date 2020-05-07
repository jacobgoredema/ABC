using ABC.Core.DataAccess;
using ABC.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC.DataAccess.Abstract
{
    public interface IProductDAL : IEntityRepository<Product>
    {

    }
}
