using ABC.BusinessLayer.Abstract;
using ABC.BusinessLayer.Concrete;
using ABC.DataAccess.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC.ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            IProductService productService = new ProductManager(new EfProductDAL());

            foreach (var product in productService.GetAll())
            {
                Console.WriteLine(product.Name);
            }
            Console.ReadLine();
        }
    }
}
