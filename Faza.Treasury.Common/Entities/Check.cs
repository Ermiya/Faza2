using Bitspco.Framework.Data.Entities;
using Bitspco.Framework.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faza.Treasury.Common.Entities
{
    [Table("Check", Schema = "Accounting")]
    public class Check : Entity, IAudited
    {
        [Required]
        public int BankAccountId { get; set; }
        [ForeignKey("BankAccountId")]
        public virtual BankAccount BankAccount { get; set; }
        [Required]
        public long CheckNo { get; set; }
        [Required]
        public int CheckBook { get; set; }
        [Required]
        public bool Status { get; set; }
        public DateTime IssuingDate { get; set; }
        public DateTime DeliveryDate { get; set; }
        public DateTime CancelDate { get; set; }
        public long? CreatorUserId { get; set; }
        public DateTime CreationTime { get; set; }
        public long? LastModifierUserId { get; set; }
        public DateTime? LastModificationTime { get; set; }
    }
}
