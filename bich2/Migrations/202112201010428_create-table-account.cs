namespace bich2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createtableaccount : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Accounts",
                c => new
                    {
                        username = c.String(nullable: false, maxLength: 128),
                        password = c.String(),
                    })
                .PrimaryKey(t => t.username);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Accounts");
        }
    }
}
