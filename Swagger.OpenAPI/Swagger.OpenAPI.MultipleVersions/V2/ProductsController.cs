using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Swagger.OpenAPI.MultipleVersions.V1;

namespace Swagger.OpenAPI.MultipleVersions.V2
{
    [ApiVersion("2")]
    [Route("v{version:apiVersion}/products")]
    [Produces("application/json")]
    public class ProductsController
    {
        [HttpPost]
        public int Create([FromBody, Required]Product product) => 1;


        [HttpPut("{id}")]
        public void Update(int id, [FromBody, Required]Product product)
        { }

        [HttpDelete("{id}")]
        public void Delete(int id)
        { }
    }
}