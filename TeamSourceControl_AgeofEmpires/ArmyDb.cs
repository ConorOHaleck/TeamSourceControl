using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamSourceControl_AgeofEmpires
{
    class ArmyDb
    {
        /// <summary>
        /// Returns a list of all the armies
        /// </summary>
        public static List<Army> GetAllArmies()
        {
            AOEContext context = new AOEContext();

            List<Army> armies = (from a in context.Armies
                                 select a).ToList();

            return armies;
        }

        public static Army Add(Army army)
        {
            AOEContext context = new AOEContext();
            context.Armies.Add(army);
            context.SaveChanges();

            return army;
        }
    }
}
