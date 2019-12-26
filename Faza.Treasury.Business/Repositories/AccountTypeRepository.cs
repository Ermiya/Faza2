using Faza.Treasury.Common.Entities;
using Faza.Treasury.Shared.Models;
using Bitspco.Framework.Service.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faza.Treasury.Business
{
    public partial class TreasuryBusiness
    {
        public int CountOfAccountType(QueryOptions options) => Count<AccountType>(options);
        public List<AccountType> SelectAccountType(QueryOptions options) => Select<AccountType>(options);
        public List<AccountType> GetAllAccountType() => GetAll<AccountType>();
        public AccountType GetAccountTypeById(int id) => GetById<AccountType>(id);
        public AccountType AddAccountType(AccountTypeAddDto obj) => Add<AccountType, AccountTypeAddDto>(obj);
        public AccountType ChangeAccountType(int id, AccountTypeChangeDto obj) => Change<AccountType, AccountTypeChangeDto>(id, obj);
        public AccountType RemoveAccountType(int id) => Remove<AccountType>(id);
    }
}
