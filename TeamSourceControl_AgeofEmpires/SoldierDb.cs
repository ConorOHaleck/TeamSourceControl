using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamSourceControl_AgeofEmpires
{
    class SoldierDb
    {
        /// <summary>
        /// Returns a list of all the soldiers
        /// </summary>
        public static List<Soldier> GetAllSoldiers()
        {
            AOEContext context = new AOEContext();

            List<Soldier> soldiers = (from s in context.Soldiers
                                      select s).ToList();

            return soldiers;
        }

        /// <summary>
        /// Adds a soldier to the database
        /// </summary>
        /// <param name="soldier"></param>
        public static Soldier Add(Soldier soldier)
        {
            AOEContext context = new AOEContext();
            context.Soldiers.Add(soldier);
            context.SaveChanges();

            return soldier;
        }

        /// <summary>
        /// Updates all soldier data except PK
        /// </summary>
        /// <param name="s"></param>
        public static Soldier Update(Soldier s)
        {
            using(AOEContext context = new AOEContext())
            {
                context.Soldiers.Attach(s);
                context.Entry(s).State = EntityState.Modified;
                context.SaveChanges();
                return s;
            }
        }

        /// <summary>
        /// Deletes a soldier from the database by SoldierId
        /// </summary>
        /// <param name="s"></param>
        public static void Delete(Soldier s)
        {
            using (AOEContext context = new AOEContext())
            {
                context.Soldiers.Attach(s);
                context.Entry(s).State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
    }
}
