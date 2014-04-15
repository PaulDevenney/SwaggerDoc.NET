using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection;
using System.Web;
using System.Web.Http;
using System.Web.Http.Description;
using System.Web.Mvc;
using TestHarness.Areas.HelpPage;
using TestHarness.Areas.HelpPage.Models.Swagger;

namespace TestHarness.Controllers
{
    //worth investigating http://stackoverflow.com/questions/17821088/auto-generated-help-pages-with-return-type-httpresponsemessage
    [ApiExplorerSettings(IgnoreApi=true)]
    public class SwaggerController : ApiController
    {
        //
        // GET: /Swagger/
        public string Get()
        {
            SwaggerDocVm response = new SwaggerDocVm();

            string result = "" + Environment.NewLine;

            var apiDescriptions = Configuration.Services.GetApiExplorer().ApiDescriptions;

            foreach (var apiDescription in apiDescriptions)
            {
                var type = apiDescription.ActionDescriptor.ControllerDescriptor.ControllerType;

                if (typeof(ApiController).IsAssignableFrom(type))
                {
                    var friendlyId = apiDescription.GetFriendlyId();
                    var helpPageApiModel = Configuration.GetHelpPageApiModel(friendlyId);


                    result += apiDescription.RelativePath + Environment.NewLine;
                    result += apiDescription.HttpMethod.ToString() + Environment.NewLine;


                    foreach (var errorCodes in apiDescription.ActionDescriptor.GetCustomAttributes<ErrorHttpCodeAttribute>(true))
                    {
                        result += errorCodes.StatusCode + " : " + errorCodes.ReasonPhrase + Environment.NewLine;
                    }

                    foreach(var responseSample in helpPageApiModel.SampleResponses)
                    {
                        result += "RESPONSE EXAMPLE: " + responseSample.Key.ToString() + Environment.NewLine + responseSample.Value + Environment.NewLine;
                    }
                    
                }

                result += "**********************" + Environment.NewLine;
            }

            return result;
        }
    }
}