using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamSourceControl_AgeofEmpires
{
    class Army
    {
        public int ArmyID { get; set; }
        public int MyProperty { get; set; }
        public String ArmyName { get; set; }
        public String ArmyOwner { get; set; }

        public ICollection<ArmySoldier> ArmySoldiers { get; set; }
    }
}
