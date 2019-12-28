namespace Faza.Treasury.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_Check : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "Accounting.Check",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BankAccountId = c.Int(nullable: false),
                        CheckNo = c.Long(nullable: false),
                        CheckBook = c.Int(nullable: false),
                        Status = c.Boolean(nullable: false),
                        IssuingDate = c.DateTime(nullable: false),
                        DeliveryDate = c.DateTime(nullable: false),
                        CancelDate = c.DateTime(nullable: false),
                        CreatorUserId = c.Long(),
                        CreationTime = c.DateTime(nullable: false),
                        LastModifierUserId = c.Long(),
                        LastModificationTime = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("Accounting.BankAccount", t => t.BankAccountId, cascadeDelete: true)
                .Index(t => t.BankAccountId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("Accounting.Check", "BankAccountId", "Accounting.BankAccount");
            DropIndex("Accounting.Check", new[] { "BankAccountId" });
            DropTable("Accounting.Check");
        }
    }
}
