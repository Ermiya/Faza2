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
        public int CountOfBankBranch(QueryOptions options) => Count<BankBranch>(options);
        public List<BankBranch> SelectBankBranch(QueryOptions options) => Select<BankBranch>(options);
        public List<BankBranch> GetAllBankBranch() => GetAll<BankBranch>();
        public BankBranch GetBankBranchById(int id) => GetById<BankBranch>(id);
        public BankBranch AddBankBranch(BankBranchAddDto obj) => Add<BankBranch, BankBranchAddDto>(obj);
        public BankBranch ChangeBankBranch(int id, BankBranchChangeDto obj) => Change<BankBranch, BankBranchChangeDto>(id, obj);
        public BankBranch RemoveBankBranch(int id) => Remove<BankBranch>(id);
    }
}
