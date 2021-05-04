namespace PTPMQLbtl.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class anh : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Danhmuchang", "Dongia", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Danhmuchang", "Dongia", c => c.Decimal(precision: 18, scale: 2));
        }
    }
}
