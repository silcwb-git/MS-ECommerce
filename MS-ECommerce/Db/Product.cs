using System;
namespace MS_ECommerce.Db
{
	public class Product
	{
		public int Id { get; set; }
		public required string Name { get; set; }
		public decimal Price { get; set; }
		public int Inventory { get; set; }
	}
}

