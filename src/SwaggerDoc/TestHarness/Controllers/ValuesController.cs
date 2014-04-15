using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace TestHarness.Controllers
{
    [SwaggerDoc]
    public class ValuesController : ApiController
    {
        // GET api/values
        [HttpGet]
        
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        /// <summary>
        /// Get a value by its Id
        /// </summary>
        /// <param name="id">the unique identifier of the value</param>
        /// <returns>the value dummy!</returns>
        [ResponseType(typeof(string))]
        [ErrorHttpCode(HttpStatusCode.BadRequest, "Invalid Id Supplied")]
        [ErrorHttpCode(HttpStatusCode.BadRequest, "Invalid Id Supplied")]
        // GET api/values/5
        public HttpResponseMessage Get(int id)
        {
            return Request.CreateResponse(HttpStatusCode.OK, "value");
        }

        //// POST api/values
        //public void Post([FromBody]string value)
        //{
        //}

        //// PUT api/values/5
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE api/values/5
        //public void Delete(int id)
        //{
        //}
    }
}
