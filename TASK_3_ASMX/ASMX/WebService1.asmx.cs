using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace ASMX
{
    /// <summary>
    /// Сводное описание для WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Чтобы разрешить вызывать веб-службу из скрипта с помощью ASP.NET AJAX, раскомментируйте следующую строку. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        [WebMethod(Description = "Hello World!", EnableSession = true)]
        public string HelloWorld()
        {
            return "Привет всем!";
        }

        [WebMethod(Description = "Get Sum", EnableSession = true)]
        public int Sum(int x, int y)
        {
            return (x + y);
        }

        [WebMethod(Description = "Get Mul", EnableSession = true)]
        public int Mul(int x, int y)
        {
            return (x * y);
        }

        [WebMethod(Description = "Get Sub", EnableSession = true)]
        public int Sub(int x, int y)
        {
            return (x - y);
        }
    }
}
