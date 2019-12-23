namespace Faza.Treasury.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateBank : DbMigration
    {
        public override void Up()
        {
            AddColumn("Accounting.Bank", "CreatorUserId", c => c.Long());
            AddColumn("Accounting.Bank", "LastModifierUserId", c => c.Long());
            AddColumn("Accounting.Bank", "LastModificationTime", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("Accounting.Bank", "LastModificationTime");
            DropColumn("Accounting.Bank", "LastModifierUserId");
            DropColumn("Accounting.Bank", "CreatorUserId");
        }
    }
}
