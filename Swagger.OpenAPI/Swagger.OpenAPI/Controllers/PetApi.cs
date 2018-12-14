using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using Swagger.OpenAPI.Models;
using Swagger.OpenAPI.Attributes;

namespace Swagger.OpenAPI.Controllers
{
    /// <summary>
    /// Pet API
    /// </summary>
    //[HideInDocsAttribute]
    public class PetApiController : Controller
    {

        /// <summary>
        /// Add a new pet to the store
        /// </summary>
        /// <param name="body">Pet object that needs to be added to the store</param>
        /// <response code="405">Invalid input</response>
        [HttpPost]
        [Route("/pet")]
        [ValidateModelState]
        [ApiExplorerSettings(IgnoreApi = true)]
        public virtual IActionResult AddPet([FromBody]Pet body)
        {
            // return StatusCode(405);
            throw new NotImplementedException();
        }

        /// <summary>
        /// Deletes a pet
        /// </summary>
        /// <param name="petId">Pet id to delete</param>
        /// <param name="apiKey"></param>
        /// <response code="400">Invalid pet value</response>
        [HttpDelete]
        [Route("/pet/{petId}")]
        [ValidateModelState]
        [ApiExplorerSettings(IgnoreApi = true)]
        public virtual IActionResult DeletePet([FromRoute][Required]long? petId, [FromHeader]string apiKey)
        {
            // return StatusCode(400);
            throw new NotImplementedException();
        }

        /// <summary>
        /// Finds Pets by status
        /// </summary>
        /// <remarks>Multiple status values can be provided with comma separated strings</remarks>
        /// <param name="status">Status values that need to be considered for filter</param>
        /// <response code="200">successful operation</response>
        /// <response code="400">Invalid status value</response>
        [HttpGet]
        [Route("/pet/findByStatus")]
        [ValidateModelState]
        [ApiExplorerSettings(IgnoreApi = true)]
        public virtual IActionResult FindPetsByStatus([FromQuery][Required()]List<string> status)
        {
            // return StatusCode(200, default(List<Pet>));
            // return StatusCode(400);
            string exampleJson = null;
            exampleJson = "<Pet>\n  <id>123456789</id>\n  <name>doggie</name>\n  <photoUrls>\n    <photoUrls>aeiou</photoUrls>\n  </photoUrls>\n  <tags>\n  </tags>\n  <status>aeiou</status>\n</Pet>";
            exampleJson = "[ {\n  \"photoUrls\" : [ \"photoUrls\", \"photoUrls\" ],\n  \"name\" : \"doggie\",\n  \"id\" : 0,\n  \"category\" : {\n    \"name\" : \"name\",\n    \"id\" : 6\n  },\n  \"tags\" : [ {\n    \"name\" : \"name\",\n    \"id\" : 1\n  }, {\n    \"name\" : \"name\",\n    \"id\" : 1\n  } ],\n  \"status\" : \"available\"\n}, {\n  \"photoUrls\" : [ \"photoUrls\", \"photoUrls\" ],\n  \"name\" : \"doggie\",\n  \"id\" : 0,\n  \"category\" : {\n    \"name\" : \"name\",\n    \"id\" : 6\n  },\n  \"tags\" : [ {\n    \"name\" : \"name\",\n    \"id\" : 1\n  }, {\n    \"name\" : \"name\",\n    \"id\" : 1\n  } ],\n  \"status\" : \"available\"\n} ]";

            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<List<Pet>>(exampleJson)
            : default(List<Pet>);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Finds Pets by tags
        /// </summary>
        /// <remarks>Multiple tags can be provided with comma separated strings. Use tag1, tag2, tag3 for testing.</remarks>
        /// <param name="tags">Tags to filter by</param>
        /// <response code="200">successful operation</response>
        /// <response code="400">Invalid tag value</response>
        [HttpGet]
        [Route("/pet/findByTags")]
        [ValidateModelState]
        [ApiExplorerSettings(IgnoreApi = true)]
        public virtual IActionResult FindPetsByTags([FromQuery][Required()]List<string> tags)
        {
            // return StatusCode(200, default(List<Pet>));
            // return StatusCode(400);
            string exampleJson = null;
            exampleJson = "<Pet>\n  <id>123456789</id>\n  <name>doggie</name>\n  <photoUrls>\n    <photoUrls>aeiou</photoUrls>\n  </photoUrls>\n  <tags>\n  </tags>\n  <status>aeiou</status>\n</Pet>";
            exampleJson = "[ {\n  \"photoUrls\" : [ \"photoUrls\", \"photoUrls\" ],\n  \"name\" : \"doggie\",\n  \"id\" : 0,\n  \"category\" : {\n    \"name\" : \"name\",\n    \"id\" : 6\n  },\n  \"tags\" : [ {\n    \"name\" : \"name\",\n    \"id\" : 1\n  }, {\n    \"name\" : \"name\",\n    \"id\" : 1\n  } ],\n  \"status\" : \"available\"\n}, {\n  \"photoUrls\" : [ \"photoUrls\", \"photoUrls\" ],\n  \"name\" : \"doggie\",\n  \"id\" : 0,\n  \"category\" : {\n    \"name\" : \"name\",\n    \"id\" : 6\n  },\n  \"tags\" : [ {\n    \"name\" : \"name\",\n    \"id\" : 1\n  }, {\n    \"name\" : \"name\",\n    \"id\" : 1\n  } ],\n  \"status\" : \"available\"\n} ]";

            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<List<Pet>>(exampleJson)
            : default(List<Pet>);
            return new ObjectResult(example);
        }

        /// <summary>
        /// Find pet by ID
        /// </summary>
        /// <remarks>Returns a single pet</remarks>
        /// <param name="petId">ID of pet to return</param>
        /// <response code="200">successful operation</response>
        /// <response code="400">Invalid ID supplied</response>
        /// <response code="404">Pet not found</response>
        [HttpGet]
        [Route("/pet/{petId}")]
        [ValidateModelState]
        public virtual IActionResult GetPetById([FromRoute][Required]long? petId)
        {
            // return StatusCode(200, default(Pet));
            // return StatusCode(400);

            // return StatusCode(404);

            string exampleJson = null;
            exampleJson = "<Pet>\n  <id>123456789</id>\n  <name>doggie</name>\n  <photoUrls>\n    <photoUrls>aeiou</photoUrls>\n  </photoUrls>\n  <tags>\n  </tags>\n  <status>aeiou</status>\n</Pet>";
            exampleJson = "{\n  \"photoUrls\" : [ \"photoUrls\", \"photoUrls\" ],\n  \"name\" : \"doggie\",\n  \"id\" : 0,\n  \"category\" : {\n    \"name\" : \"name\",\n    \"id\" : 6\n  },\n  \"tags\" : [ {\n    \"name\" : \"name\",\n    \"id\" : 1\n  }, {\n    \"name\" : \"name\",\n    \"id\" : 1\n  } ],\n  \"status\" : \"available\"\n}";

            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<Pet>(exampleJson)
            : default(Pet);
            return new ObjectResult(example);
        }

        /// <summary>
        /// Update an existing pet
        /// </summary>
        /// <param name="body">Pet object that needs to be added to the store</param>
        /// <response code="400">Invalid ID supplied</response>
        /// <response code="404">Pet not found</response>
        /// <response code="405">Validation exception</response>
        [HttpPut]
        [Route("/pet")]
        [ValidateModelState]
        public virtual IActionResult UpdatePet([FromBody]Pet body)
        {
            // return StatusCode(400);         
            // return StatusCode(404);            
            // return StatusCode(405);
            throw new NotImplementedException();
        }

        /// <summary>
        /// Updates a pet in the store with form data
        /// </summary>
        /// <param name="petId">ID of pet that needs to be updated</param>
        /// <param name="name">Updated name of the pet</param>
        /// <param name="status">Updated status of the pet</param>
        /// <response code="405">Invalid input</response>
        [HttpPost]
        [Route("/pet/{petId}")]
        [ValidateModelState]
        public virtual IActionResult UpdatePetWithForm([FromRoute][Required]long? petId, [FromForm]string name, [FromForm]string status)
        {
            // return StatusCode(405);
            throw new NotImplementedException();
        }

        /// <summary>
        /// uploads an image
        /// </summary>
        /// <param name="petId">ID of pet to update</param>
        /// <param name="additionalMetadata">Additional data to pass to server</param>
        /// <param name="file">file to upload</param>
        /// <response code="200">successful operation</response>
        [HttpPost]
        [Route("/pet/{petId}/uploadImage")]
        [ValidateModelState]
        public virtual IActionResult UploadFile([FromRoute][Required]long? petId, [FromForm]string additionalMetadata, [FromForm]System.IO.Stream file)
        {
            // return StatusCode(200, default(ApiResponse));

            string exampleJson = null;
            exampleJson = "{\n  \"code\" : 0,\n  \"type\" : \"type\",\n  \"message\" : \"message\"\n}";

            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<ApiResponse>(exampleJson)
            : default(ApiResponse);
            return new ObjectResult(example);
        }
    }
}
