using Faza.Treasury.Facade;
using Bitspco.Framework.Net.Service.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Faza.Treasury.Service.WebApi.Controllers
{
    public class ApiController : System.Web.Http.ApiController
    {
        private TreasuryController controller;
        private ODataQueryOptions queryOptions;
        private ODataQueryOptions queryOptionsCount;

        protected HttpRequest CRequest { get { return HttpContext.Current.Request; } }
        public string Token
        {
            get
            {
                var token = string.Empty;
                var request = CRequest;
                if (request.Headers.AllKeys.Contains("Authorization")) token = request.Headers["Authorization"];
                else if (request.QueryString.AllKeys.Contains("Api_Key")) token = request.QueryString["Api_Key"];
                else if (request.QueryString.AllKeys.Contains("Token")) token = request.QueryString["Token"];
                else if (request.Cookies.AllKeys.Contains("Token")) token = request.Cookies["Token"].Value;
                if (!string.IsNullOrEmpty(token) && token.Length > 7 && token.Substring(0, 7).ToLower() == "bearer ") token = token.Substring(7);
                return token;
            }
        }
        public TreasuryController Controller
        {
            get
            {
                if (controller != null) return controller;
                controller = new TreasuryController();
                controller.RegisterSecurity(CRequest);
                controller.RegisterAuthenticator(Token);
                return controller;
            }
        }
        protected ODataQueryOptions QueryOptions
        {
            get
            {
                if (queryOptions != null) return queryOptions;
                queryOptions = new ODataQueryOptions().Parse(CRequest);
                if (queryOptions.Top.Value > 50) queryOptions.Top.Value = 50;
                return queryOptions;
            }
        }
        protected ODataQueryOptions QueryOptionsCount
        {
            get
            {
                if (queryOptionsCount != null) return queryOptionsCount;
                queryOptionsCount = new ODataQueryOptions().Parse(CRequest);
                queryOptionsCount.Skip.Value = 0;
                queryOptionsCount.Top.Value = 0;
                return queryOptionsCount;
            }
        }
    }
}