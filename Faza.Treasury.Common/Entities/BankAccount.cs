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
    [Table("BankAccount", Schema = "Accounting")]
    public class BankAccount : Entity, IAudited
    {
        [Required]
        public int BankBranchId { get; set; }
        [ForeignKey("BankBranchId")]
        public virtual BankBranch BankBranch { get; set; }

        [StringLength(26), Required]
        public string AccountNo { get; set; }
        [Required]
        public int AccountTypeId { get; set; }
        [Required,ForeignKey("AccountTypeId")]
        public virtual AccountType AccountType { get; set; }
        [Required]
        public int DetailedAccountId { get; set; }
        public DateTime BeginDate { get; set; }
        public DateTime EndDate { get; set; }
        [Required]
        public Int16 Owner { get; set; }
        [Required]
        public bool Status { get; set; }

        [Required]
        public int CurrencyTypeId { get; set; }
        [Required, ForeignKey("CurrencyTypeId")]
        public virtual CurrencyType CurrencyType { get; set; }
        [StringLength(26)]
        public string AccountSheba { get; set; }
        [StringLength(20)]
        public string CardNo { get; set; }
        public long? CreatorUserId { get; set; }
        public DateTime CreationTime { get; set; }
        public long? LastModifierUserId { get; set; }
        public DateTime? LastModificationTime { get; set; }
    }
}
