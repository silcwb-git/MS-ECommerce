using System;
using ECommerce.Api.Orders.Models;

namespace ECommerce.Api.Orders.Interfaces
{
    public interface IOrderItems
    {
        Task<(bool IsSuccess, IEnumerable<OrderItem> orderItems, string errorMessage)> GetOrderItemsAsync();
    }
}

