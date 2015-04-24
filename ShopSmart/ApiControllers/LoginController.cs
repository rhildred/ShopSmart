using ShopSmart.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ShopSmart.ApiControllers
{
    public class LoginController : ApiController
    {
        public IHttpActionResult PutLogin(Login oLogin)
        {
            return Ok(new { result = "success" });

        }
        public IHttpActionResult PostLogin(Person oPerson)
        {
            return Ok(new { result = "success" });

        }
    }
}
