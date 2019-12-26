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
        //[Auth("BankAccount_Get")]
        public int CountOfBankAccount(QueryOptions options) => Count<BankAccount>(options);
        //[Auth("BankAccount_Get")]
        public List<BankAccountGetDto> SelectBankAccount(QueryOptions options) => Select<BankAccount, BankAccountGetDto>(options);
        //[Auth("BankAccount_Get")]
        public List<BankAccountGetDto> GetAllBankAccount() => GetAll<BankAccount, BankAccountGetDto>();
        //[Auth("BankAccount_Get")]
        public BankAccountGetDto GetBankAccountById(int id) => GetById<BankAccount, BankAccountGetDto>(id);
        //[Auth("BankAccount_Add")]
        public BankAccountGetDto AddBankAccount(BankAccountAddDto obj) => Add<BankAccount, BankAccountGetDto, BankAccountAddDto>(obj);
        //[Auth("BankAccount_Change")]
        public BankAccountGetDto ChangeBankAccount(int id, BankAccountChangeDto obj) => Change<BankAccount, BankAccountGetDto, BankAccountChangeDto>(id, obj);
        //[Auth("BankAccount_Remove")]
        public BankAccountGetDto RemoveBankAccount(int id) => Remove<BankAccount, BankAccountGetDto>(id);
    }
}
