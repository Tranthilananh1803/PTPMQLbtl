namespace PTPMQLbtl.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Creat_Table_Nhomhang : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Nhomhang",
                c => new
                    {
                        Manhomhang = c.Int(nullable: false, identity: true),
                        Tennhomhang = c.String(nullable: false, maxLength: 50),
                        Mota = c.String(nullable: false, maxLength: 200),
                    })
                .PrimaryKey(t => t.Manhomhang);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Nhomhang");
        }
    }
}
