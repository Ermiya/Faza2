namespace Faza.Treasury.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBankBranchEntity : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "Accounting.BankBranch",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BankId = c.Int(nullable: false),
                        Name = c.String(nullable: false, maxLength: 200),
                        Address = c.String(nullable: false, maxLength: 2000),
                        Code = c.String(nullable: false, maxLength: 100),
                        Status = c.Boolean(nullable: false),
                        CreatorUserId = c.Long(),
                        CreationTime = c.DateTime(nullable: false),
                        LastModifierUserId = c.Long(),
                        LastModificationTime = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("Accounting.Bank", t => t.BankId, cascadeDelete: true)
                .Index(t => t.BankId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("Accounting.BankBranch", "BankId", "Accounting.Bank");
            DropIndex("Accounting.BankBranch", new[] { "BankId" });
            DropTable("Accounting.BankBranch");
        }
    }
}
