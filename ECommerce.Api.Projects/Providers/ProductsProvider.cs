using MS_ECommerce.Db;
using MS_ECommerce.Interfaces;
using MS_ECommerce.Models;
using AutoMapper;

namespace MS_ECommerce.Providers
{
    public class ProductsProvider : IProductsProvider
    {
        private readonly ProductsDbContext dbContext;
        private readonly ILogger<ProductsProvider> logger;
        private readonly IMapper mapper;

        public ProductsProvider(ProductsDbContext dbContext, ILogger<ProductsProvider> logger, IMapper mapper)
        {
            this.dbContext = dbContext;
            this.logger = logger;
            this.mapper = mapper;

            SeedData();
        }

        private void SeedData()
        {
            if (dbContext.Products.Any())
            {
                dbContext.Add(new Db.Product() { Id = 1, Name = "MacBookPro", Price = 12000, Inventory = 100 });
                dbContext.Add(new Db.Product() { Id = 2, Name = "Mouse", Price = 10, Inventory = 150 });
                dbContext.Add(new Db.Product() { Id = 3, Name = "Keyboard", Price = 20, Inventory = 100 });
                dbContext.Add(new Db.Product() { Id = 4, Name = "Monitor", Price = 1000, Inventory = 30 });
                dbContext.SaveChanges();

            }
        }

        public Task<(bool IsSuccess, IEnumerable<Models.Product> products, string ErrorMessage)> GetProductsAsync()
        {
            throw new NotImplementedException();
        }
    }
}

