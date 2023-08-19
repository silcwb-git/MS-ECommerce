using Microsoft.EntityFrameworkCore;

namespace MS_ECommerce.Db
{
    public class ProductsDbContext : DbContext
    {
        public ISet<Product> Products { get; set; }


        public ProductsDbContext(DbContextOptions options) : base(options)
        {

        }
    }
}

