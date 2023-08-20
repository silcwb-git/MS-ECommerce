using System;
using ECommerce.Api.Orders.Models;

namespace ECommerce.Api.Orders.Interfaces
{
    public interface IOrderItemsProvider
    {
        Task<(bool IsSuccess, IEnumerable<OrderItem> orderItems, string errorMessage)> GetOrderItemsAsync();
    }
}

