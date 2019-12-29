namespace Faza.Treasury.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatecheck : DbMigration
    {
        public override void Up()
        {
            AlterColumn("Accounting.Check", "IssuingDate", c => c.DateTime());
            AlterColumn("Accounting.Check", "DeliveryDate", c => c.DateTime());
            AlterColumn("Accounting.Check", "CancelDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("Accounting.Check", "CancelDate", c => c.DateTime(nullable: false));
            AlterColumn("Accounting.Check", "DeliveryDate", c => c.DateTime(nullable: false));
            AlterColumn("Accounting.Check", "IssuingDate", c => c.DateTime(nullable: false));
        }
    }
}
