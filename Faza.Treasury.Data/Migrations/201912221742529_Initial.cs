namespace Faza.Treasury.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "Accounting.Bank",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                        Status = c.Boolean(nullable: false),
                        CreationTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "log.ChangeLogItem",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ChangeLogId = c.Int(nullable: false),
                        PropertyName = c.String(maxLength: 50),
                        OldValue = c.String(maxLength: 500),
                        NewValue = c.String(maxLength: 500),
                        CreatorUserId = c.Long(),
                        CreationTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("log.ChangeLog", t => t.ChangeLogId, cascadeDelete: true)
                .Index(t => t.ChangeLogId);
            
            CreateTable(
                "log.ChangeLog",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EntityName = c.String(),
                        RecordId = c.Long(nullable: false),
                        EntityState = c.Byte(nullable: false),
                        CreatorUserId = c.Long(),
                        CreationTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "log.ExceptionLog",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CreatorUserId = c.Long(),
                        CreationTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "log.QueryLog",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CreatorUserId = c.Long(),
                        CreationTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("log.ChangeLogItem", "ChangeLogId", "log.ChangeLog");
            DropIndex("log.ChangeLogItem", new[] { "ChangeLogId" });
            DropTable("log.QueryLog");
            DropTable("log.ExceptionLog");
            DropTable("log.ChangeLog");
            DropTable("log.ChangeLogItem");
            DropTable("Accounting.Bank");
        }
    }
}
