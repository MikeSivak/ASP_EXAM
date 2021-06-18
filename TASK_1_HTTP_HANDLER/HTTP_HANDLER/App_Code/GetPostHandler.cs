using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HTTP_HANDLER.App_Code
{
    public class GetPostHandler : IHttpHandler
    {
        //public bool IsReusable => throw new NotImplementedException();

        public bool IsReusable => false;

        public void ProcessRequest(HttpContext context)
        {
            HttpRequest request = context.Request;
            HttpResponse response = context.Response;

            response.Write("Request method: " + request.HttpMethod);
        }
    }
}