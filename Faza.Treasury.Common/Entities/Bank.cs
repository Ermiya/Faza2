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
    [Table("Bank", Schema = "Accounting")]
    public class Bank : Entity, IAudited
    {
        [StringLength(100), Required]
        public string Name { get; set; }
        public bool Status { get; set; }
        public DateTime CreationTime { get; set; }
        public long? CreatorUserId { get; set; }
        public long? LastModifierUserId { get; set; }
        public DateTime? LastModificationTime { get; set; }
    }
}
