namespace BurgerJoint.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class orderdate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Orders", "Orderdate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Orders", "Orderdate");
        }
    }
}
