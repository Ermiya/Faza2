using Faza.Treasury.Business;
using Faza.Treasury.Common.Interfaces;
using Faza.Treasury.Data;
using Faza.Treasury.Data.Contexts;
using Faza.Treasury.Facade.Filters;
using Faza.Treasury.Facade.Mappers;
using AutoMapper;
using Bitspco.Framework.Facade;
using Bitspco.Framework.Facade.Filters.ErrorHandler;
using Bitspco.Framework.Facade.Filters.Log;
using Bitspco.Framework.Facade.Filters.Security;
using Bitspco.Framework.Facade.Filters.Security.AntiDos;
using Bitspco.Framework.Facade.Filters.Security.Authenticate;
using Bitspco.Framework.Facade.Filters.Security.IP;
using Bitspco.Framework.Facade.Filters.Security.Models;
using Bitspco.Framework.Facade.Filters.Validator;
using Bitspco.Framework.Net.Facade.Filters.Security;
using Bitspco.Framework.Net.Logger.Contexts;
using Bitspco.Identity.Client;
using Bitspco.Identity.Shared.Interfaces;
using Bitspco.Identity.Shared.Models;
using System.Web;

namespace Faza.Treasury.Facade
{
    public partial class TreasuryController : BaseController<ITreasuryDataAdapter>
    {
        private static TreasuryConfiguration Configuration;

        private Mapper Mapper;
        private TreasuryBusiness business;
        private IIdentityClientService identityClientService;

        private Authenticator authenticator;
        private readonly IPFilter ipFilter = new IPFilter();
        private readonly AuthFilter authFilter = new AuthFilter();
        private readonly LogFilter logFilter = new LogFilter(new Logger());
        private readonly SecurityFilter securityFilter = new SecurityFilter();
        private readonly AntiDosFilter antiDosFilter = new AntiDosFilter();
        private readonly ErrorHandlerFilter errorHandlerFilter = new ErrorHandlerFilter();
        private readonly ValidatorFilter validatorFilter = new ValidatorFilter();

        private TreasuryBusiness Business
        {
            get
            {
                if (business == null) business = new TreasuryBusiness(Adapter, Mapper);
                return business;
            }
        }
        public LoginResponseDto LoginInfo { get { return authenticator?.LoginInfo; } }
        protected override int? UserId { get { return LoginInfo?.User?.Id; } }
        protected override string AdapterName => authenticator?.PolicyName;

        static TreasuryController()
        {
            //Configuration = LoadConfiguration<TreasuryConfiguration>(@"D:\MyProject\Faza2\Faza.Treasury.Facade\config.json");
            Configuration = LoadConfiguration<TreasuryConfiguration>(@"C:\Users\lenovo\Source\Workspaces\Workspace\erp\Faza2\Faza.Treasury.Facade\config.json");
            var controller = new TreasuryController();
            controller.Configure();
        }
        public TreasuryController()
        {
            filters.Add(errorHandlerFilter);
            filters.Add(logFilter);

            antiDosFilter.AttributeEnable = true;
            securityFilter.Filters.Add(authFilter);
            securityFilter.Filters.Add(antiDosFilter);
            securityFilter.Filters.Add(ipFilter);

            filters.Add(securityFilter);

            filters.Add(validatorFilter);

            Mapper = new Mapper(AutoMapperConfig.GetConfig());
        }
        private void Configure()
        {

        }
        public void RegisterSecurity(HttpRequest request)
        {
            securityFilter.ClientInfo = new ClientInfo().GetClientInfo(request, "");
        }
        public void RegisterAuthenticator(string token)
        {
            if (!string.IsNullOrEmpty(Configuration?.Identity?.Url))
            {
                identityClientService = new IdentityClientServiceWebApi(Configuration.Identity.Url);
                if (string.IsNullOrEmpty(Configuration.Identity.Token))
                {
                    var loginResponse = identityClientService.Login(new LoginRequestDto() { Username = Configuration.Identity.Username, Password = Configuration.Identity.Password });
                    if (loginResponse.Success) Configuration.Identity.Token = loginResponse.Data;
                }
                identityClientService.Token = Configuration.Identity.Token;
            }
            //authenticator = new Authenticator(token, Configuration.Symbol, identityClientService);
            //authFilter.SetAuthenticator(authenticator);
        }
        protected override ITreasuryDataAdapter GetAdapter()
        {
            var context = new TreasuryDbContext(Configuration.ConnectionString);
            return new TreasuryDataAdapter(context);
        }
        protected override T MapTo<T>(object obj)
        {
            return Mapper.Map<T>(obj);
        }
        protected override TR MapTo<T, TR>(T obj1, TR obj2)
        {
            return Mapper.Map(obj1, obj2);
        }
    }
}
