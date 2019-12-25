namespace Faza.Treasury.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBankAccount : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "Accounting.AccountType",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.Id);

            CreateTable(
               "Accounting.CurrencyType",
               c => new
               {
                   Id = c.Int(nullable: false, identity: true),
                   Name = c.String(nullable: false, maxLength: 100),
               })
               .PrimaryKey(t => t.Id);

            CreateTable(
                "Accounting.BankAccount",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BankBranchId = c.Int(nullable: false),
                        AccountNo = c.String(nullable: false, maxLength: 26),
                        AccountTypeId = c.Int(nullable: false),
                        DetailedAccountId = c.Int(nullable: false),
                        BeginDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                        Owner = c.Short(nullable: false),
                        Status = c.Boolean(nullable: false),
                        CurrencyTypeId = c.Int(nullable: false),
                        AccountSheba = c.String(maxLength: 26),
                        CardNo = c.String(maxLength: 20),
                        CreatorUserId = c.Long(),
                        CreationTime = c.DateTime(nullable: false),
                        LastModifierUserId = c.Long(),
                        LastModificationTime = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("Accounting.AccountType", t => t.AccountTypeId, cascadeDelete: true)
                .ForeignKey("Accounting.BankBranch", t => t.BankBranchId, cascadeDelete: true)
                .ForeignKey("Accounting.CurrencyType", t => t.CurrencyTypeId, cascadeDelete: true)
                .Index(t => t.BankBranchId)
                .Index(t => t.AccountTypeId)
                .Index(t => t.CurrencyTypeId);
            
           
            
        }
        
        public override void Down()
        {
            DropForeignKey("Accounting.BankAccount", "CurrencyTypeId", "Accounting.CurrencyType");
            DropForeignKey("Accounting.BankAccount", "BankBranchId", "Accounting.BankBranch");
            DropForeignKey("Accounting.BankAccount", "AccountTypeId", "Accounting.AccountType");
            DropIndex("Accounting.BankAccount", new[] { "CurrencyTypeId" });
            DropIndex("Accounting.BankAccount", new[] { "AccountTypeId" });
            DropIndex("Accounting.BankAccount", new[] { "BankBranchId" });
            DropTable("Accounting.CurrencyType");
            DropTable("Accounting.BankAccount");
            DropTable("Accounting.AccountType");
        }
    }
}
