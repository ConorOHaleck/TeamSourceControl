namespace TeamSourceControl_AgeofEmpires.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ManytoManyMigration : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ArmySoldiers", "ArmyID", "dbo.Armies");
            DropForeignKey("dbo.ArmySoldiers", "Soldier_SoldierID", "dbo.Soldiers");
            DropIndex("dbo.ArmySoldiers", new[] { "ArmyID" });
            DropIndex("dbo.ArmySoldiers", new[] { "Soldier_SoldierID" });
            CreateTable(
                "dbo.SoldierArmies",
                c => new
                    {
                        Soldier_SoldierID = c.Short(nullable: false),
                        Army_ArmyID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Soldier_SoldierID, t.Army_ArmyID })
                .ForeignKey("dbo.Soldiers", t => t.Soldier_SoldierID, cascadeDelete: true)
                .ForeignKey("dbo.Armies", t => t.Army_ArmyID, cascadeDelete: true)
                .Index(t => t.Soldier_SoldierID)
                .Index(t => t.Army_ArmyID);
            
            DropColumn("dbo.Armies", "MyProperty");
            DropTable("dbo.ArmySoldiers");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.ArmySoldiers",
                c => new
                    {
                        ArmysoldierID = c.Int(nullable: false, identity: true),
                        ArmyID = c.Int(nullable: false),
                        SoldierID = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                        Soldier_SoldierID = c.Short(),
                    })
                .PrimaryKey(t => t.ArmysoldierID);
            
            AddColumn("dbo.Armies", "MyProperty", c => c.Int(nullable: false));
            DropForeignKey("dbo.SoldierArmies", "Army_ArmyID", "dbo.Armies");
            DropForeignKey("dbo.SoldierArmies", "Soldier_SoldierID", "dbo.Soldiers");
            DropIndex("dbo.SoldierArmies", new[] { "Army_ArmyID" });
            DropIndex("dbo.SoldierArmies", new[] { "Soldier_SoldierID" });
            DropTable("dbo.SoldierArmies");
            CreateIndex("dbo.ArmySoldiers", "Soldier_SoldierID");
            CreateIndex("dbo.ArmySoldiers", "ArmyID");
            AddForeignKey("dbo.ArmySoldiers", "Soldier_SoldierID", "dbo.Soldiers", "SoldierID");
            AddForeignKey("dbo.ArmySoldiers", "ArmyID", "dbo.Armies", "ArmyID", cascadeDelete: true);
        }
    }
}
