namespace PTPMQLbtl.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Creat_Table_Chitietdonhang : DbMigration
    {
        public override void Up()
        {
            
            CreateTable(
                "dbo.Chitietdonhang",
                c => new
                    {
                        Machitietdonhang = c.String(nullable: false, maxLength: 128, fixedLength: true),
                        Madonhang = c.String(maxLength: 128, fixedLength: true),
                        Mathang = c.String(maxLength: 128, fixedLength: true),
                        Dongia = c.Decimal(nullable: false, precision: 19, scale: 4),
                        Soluong = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Machitietdonhang);
            
            CreateTable(
                "dbo.sysdiagrams",
                c => new
                    {
                        diagram_id = c.Int(nullable: false, identity: true),
                        name = c.String(nullable: false, maxLength: 128),
                        principal_id = c.Int(nullable: false),
                        version = c.Int(),
                        definition = c.Binary(),
                    })
                .PrimaryKey(t => t.diagram_id);
            
        }
        
        public override void Down()
        {
            
            DropTable("dbo.Chitietdonhang");
           
        }
    }
}
