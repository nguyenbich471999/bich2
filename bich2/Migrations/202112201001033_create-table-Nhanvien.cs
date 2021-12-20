namespace bich2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createtableNhanvien : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.NhanVien", "TenTinhThanh");
        }
        
        public override void Down()
        {
            AddColumn("dbo.NhanVien", "TenTinhThanh", c => c.String());
        }
    }
}
