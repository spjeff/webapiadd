using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace AppModelv2_WebApp_OpenIDConnect_DotNet.Controllers
{
    [EnableCors(origins: "*",
    headers: "*",
    methods: "*",
    SupportsCredentials = true)]
    [Authorize]
    public class HelloController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            DateTime now = DateTime.Now;
            return new string[] { "Hello", now.ToLongDateString() + " " + now.ToLongTimeString() };
        }
    }
}
