using Faza.Treasury.Common.Entities;
using Faza.Treasury.Shared.Models;
using Bitspco.Framework.Facade.Filters.Security.Authenticate;
using Bitspco.Framework.Service.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faza.Treasury.Facade
{
    public partial class TreasuryController
    {
       //[Auth("AccountType_Get")]
        public int CountOfAccountType(QueryOptions options) => Count<AccountType>(options);
        //[Auth("AccountType_Get")]
        public List<AccountTypeGetDto> SelectAccountType(QueryOptions options) => Select<AccountType, AccountTypeGetDto>(options);
        //[Auth("AccountType_Get")]
        public List<AccountTypeGetDto> GetAllAccountType() => GetAll<AccountType, AccountTypeGetDto>();
        //[Auth("AccountType_Get")]
        public AccountTypeGetDto GetAccountTypeById(int id) => GetById<AccountType, AccountTypeGetDto>(id);
        //[Auth("AccountType_Add")]
        public AccountTypeGetDto AddAccountType(AccountTypeAddDto obj) => Add<AccountType, AccountTypeGetDto, AccountTypeAddDto>(obj);
        //[Auth("AccountType_Change")]
        public AccountTypeGetDto ChangeAccountType(int id, AccountTypeChangeDto obj) => Change<AccountType, AccountTypeGetDto, AccountTypeChangeDto>(id, obj);
        //[Auth("AccountType_Remove")]
        public AccountTypeGetDto RemoveAccountType(int id) => Remove<AccountType, AccountTypeGetDto>(id);
    }
}
