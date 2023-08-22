using System;
using ECommerce.Api.Customers.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.Api.Customers.Controllers
{
    [ApiController]
    [Route("api/customers")]
    public class CustomersController : ControllerBase
    {
        private readonly ICustomerProvider customersProvider;

        public CustomersController(ICustomerProvider customerProvider)
        {
            this.customersProvider = customersProvider;
        }

        [HttpGet]
        public async Task<IActionResult> GetCustomersAsybc()
        {
            var result = await customersProvider.GetCustomersAsync();

            if (result.IsSuccess)
            {
                return Ok(result.customers);
            }
            return NotFound();
        }
    }
}


