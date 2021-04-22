namespace PTPMQLbtl.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Hoadon", "Tenkhachhang", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Hoadon", "Tenkhachhang", c => c.Int(nullable: false));
        }
    }
}
