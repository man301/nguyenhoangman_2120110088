namespace WebBanHaiSan.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateData : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tb_Category", "Allias", c => c.String());
            AddColumn("dbo.tb_New", "Allias", c => c.String());
            AddColumn("dbo.tb_Post", "Allias", c => c.String());
            AddColumn("dbo.tb_Product", "Allias", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.tb_Product", "Allias");
            DropColumn("dbo.tb_Post", "Allias");
            DropColumn("dbo.tb_New", "Allias");
            DropColumn("dbo.tb_Category", "Allias");
        }
    }
}
