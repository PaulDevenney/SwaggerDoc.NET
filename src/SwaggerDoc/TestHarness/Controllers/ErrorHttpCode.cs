using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;

namespace TestHarness.Controllers
{
    [System.AttributeUsage(System.AttributeTargets.Method,AllowMultiple = true)] 
    public class ErrorHttpCodeAttribute : Attribute
    {
        public HttpStatusCode StatusCode { get; private set; }
        public string ReasonPhrase { get; private set; }

        public ErrorHttpCodeAttribute(HttpStatusCode statusCode, string reasonPhrase)
        {
            StatusCode = statusCode;
            ReasonPhrase = reasonPhrase;
        }
    }
}
