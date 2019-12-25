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
    [Table("AccountType", Schema = "Accounting")]
    public class AccountType : Entity
    {
        [StringLength(100), Required]
        public string Name { get; set; }
    }
}
