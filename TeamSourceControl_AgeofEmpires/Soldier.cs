using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamSourceControl_AgeofEmpires
{
    class Soldier
    {
        public int SoldierID { get; set; }
        public Boolean isRanged { get; set; }
        public int HPMax { get; set; }
        public int RateOfFire { get; set; }
        public int Attack { get; set; }
        public int MArmor { get; set; }
        public int RArmor { get; set; }

        public ICollection<ArmySoldier> ArmySoldiers { get; set; }
    }
}
