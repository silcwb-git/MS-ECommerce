using System;
using AutoMapper;
using ECommerce.Api.Orders.Db;
using ECommerce.Api.Orders.Interfaces;

namespace ECommerce.Api.Orders.Providers
{
    public class OrderItemsProvider : IOrderItemsProvider
    {
        public readonly OrdersDbContext dbContext;
        public readonly ILogger<OrderItemsProvider> logger;
        public readonly IMapper mapper;

        public OrderItemsProvider(OrdersDbContext dbContext, ILogger<OrderItemsProvider> logger, IMapper mapper)
        {
            this.dbContext = dbContext;
            this.logger = logger;
            this.mapper = mapper;

            SeedOrderItems();
        }

        private void SeedOrderItems()
        {
            dbContext.Add(new Db.OrderItem { Id = 1, OrderId = 1, ProductId = 2, Quantity = 1, UnitPrice = 10 });
            dbContext.Add(new Db.OrderItem { Id = 2, OrderId = 1, ProductId = 1, Quantity = 1, UnitPrice = 100 });
        }

        public Task<(bool IsSuccess, IEnumerable<Models.OrderItem> orderItems, string errorMessage)> GetOrderItemsAsync()
        {
            throw new NotImplementedException();
        }
    }
}

