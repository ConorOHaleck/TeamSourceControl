namespace TeamSourceControl_AgeofEmpires.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ManyManyMigration : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Armies", "MyProperty");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Armies", "MyProperty", c => c.Int(nullable: false));
        }
    }
}
