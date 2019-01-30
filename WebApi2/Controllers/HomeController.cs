using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Results;

namespace WebApi2.Controllers
{
    public class HomeController : ApiController
    {
        public string Get(int id)
        {
            return "value";
        }
    }
}
