using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamSourceControl_AgeofEmpires
{
    public class Soldier
    {
        public Int16 SoldierID { get; set; }
        public String SoldierName { get; set; }
        public Boolean isRanged { get; set; }
        public byte HPMax { get; set; }
        public double RateOfFire { get; set; }
        public byte Attack { get; set; }
        public byte MArmor { get; set; }
        public byte RArmor { get; set; }

        public ICollection<ArmySoldier> Armies { get; set; }
       
        public Soldier( String Name, Boolean isRanged, byte HPMax, double RateOfFire, byte Attack, byte MArmor, byte RArmor )
        {
            this.SoldierName = Name;
            this.isRanged = isRanged;
            this.HPMax = HPMax;
            this.RateOfFire = RateOfFire;
            this.Attack = Attack;
            this.MArmor = MArmor;
            this.RArmor = RArmor;
        }

        public override string ToString()
        {
            return SoldierName;
        }
    }
}
