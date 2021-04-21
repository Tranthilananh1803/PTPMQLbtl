namespace PTPMQLbtl.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Creat_Table_Danhmuchang : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Danhmuchang",
                c => new
                    {
                        Mathang = c.Int(nullable: false, identity: true),
                        Tenhang = c.String(maxLength: 50, fixedLength: true),
                        Donvitinh = c.String(maxLength: 30, fixedLength: true),
                        Dongia = c.Decimal(precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Mathang);
            
            
        }
        
        public override void Down()
        {
           
            
            DropTable("dbo.Danhmuchang");
        }
    }
}
