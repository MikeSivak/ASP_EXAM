using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WEB_API_REST.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Produces("application/json")]
    public class RestController : ControllerBase
    {
        // GET api/rest/5
        [HttpGet("{s}")]
        public string[] Get(string s)
        {
            string method = Request.Method;
            string[] arr = { "method: " + method, "s: " + s };

            if (s == "")
            {
                Response.StatusCode = 400;
            }

            return arr;
        }

        // POST api/rest
        [HttpPost]
        public string[] Post(int x, string s, DateTime d)
        {
            string method = Request.Method;
            string parmX = Request.Form["x"];
            string parmS = Request.Form["s"];
            string parmD = Request.Form["d"];

            string[] arr = { $"method: {method}", $"x: {parmX}", $"s: {parmS}", $"d: {parmD}" };

            if (parmX == null || parmS == null || parmD == null)
            {
                Response.StatusCode = 400;
            }

            return arr;
        }

        // PUT api/rest
        [HttpPut]
        public string[] Put()
        {
            string method = Request.Method;
            string parmX = Request.Form["x"];
            string parmS = Request.Form["s"];
            string parmD = Request.Form["d"];

            string[] arr = { $"method: {method}", $"x: {parmX}", $"s: {parmS}", $"d: {parmD}" };

            if (parmX == null || parmS == null || parmD == null)
            {
                Response.StatusCode = 400;
            }

            return arr;
        }

        // DELETE api/rest/5
        [HttpDelete("{x}")]
        public string[] Delete(int x)
        {
            string method = Request.Method;
            string[] arr = { $"method: {method}", $"x: {x}" };

            if (x.ToString() == "")
            {
                Response.StatusCode = 400;
            }

            return arr;
        }
    }
}
