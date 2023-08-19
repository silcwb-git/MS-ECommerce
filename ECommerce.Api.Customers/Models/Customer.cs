using System;
namespace ECommerce.Api.Customers.Models
{
    public class Customer
    {
        public int Id { get; set; }

        public required string Name { get; set; }

        public required string Address { get; set; }
    }
}

