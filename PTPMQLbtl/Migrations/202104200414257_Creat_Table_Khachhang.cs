namespace PTPMQLbtl.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Creat_Table_Khachhang : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Khachhang",
                c => new
                    {
                        Makhachhang = c.Int(nullable: false, identity: true),
                        Hodem = c.String(nullable: false, maxLength: 50),
                        Ten = c.String(nullable: false, maxLength: 20),
                        Diachi = c.String(nullable: false, maxLength: 200),
                        Sodienthoai = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.Makhachhang);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Khachhang");
        }
    }
}
