﻿using ABC.BusinessLayer.Abstract;
using ABC.BusinessLayer.ValidationRules.FluentValidation;
using ABC.Core.Aspects.PostSharp.ValidationAspects;
using ABC.Core.CrossCuttingConcerns.Validation.FluentValidation;
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

        [FluentValidationAspect(typeof(ProductValidator))]
        public void Add(Product product)
        {
            //AOP Aspect Oriented Programming
           // ValidationTool.FluentValidate(new ProductValidator(), product);

            // Business rules
            _productDal.Add(product);
        }

        public void Delete(Product product)
        {
            _productDal.Delete(product);
        }

        public List<Product> GetAll()
        {
            return _productDal.GetList().ToList();
        }

        public List<Product> GetAllbyCategory(int categoryId)
        {
            return _productDal.GetList(p => p.CategoryId == categoryId).ToList();
        }

        public List<Product> GetProducts()
        {
            return _productDal.GetList();
        }

        public void Update(Product product)
        {
            _productDal.Update(product);
        }
    }
}
