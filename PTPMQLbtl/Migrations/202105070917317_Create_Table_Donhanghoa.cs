namespace PTPMQLbtl.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_Donhanghoa : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Donhanghoa",
                c => new
                    {
                        Madonhang = c.String(nullable: false, maxLength: 128),
                        Tendonhang = c.String(nullable: false),
                        Sodonhang = c.Int(nullable: false),
                        Yeucau = c.String(nullable: false, maxLength: 200),
                    })
                .PrimaryKey(t => t.Madonhang);
            
            
        }
        
        public override void Down()
        {
            
            
            DropTable("dbo.Donhanghoa");
        }
    }
}
