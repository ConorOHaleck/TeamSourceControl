using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamSourceControl_AgeofEmpires
{
    public class Army
    {
        public int ArmyID { get; set; }
        public String ArmyName { get; set; }
        public String ArmyOwner { get; set; }

        public ICollection<ArmySoldier> Soldiers { get; set; }
    }
}
