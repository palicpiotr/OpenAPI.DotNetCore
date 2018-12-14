using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.SwaggerGen;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using Swagger.OpenAPI.Attributes;
using Swagger.OpenAPI.Models;

namespace IO.Swagger.Controllers
{
    /// <summary>
    /// User API
    /// </summary>
    //[Produces("text/json", "application/json")]
    //[ShowInDocs]
    public class UserApiController : Controller
    {
        /// <summary>
        /// Create user
        /// </summary>
        /// <remarks>This can only be done by the logged in user.</remarks>
        /// <param name="body">Created user object</param>
        /// <response code="0">successful operation</response>
        [HttpPost]
        [Route("/user")]
        [ValidateModelState]
        [HideInDocsAttribute]
        public virtual IActionResult CreateUser([FromBody]User body)
        {
            // return StatusCode(0);
            throw new NotImplementedException();
        }

        /// <summary>
        /// Creates list of users with given input array
        /// </summary>
        /// <param name="body">List of user object</param>
        /// <response code="0">successful operation</response>
        [HttpPost]
        [Route("/user/createWithArray")]
        [ValidateModelState]
        [HideInDocsAttribute]
        public virtual IActionResult CreateUsersWithArrayInput([FromBody]List<User> body)
        {
            // return StatusCode(0);
            throw new NotImplementedException();
        }

        /// <summary>
        /// Creates list of users with given input array
        /// </summary>
        /// <param name="body">List of user object</param>
        /// <response code="0">successful operation</response>
        [HttpPost]
        [Route("/user/createWithList")]
        [ValidateModelState]
        [HideInDocsAttribute]
        public virtual IActionResult CreateUsersWithListInput([FromBody]List<User> body)
        {
            // return StatusCode(0);
            throw new NotImplementedException();
        }

        /// <summary>
        /// Delete user
        /// </summary>
        /// <remarks>This can only be done by the logged in user.</remarks>
        /// <param name="username">The name that needs to be deleted</param>
        /// <response code="400">Invalid username supplied</response>
        /// <response code="404">User not found</response>
        [HttpDelete]
        [Route("/user/{username}")]
        [ValidateModelState]
        public virtual IActionResult DeleteUser([FromRoute][Required]string username)
        {
            // return StatusCode(400);            
            // return StatusCode(404);
            throw new NotImplementedException();
        }

        /// <summary>
        /// Get user by user name
        /// </summary>
        /// <param name="username">The name that needs to be fetched. Use user1 for testing.</param>
        /// <response code="200">successful operation</response>
        /// <response code="400">Invalid username supplied</response>
        /// <response code="404">User not found</response>
        [HttpGet]
        [Route("/user/{username}")]
        [ValidateModelState]
        public virtual IActionResult GetUserByName([FromRoute][Required]string username)
        {
            // return StatusCode(200, default(User));
            // return StatusCode(400);
            // return StatusCode(404);
            string exampleJson = null;
            exampleJson = "<User>\n  <id>123456789</id>\n  <username>aeiou</username>\n  <firstName>aeiou</firstName>\n  <lastName>aeiou</lastName>\n  <email>aeiou</email>\n  <password>aeiou</password>\n  <phone>aeiou</phone>\n  <userStatus>123</userStatus>\n</User>";
            exampleJson = "{\n  \"firstName\" : \"firstName\",\n  \"lastName\" : \"lastName\",\n  \"password\" : \"password\",\n  \"userStatus\" : 6,\n  \"phone\" : \"phone\",\n  \"id\" : 0,\n  \"email\" : \"email\",\n  \"username\" : \"username\"\n}";

            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<User>(exampleJson)
            : default(User);
            return new ObjectResult(example);
        }

        /// <summary>
        /// Logs user into the system
        /// </summary>
        /// <param name="username">The user name for login</param>
        /// <param name="password">The password for login in clear text</param>
        /// <param name="parameter">This parameter can be null</param>
        /// <response code="200">successful operation</response>
        /// <response code="400">Invalid username/password supplied</response>
        [HttpGet]
        [Route("/user/login")]
        [ValidateModelState]
        [ProducesResponseType(typeof(User), 400)]
        [ProducesResponseType(typeof(User), 200)]
        public virtual IActionResult LoginUser([FromQuery][Required()]string username, [FromQuery][Required()]string password, [FromQuery][HideInDocs]string parameter)
        {
            // return StatusCode(200, default(string));
            // return StatusCode(400);

            string exampleJson = null;
            exampleJson = "aeiou";
            exampleJson = "\"\"";

            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<string>(exampleJson)
            : default(string);
            return new ObjectResult(example);
        }

        /// <summary>
        /// Logs out current logged in user session
        /// </summary>
        /// <response code="0">successful operation</response>
        [HttpGet]
        [Route("/user/logout")]
        [ValidateModelState]
        public virtual IActionResult LogoutUser()
        {
            // return StatusCode(0);
            throw new NotImplementedException();
        }

        /// <summary>
        /// Updated user
        /// </summary>
        /// <remarks>This can only be done by the logged in user.</remarks>
        /// <param name="username">name that need to be deleted</param>
        /// <param name="body">Updated user object</param>
        /// <response code="400">Invalid user supplied</response>
        /// <response code="404">User not found</response>        
        [HttpPut]
        [Route("/user/{username}")]
        [ValidateModelState]
        [ProducesResponseType(typeof(User), 400)]
        [ProducesResponseType(typeof(User), 404)]
        public virtual IActionResult UpdateUser([FromRoute][Required]string username, [FromBody]User body)
        {
            // return StatusCode(400);
            // return StatusCode(404);
            throw new NotImplementedException();
        }
    }
}
