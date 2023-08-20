using System;
using AutoMapper;
using ECommerce.Api.Customers.Db;
using ECommerce.Api.Customers.Interfaces;
using ECommerce.Api.Customers.Models;

namespace ECommerce.Api.Customers.Providers
{
    public class CustomersProvider : ICustomerProvider
    {
        private readonly CustomersDbContext dbContext;
        private readonly ILogger<CustomersProvider> logger;
        private readonly IMapper mapper;

        public CustomersProvider(CustomersDbContext dbContext, ILogger<CustomersProvider> logger, IMapper mapper)
        {
            this.dbContext = dbContext;
            this.logger = logger;
            this.mapper = mapper;

            SeedCustomerData();
        }

        private void SeedCustomerData()
        {
            if (dbContext.Customers.Any())

            {
                dbContext.Add(new Db.Customer { Id = 1, Name = "abcde", Address = "abcd" });
                dbContext.Add(new Db.Customer { Id = 2, Name = "eu sou", Address = "aaa" });
                dbContext.Add(new Db.Customer { Id = 3, Name = "mãe", Address = "bbbbb" });
                dbContext.SaveChanges();
            }
        }

        public Task<(bool IsSuccess, IEnumerable<Models.Customer> customers, string errorMessage)> GetCustomersAsync()
        {
            throw new NotImplementedException();
        }
    }
}

