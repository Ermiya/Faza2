using System;
using System.Collections.Generic;
using System.Text;

namespace Faza.Treasury.Shared.Models
{
    public class BankAccountGetDto : BaseGetDto
    {
        public int BankBranchId { get; set; }
        public virtual BankBranchGetDto BankBranch { get; set; }

        public string AccountNo { get; set; }
        public int AccountTypeId { get; set; }
        public virtual AccountTypeGetDto AccountType { get; set; }
        public int DetailedAccountId { get; set; }
        public DateTime BeginDate { get; set; }
        public DateTime EndDate { get; set; }
        public Int16 Owner { get; set; }
        public bool Status { get; set; }
        public int CurrencyTypeId { get; set; }
        public virtual CurrencyTypeGetDto CurrencyType { get; set; }
        public string AccountSheba { get; set; }
        public string CardNo { get; set; }
    }
}
