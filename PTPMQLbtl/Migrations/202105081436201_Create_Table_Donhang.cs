namespace PTPMQLbtl.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_Donhang : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Donhang",
                c => new
                    {
                        Madonhang = c.String(nullable: false, maxLength: 128),
                        Chitiethang = c.String(nullable: false),
                        Ngaydathang = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Madonhang);
            
          
        }
        
        public override void Down()
        {
           
            
            DropTable("dbo.Donhang");
        }
    }
}
