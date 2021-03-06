/*
 * MailChampApi
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: v1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using Swashbuckle.AspNetCore.SwaggerGen;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using IO.Swagger.Attributes;
using Microsoft.AspNetCore.Authorization;
using IO.Swagger.Models;

namespace IO.Swagger.Controllers
{ 
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    public class MailingsApiController : ControllerBase
    { 
        /// <summary>
        /// Gets the requested mailing.
        /// </summary>
        /// <param name="mailingId"></param>
        /// <response code="200">Success</response>
        /// <response code="404">Not Found</response>
        [HttpGet]
        [Route("/Mailings/{mailingId}")]
        [ValidateModelState]
        [SwaggerOperation("MailingsMailingIdGet")]
        [SwaggerResponse(statusCode: 200, type: typeof(Mailing), description: "Success")]
        [SwaggerResponse(statusCode: 404, type: typeof(Models.ProblemDetails), description: "Not Found")]
        public virtual IActionResult MailingsMailingIdGet([FromRoute][Required]int? mailingId)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(Mailing));

            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404, default(ProblemDetails));
            string exampleJson = null;
            exampleJson = "{\n  \"dateCreated\" : \"2000-01-23T04:56:07.000+00:00\",\n  \"dateModified\" : \"2000-01-23T04:56:07.000+00:00\",\n  \"mailingId\" : 0,\n  \"mailingName\" : \"mailingName\"\n}";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<Mailing>(exampleJson)
                        : default(Mailing);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Updates the name of the selected mailing.
        /// </summary>
        /// <param name="mailingId">The mailing ID of the mailing to update.</param>
        /// <param name="body">The new mailing name.</param>
        /// <response code="200">Success</response>
        /// <response code="400">Bad Request</response>
        /// <response code="404">Not Found</response>
        [HttpPut]
        [Route("/Mailings/{mailingId}/name")]
        [ValidateModelState]
        [SwaggerOperation("MailingsMailingIdNamePut")]
        [SwaggerResponse(statusCode: 200, type: typeof(Mailing), description: "Success")]
        [SwaggerResponse(statusCode: 400, type: typeof(Models.ProblemDetails), description: "Bad Request")]
        [SwaggerResponse(statusCode: 404, type: typeof(Models.ProblemDetails), description: "Not Found")]
        public virtual IActionResult MailingsMailingIdNamePut([FromRoute][Required]int? mailingId, [FromBody]string body)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(Mailing));

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400, default(ProblemDetails));

            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404, default(ProblemDetails));
            string exampleJson = null;
            exampleJson = "{\n  \"dateCreated\" : \"2000-01-23T04:56:07.000+00:00\",\n  \"dateModified\" : \"2000-01-23T04:56:07.000+00:00\",\n  \"mailingId\" : 0,\n  \"mailingName\" : \"mailingName\"\n}";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<Mailing>(exampleJson)
                        : default(Mailing);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Queues the selected mailing to be sent for each of the provided records.  It is recommended to include no more than 1024 records per request.
        /// </summary>
        /// <param name="mailingId">The mailing ID of the mailing to send.</param>
        /// <param name="body">A collection of records, each consisting of a collection of key-value pairs to be used in the generation of each email.</param>
        /// <response code="200">Success</response>
        /// <response code="400">Bad Request</response>
        /// <response code="404">Not Found</response>
        [HttpPost]
        [Route("/Mailings/{mailingId}/send")]
        [ValidateModelState]
        [SwaggerOperation("MailingsMailingIdSendPost")]
        [SwaggerResponse(statusCode: 400, type: typeof(Models.ProblemDetails), description: "Bad Request")]
        [SwaggerResponse(statusCode: 404, type: typeof(Models.ProblemDetails), description: "Not Found")]
        public virtual IActionResult MailingsMailingIdSendPost([FromRoute][Required]int? mailingId, [FromBody]SendInput body)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            return StatusCode(200);

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400, default(ProblemDetails));

            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404, default(ProblemDetails));

            //throw new NotImplementedException();
        }

        /// <summary>
        /// Creates a new mailing.
        /// </summary>
        /// <param name="body"></param>
        /// <response code="200">Success</response>
        /// <response code="400">Bad Request</response>
        /// <response code="404">Not Found</response>
        [HttpPost]
        [Route("/Mailings")]
        [ValidateModelState]
        [SwaggerOperation("MailingsPost")]
        [SwaggerResponse(statusCode: 200, type: typeof(Mailing), description: "Success")]
        [SwaggerResponse(statusCode: 400, type: typeof(Models.ProblemDetails), description: "Bad Request")]
        [SwaggerResponse(statusCode: 404, type: typeof(Models.ProblemDetails), description: "Not Found")]
        public virtual IActionResult MailingsPost([FromBody]MailingInput body)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(Mailing));

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400, default(ProblemDetails));

            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404, default(ProblemDetails));
            string exampleJson = null;
            exampleJson = "{\n  \"dateCreated\" : \"2000-01-23T04:56:07.000+00:00\",\n  \"dateModified\" : \"2000-01-23T04:56:07.000+00:00\",\n  \"mailingId\" : 0,\n  \"mailingName\" : \"mailingName\"\n}";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<Mailing>(exampleJson)
                        : default(Mailing);            //TODO: Change the data returned
            return new ObjectResult(example);
        }
    }
}
