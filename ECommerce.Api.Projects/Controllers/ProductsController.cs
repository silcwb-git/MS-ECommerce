﻿using System;
using Microsoft.AspNetCore.Mvc;
using MS_ECommerce.Interfaces;

namespace ECommerce.Api.Products.Controllers
{
    [ApiController]
    [Route("api/products")]

    public class ProductsController : ControllerBase
    {
        private readonly IProductsProvider productsProvider;

        public ProductsController(IProductsProvider productsProvider)
        {
            this.productsProvider = productsProvider;
        }

        [HttpGet]
        public async Task<IActionResult> GetProductsAsync()
        {
            var result = await productsProvider.GetProductsAsync();

            if (result.IsSuccess)
            {
                return Ok(result.products);
            }
            return NotFound();
        }
    }
}

