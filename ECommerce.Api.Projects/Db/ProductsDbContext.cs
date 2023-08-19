
using System;
using Microsoft.EntityFrameworkCore;

namespace MS_ECommerce.Db
{
	public class ProductsDbContext: DbContext
	{
		public DbSet<Product> Products { get; set; }

		public ProductsDbContext(DbContextOptions options): base(options)
		{

		}
	}
}

