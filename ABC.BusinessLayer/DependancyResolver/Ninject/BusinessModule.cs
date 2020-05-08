using ABC.BusinessLayer.Abstract;
using ABC.BusinessLayer.Concrete;
using ABC.DataAccess.Abstract;
using ABC.DataAccess.Concrete;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC.BusinessLayer.DependancyResolver.Ninject
{
    public class BusinessModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IProductService>().To<ProductManager>();
            Bind<IProductDAL>().To<EfProductDAL>();
        }
    }
}
