using ABC.BusinessLayer.Abstract;
using ABC.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ABC.WebAPI.Controllers
{
    public class ProductsController : ApiController
    {
        IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        // Get: Product

        public List<Product> Get()
        {
            return _productService.GetAll();
        }
    }
}
