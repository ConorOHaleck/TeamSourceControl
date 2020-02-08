﻿using System;
using System.Collections.Generic;
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

        public static Soldier Add(Soldier soldier)
        {
            AOEContext context = new AOEContext();
            context.Soldiers.Add(soldier);
            context.SaveChanges();

            return soldier;
        }
    }
}
