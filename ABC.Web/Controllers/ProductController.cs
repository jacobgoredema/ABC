using ABC.BusinessLayer.Abstract;
using ABC.BusinessLayer.Concrete;
using ABC.DataAccess.Concrete;
using ABC.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ABC.Web.Controllers
{
    public class ProductController : Controller
    {
        IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        // GET: Product
        public ActionResult Index()
        {
            IProductService productService = new ProductManager(new EfProductDAL());
            var model = new ProductListVm
            {
                Products=productService.GetAll()
            };
            return View(model);
        }
    }
}