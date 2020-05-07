using ABC.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC.DataAccess.Concrete.EntityFramework.Mappings
{
    public class ProductMappping : EntityTypeConfiguration<Product>
    {
        public ProductMappping()
        {
            ToTable(@"Products", "dbo");
            HasKey(x => x.ProductId);

            Property(x => x.ProductId).HasColumnName("ProductID");
            Property(x => x.Name).HasColumnName("ProductName");
            Property(x => x.QuantityPerUnit).HasColumnName("QuantityperUnit");
            Property(x => x.UnitPrice).HasColumnName("UnitPrice");
            Property(x => x.UnitsInStock).HasColumnName("UnitsInStock");
        }
    }
}
