namespace PTPMQLbtl.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Creat_Table_Hoadon : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Hoadon",
                c => new
                    {
                        Sohoadon = c.Int(nullable: false, identity: true),
                        Ngayban = c.DateTime(nullable: false),
                        Makhachhang = c.Int(nullable: false),
                        Tenkhachhang = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Sohoadon);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Hoadon");
        }
    }
}
