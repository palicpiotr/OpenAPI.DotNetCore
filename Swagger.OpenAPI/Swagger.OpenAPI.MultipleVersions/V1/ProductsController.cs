﻿using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace Swagger.OpenAPI.MultipleVersions.V1
{
    [ApiVersion("1")]
    [ApiVersion("2")]
    [Route("v{version:apiVersion}/products")]
    [Produces("application/json")]
    public class ProductsController
    {
        [HttpGet]
        public IEnumerable<Product> GetAll() =>
         new[]
            {
                new Product { Id = 1, Description = "A product" },
                new Product { Id = 2, Description = "Another product" },
            };

        [HttpGet("{id}")]
        public Product GetById(int id) => new Product { Id = id, Description = "A product" };

    }

    public class Product
    {
        public int Id { get; set; }
        public string Description { get; set; }
    }
}