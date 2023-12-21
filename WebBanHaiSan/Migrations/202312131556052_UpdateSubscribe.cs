namespace WebBanHaiSan.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateSubscribe : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.tb_OrderDetail");
            AddColumn("dbo.tb_OrderDetail", "Id", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.tb_Subscribe", "Email", c => c.String(nullable: false));
            AddPrimaryKey("dbo.tb_OrderDetail", "Id");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.tb_OrderDetail");
            AlterColumn("dbo.tb_Subscribe", "Email", c => c.String());
            DropColumn("dbo.tb_OrderDetail", "Id");
            AddPrimaryKey("dbo.tb_OrderDetail", new[] { "OrderId", "ProductId" });
        }
    }
}
