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
        public int CountOfBankAccount(QueryOptions options) => Count<BankAccount>(options);
        public List<BankAccount> SelectBankAccount(QueryOptions options) => Select<BankAccount>(options);
        public List<BankAccount> GetAllBankAccount() => GetAll<BankAccount>();
        public BankAccount GetBankAccountById(int id) => GetById<BankAccount>(id);
        public BankAccount AddBankAccount(BankAccountAddDto obj) => Add<BankAccount, BankAccountAddDto>(obj);
        public BankAccount ChangeBankAccount(int id, BankAccountChangeDto obj) => Change<BankAccount, BankAccountChangeDto>(id, obj);
        public BankAccount RemoveBankAccount(int id) => Remove<BankAccount>(id);
    }
}
