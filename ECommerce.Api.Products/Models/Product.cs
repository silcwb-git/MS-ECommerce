using System;
namespace MS_ECommerce.Models
{
    // class created for database access
    public class Product
    {
        public int Id { get; set; }

        public required string Name { get; set; }

        public decimal Price { get; set; }

        public int Inventory { get; set; }
    }
}

