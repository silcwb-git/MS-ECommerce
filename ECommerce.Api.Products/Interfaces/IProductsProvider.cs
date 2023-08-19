using System;
using MS_ECommerce.Models;
using System.Collections.Generic;

namespace MS_ECommerce.Interfaces
{
    public interface IProductsProvider
    {
        Task<(bool IsSuccess, IEnumerable<Product> products, string ErrorMessage)> GetProductsAsync();
    }
}

