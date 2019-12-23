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
        //[Auth("BankBranch_Get")]
        public int CountOfBankBranch(QueryOptions options) => Count<BankBranch>(options);
        //[Auth("BankBranch_Get")]
        public List<BankBranchGetDto> SelectBankBranch(QueryOptions options) => Select<BankBranch, BankBranchGetDto>(options);
        //[Auth("BankBranch_Get")]
        public List<BankBranchGetDto> GetAllBankBranch() => GetAll<BankBranch, BankBranchGetDto>();
        //[Auth("BankBranch_Get")]
        public BankBranchGetDto GetBankBranchById(int id) => GetById<BankBranch, BankBranchGetDto>(id);
        //[Auth("BankBranch_Add")]
        public BankBranchGetDto AddBankBranch(BankBranchAddDto obj) => Add<BankBranch, BankBranchGetDto, BankBranchAddDto>(obj);
        //[Auth("BankBranch_Change")]
        public BankBranchGetDto ChangeBankBranch(int id, BankBranchChangeDto obj) => Change<BankBranch, BankBranchGetDto, BankBranchChangeDto>(id, obj);
        //[Auth("BankBranch_Remove")]
        public BankBranchGetDto RemoveBankBranch(int id) => Remove<BankBranch, BankBranchGetDto>(id);
    }
}
