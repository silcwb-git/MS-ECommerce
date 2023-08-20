using System;
using AutoMapper;
using ECommerce.Api.Orders.Db;
using ECommerce.Api.Orders.Interfaces;
using ECommerce.Api.Orders.Models;

namespace ECommerce.Api.Orders.Providers
{
    public class OrdersProvider : IOrdersProvider
    {
        public readonly OrdersDbContext dbContext;
        public readonly ILogger<OrdersProvider> logger;
        public readonly IMapper mapper;

        public OrdersProvider(OrdersDbContext dbContext, ILogger<OrdersProvider> logger, IMapper mapper)
        {
            this.dbContext = dbContext;
            this.logger = logger;
            this.mapper = mapper;

            SeedOrdersData();
        }

        private void SeedOrdersData()
        {
            dbContext.Add(new Db.Order { Id = 1, CustomerId = 1, Items = 2, OrderDate = DateTime.Parse("12/04/2023 12:08:33"), Total = 10 });
            dbContext.Add(new Db.Order { Id = 1, CustomerId = 2, Items = 1, OrderDate = DateTime.Parse("01/02/2019 12:08:33"), Total = 100 });
        }

        public Task<(bool IsSuccess, IEnumerable<Models.Order> orders, string errorMessage)> GetOrdersAsync()
        {
            throw new NotImplementedException();
        }
    }
}

