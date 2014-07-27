using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace TheoryWeb.Controllers.api
{
    public class TestController : ApiController
    {
        [HttpGet]
        public string Get()
        {
            return "Hello";
        }
    }
}
