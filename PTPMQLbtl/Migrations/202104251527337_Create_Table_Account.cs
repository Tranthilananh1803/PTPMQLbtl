namespace PTPMQLbtl.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_Account : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Account",
                c => new
                    {
                        Usename = c.String(nullable: false, maxLength: 128),
                        Password = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Usename);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Account");
        }
    }
}
