namespace WebBanHaiSan.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateProductCategory1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tb_ProductCategory", "IsActive", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.tb_ProductCategory", "IsActive");
        }
    }
}
