using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using Swagger.OpenAPI.Attributes;
using StackExchange.Redis;

namespace IO.Swagger.Controllers
{
    /// <summary>
    /// Store API
    /// </summary>
    [HideInDocsAttribute]
    public class StoreApiController : Controller
    {
        /// <summary>
        /// Delete purchase order by ID
        /// </summary>
        /// <remarks>For valid response try integer IDs with value &lt; 1000. Anything above 1000 or nonintegers will generate API errors</remarks>
        /// <param name="orderId">ID of the order that needs to be deleted</param>
        /// <response code="400">Invalid ID supplied</response>
        /// <response code="404">Order not found</response>
        [HttpDelete]
        [Route("/store/order/{orderId}")]
        [ValidateModelState]        
        public virtual IActionResult DeleteOrder([FromRoute][Required]string orderId)
        {   
            // return StatusCode(400);         
            // return StatusCode(404);
            throw new NotImplementedException();
        }

        /// <summary>
        /// Returns pet inventories by status
        /// </summary>
        /// <remarks>Returns a map of status codes to quantities</remarks>
        /// <response code="200">successful operation</response>
        [HttpGet]
        [Route("/store/inventory")]
        [ValidateModelState]
        public virtual IActionResult GetInventory()
        {
            // return StatusCode(200, default(Dictionary<string, int?>));
            string exampleJson = null;
            exampleJson = "{\n  \"key\" : 0\n}";

            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<Dictionary<string, int?>>(exampleJson)
            : default(Dictionary<string, int?>);
            return new ObjectResult(example);
        }

        /// <summary>
        /// Find purchase order by ID
        /// </summary>
        /// <remarks>For valid response try integer IDs with value &lt;&#x3D; 5 or &gt; 10. Other values will generated exceptions</remarks>
        /// <param name="orderId">ID of pet that needs to be fetched</param>
        /// <response code="200">successful operation</response>
        /// <response code="400">Invalid ID supplied</response>
        /// <response code="404">Order not found</response>
        [HttpGet]
        [Route("/store/order/{orderId}")]
        [ValidateModelState]
        public virtual IActionResult GetOrderById([FromRoute][Required][Range(1, 5)]long? orderId)
        {
            // return StatusCode(200, default(Order));            
            // return StatusCode(400);            
            // return StatusCode(404);

            string exampleJson = null;
            exampleJson = "<Order>\n  <id>123456789</id>\n  <petId>123456789</petId>\n  <quantity>123</quantity>\n  <shipDate>2000-01-23T04:56:07.000Z</shipDate>\n  <status>aeiou</status>\n  <complete>true</complete>\n</Order>";
            exampleJson = "{\n  \"petId\" : 6,\n  \"quantity\" : 1,\n  \"id\" : 0,\n  \"shipDate\" : \"2000-01-23T04:56:07.000+00:00\",\n  \"complete\" : false,\n  \"status\" : \"placed\"\n}";

            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<Order>(exampleJson)
            : default(Order);
            return new ObjectResult(example);
        }

        /// <summary>
        /// Place an order for a pet
        /// </summary>
        /// <param name="body">order placed for purchasing the pet</param>
        /// <response code="200">successful operation</response>
        /// <response code="400">Invalid Order</response>
        [HttpPost]
        [Route("/store/order")]
        [ValidateModelState]
        public virtual IActionResult PlaceOrder([FromBody]Order body)
        {
            // return StatusCode(200, default(Order));            
            // return StatusCode(400);
            string exampleJson = null;
            exampleJson = "<Order>\n  <id>123456789</id>\n  <petId>123456789</petId>\n  <quantity>123</quantity>\n  <shipDate>2000-01-23T04:56:07.000Z</shipDate>\n  <status>aeiou</status>\n  <complete>true</complete>\n</Order>";
            exampleJson = "{\n  \"petId\" : 6,\n  \"quantity\" : 1,\n  \"id\" : 0,\n  \"shipDate\" : \"2000-01-23T04:56:07.000+00:00\",\n  \"complete\" : false,\n  \"status\" : \"placed\"\n}";

            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<Order>(exampleJson)
            : default(Order);
            return new ObjectResult(example);
        }
    }
}
