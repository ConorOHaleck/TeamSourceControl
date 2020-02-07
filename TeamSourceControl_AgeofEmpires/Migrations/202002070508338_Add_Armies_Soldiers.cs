namespace TeamSourceControl_AgeofEmpires.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_Armies_Soldiers : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Armies",
                c => new
                    {
                        ArmyID = c.Int(nullable: false, identity: true),
                        MyProperty = c.Int(nullable: false),
                        ArmyName = c.String(),
                        ArmyOwner = c.String(),
                    })
                .PrimaryKey(t => t.ArmyID);
            
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
                .PrimaryKey(t => t.ArmysoldierID)
                .ForeignKey("dbo.Armies", t => t.ArmyID, cascadeDelete: true)
                .ForeignKey("dbo.Soldiers", t => t.Soldier_SoldierID)
                .Index(t => t.ArmyID)
                .Index(t => t.Soldier_SoldierID);
            
            CreateTable(
                "dbo.Soldiers",
                c => new
                    {
                        SoldierID = c.Short(nullable: false, identity: true),
                        SoldierName = c.String(),
                        isRanged = c.Boolean(nullable: false),
                        HPMax = c.Byte(nullable: false),
                        RateOfFire = c.Double(nullable: false),
                        Attack = c.Byte(nullable: false),
                        MArmor = c.Byte(nullable: false),
                        RArmor = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.SoldierID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ArmySoldiers", "Soldier_SoldierID", "dbo.Soldiers");
            DropForeignKey("dbo.ArmySoldiers", "ArmyID", "dbo.Armies");
            DropIndex("dbo.ArmySoldiers", new[] { "Soldier_SoldierID" });
            DropIndex("dbo.ArmySoldiers", new[] { "ArmyID" });
            DropTable("dbo.Soldiers");
            DropTable("dbo.ArmySoldiers");
            DropTable("dbo.Armies");
        }
    }
}
