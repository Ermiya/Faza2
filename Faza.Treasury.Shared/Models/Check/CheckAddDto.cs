using System;
using System.Collections.Generic;
using System.Text;

namespace Faza.Treasury.Shared.Models
{
    public class CheckAddDto : BaseAddDto
    {
        public int BankAccountId { get; set; }
        public long CheckNo { get; set; }
        public int CheckBook { get; set; }
        public bool Status { get; set; }
        public DateTime? IssuingDate { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public DateTime? CancelDate { get; set; }
    }
}
