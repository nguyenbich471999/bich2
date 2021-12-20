namespace bich2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class create_table_tinhthanh : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TinhThanh",
                c => new
                    {
                        MaTinhThanh = c.Int(nullable: false, identity: true),
                        TenTinhThanh = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.MaTinhThanh);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TinhThanh");
        }
    }
}
