namespace PTPMQLbtl.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_Nhacungcap : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Nhacungcap",
                c => new
                    {
                        MaNCC = c.String(nullable: false, maxLength: 128),
                        TenNCC = c.String(nullable: false),
                        Diachi = c.String(nullable: false, maxLength: 100),
                        Sodienthoai = c.String(nullable: false, maxLength: 25),
                    })
                .PrimaryKey(t => t.MaNCC);
            
            
        }
        
        public override void Down()
        {
            
            
            DropTable("dbo.Nhacungcap");
        }
    }
}
