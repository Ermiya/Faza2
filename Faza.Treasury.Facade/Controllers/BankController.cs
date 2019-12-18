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
        [Auth("Bank_Get")]
        public int CountOfBank(QueryOptions options) => Count<Bank>(options);
        [Auth("Bank_Get")]
        public List<BankGetDto> SelectBank(QueryOptions options) => Select<Bank, BankGetDto>(options);
        [Auth("Bank_Get")]
        public List<BankGetDto> GetAllBank() => GetAll<Bank, BankGetDto>();
        [Auth("Bank_Get")]
        public BankGetDto GetBankById(int id) => GetById<Bank, BankGetDto>(id);
        [Auth("Bank_Add")]
        public BankGetDto AddBank(BankAddDto obj) => Add<Bank, BankGetDto, BankAddDto>(obj);
        [Auth("Bank_Change")]
        public BankGetDto ChangeBank(int id, BankChangeDto obj) => Change<Bank, BankGetDto, BankChangeDto>(id, obj);
        [Auth("Bank_Remove")]
        public BankGetDto RemoveBank(int id) => Remove<Bank, BankGetDto>(id);
    }
}
