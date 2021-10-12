namespace BurgerJoint.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class paydate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Payments", "Paydate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Payments", "Paydate");
        }
    }
}
