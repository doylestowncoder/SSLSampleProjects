using System;
using System.Web.Http;

namespace SSLSample.Controllers
{
    public class TestController : ApiController
    {
        public IHttpActionResult Get()
        {
            var testResult = new
            {
                ApiName = "SSLSample",
                ServerInstance = Environment.MachineName,
                Version = "1.0",
                UsingSSL = (this.ActionContext.Request.RequestUri.Scheme == Uri.UriSchemeHttps),
                HealthMeter = 100
            };

            return Ok(testResult);  // Returns an OkNegotiatedContentResult
        }
    }
}