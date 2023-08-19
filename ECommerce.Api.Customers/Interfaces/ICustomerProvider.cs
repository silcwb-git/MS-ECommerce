using System;
namespace ECommerce.Api.Customers.Interfaces
{
    public interface ICustomerProvider
    {
        Task<bool IsSuccess, IEnumerable<Customer>>
    }
}

