using Faza.Treasury.Common.Entities;
using Bitspco.Framework.Data.Interfaces;
using Bitspco.Framework.Net.Logger.Contexts;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faza.Treasury.Data.Contexts
{
    public class TreasuryDbContext : LoggerDbContext, IDbContext
    {
        public TreasuryDbContext() :  base("data source=(localdb)\\MSSQLLocalDB;initial catalog=Treasury;Integrated Security=SSPI;MultipleActiveResultSets=True;App=EntityFramework") { }
        public TreasuryDbContext(string connectionString) : base(connectionString) { }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            base.OnModelCreating(modelBuilder);
        }
        public virtual DbSet<Bank> Banks { get; set; }        public virtual DbSet<BankBranch> BankBranchs { get; set; }        public virtual DbSet<AccountType> AccountTypes { get; set; }        public virtual DbSet<CurrencyType> CurrencyTypes { get; set; }        public virtual DbSet<BankAccount> BankAccounts { get; set; }        public virtual DbSet<Check> Checks { get; set; }        //--Entity public virtual DbSet<__EntityName__> __EntityNames__ { get; set; }
    }
}
