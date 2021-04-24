namespace PTPMQLbtl.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class adbc : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Chitietdonhang", "Dongia", c => c.String(nullable: false));
            AlterColumn("dbo.Chitietdonhang", "Soluong", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Chitietdonhang", "Soluong", c => c.String());
            AlterColumn("dbo.Chitietdonhang", "Dongia", c => c.String(maxLength: 128, fixedLength: true));
        }
    }
}
