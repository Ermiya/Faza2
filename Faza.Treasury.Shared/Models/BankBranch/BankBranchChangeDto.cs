using System;
using System.Collections.Generic;
using System.Text;

namespace Faza.Treasury.Shared.Models
{
    public class BankBranchChangeDto : BaseChangeDto
    {
        public int BankId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Code { get; set; }
        public bool Status { get; set; }
    }
}
