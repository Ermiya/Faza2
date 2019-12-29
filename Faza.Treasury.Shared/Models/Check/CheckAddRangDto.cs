using System;
using System.Collections.Generic;
using System.Text;

namespace Faza.Treasury.Shared.Models
{
    public class CheckAddRangDto : BaseAddDto
    {
        public int BankBranchId { get; set; }
        public int CheckBook { get; set; }
        public long FromNo { get; set; }
        public long ToNo { get; set; }

    }
}
