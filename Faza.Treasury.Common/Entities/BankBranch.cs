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
    [Table("BankBranch", Schema = "Accounting")]
    public class BankBranch : Entity, IAudited
    {
        [Required]
        public int BankId { get; set; }
        [StringLength(200), Required]
        public string Name { get; set; }
        [StringLength(2000), Required]
        public string Address { get; set; }
        [StringLength(100), Required]
        public string Code { get; set; }
        public bool Status { get; set; }
        [ForeignKey("BankId")]
        public virtual Bank Bank { get; set; }
        public long? CreatorUserId { get; set; }
        public DateTime CreationTime { get; set; }
        public long? LastModifierUserId { get; set; }
        public DateTime? LastModificationTime { get; set; }
    }
}
