using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamSourceControl_AgeofEmpires
{

    //This entire class is intended to override the normal database Initializer
    // So that certain data can be injected directly into the database
    // Especially soldier data, which shouldn't change as the application is used
    class AOEDBInitializer : CreateDatabaseIfNotExists<AOEContext>
    {
        protected override void Seed(AOEContext context)
        {
            IList<Soldier> SoldierList = new List<Soldier>();

            SoldierList.Add(new Soldier("Villager", false, 25, 2.03, 3, 0, 0));
            SoldierList.Add(new Soldier("Man-at-Arms", false, 45, 2.03, 6, 0, 1));
            SoldierList.Add(new Soldier("Spearman", false, 45, 3.05, 3, 0, 0));
            SoldierList.Add(new Soldier("Scout Cavalry", false, 45, 2.03, 5, 0, 2));
            SoldierList.Add(new Soldier("Archer", true, 30, 2.03, 4, 0, 0));
            SoldierList.Add(new Soldier("Skirmisher", true, 30, 3.05, 2, 0, 3));

            context.Soldiers.AddRange(SoldierList);

            base.Seed(context);
        }
    }
}
