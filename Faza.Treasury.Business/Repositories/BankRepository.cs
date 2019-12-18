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
        public int CountOfBank(QueryOptions options) => Count<Bank>(options);
        public List<Bank> SelectBank(QueryOptions options) => Select<Bank>(options);
        public List<Bank> GetAllBank() => GetAll<Bank>();
        public Bank GetBankById(int id) => GetById<Bank>(id);
        public Bank AddBank(BankAddDto obj) => Add<Bank, BankAddDto>(obj);
        public Bank ChangeBank(int id, BankChangeDto obj) => Change<Bank, BankChangeDto>(id, obj);
        public Bank RemoveBank(int id) => Remove<Bank>(id);
    }
}
