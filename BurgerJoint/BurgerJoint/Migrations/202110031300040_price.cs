namespace BurgerJoint.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class price : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Orders", "UnitPrice_ItemId", c => c.Int());
            CreateIndex("dbo.Orders", "UnitPrice_ItemId");
            AddForeignKey("dbo.Orders", "UnitPrice_ItemId", "dbo.Items", "ItemId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Orders", "UnitPrice_ItemId", "dbo.Items");
            DropIndex("dbo.Orders", new[] { "UnitPrice_ItemId" });
            DropColumn("dbo.Orders", "UnitPrice_ItemId");
        }
    }
}
