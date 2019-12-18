using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;

namespace Faza.Treasury.Service.WebApi
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
            //Log.Logger = new LoggerConfiguration().WriteTo.Seq("http://localhost:5341").CreateLogger();
        }
    }
}
