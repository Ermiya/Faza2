using Bitspco.Framework.Facade.Filters.Security.Authenticate;
using Bitspco.Identity.Client;
using Bitspco.Identity.Shared.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faza.Treasury.Facade.Filters
{
    class Authenticator : BaseAuthenticator, IAuthenticator
    {
        public Authenticator(string token, string symbol, IIdentityClientService service) : base(token, symbol, service)
        {

        }
    }
}
