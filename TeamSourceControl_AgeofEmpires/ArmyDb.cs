﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
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

        /// <summary>
        /// This class allows you to grab an army using its name, which is required in order to pull from list/comboboxes with string names
        /// </summary>
        /// <returns>An Army, identified by its name as a string</returns>
        public static Army GetArmy(string name)
        {
            AOEContext context = new AOEContext();

            Army returner = (from a in context.Armies where a.ArmyName == name select a).FirstOrDefault();
            return returner;
        }

        /// <summary>
        /// Adds an army to the database
        /// </summary>
        /// <param name="army"></param>
        public static Army Add(Army army)
        {
            AOEContext context = new AOEContext();
            context.Armies.Add(army);
            context.SaveChanges();

            return army;
        }

        /// <summary>
        /// Updates all army data except for PK
        /// </summary>
        /// <param name="a"></param>
        public static Army Update(Army a)
        {
            using (AOEContext context = new AOEContext())
            {
                context.Armies.Attach(a);
                context.Entry(a).State = EntityState.Modified;
                context.SaveChanges();
                return a;
            }
        }

        /// <summary>
        /// Deletes an army from the database by ArmyId
        /// </summary>
        /// <param name="a"></param>
        public static void Delete(Army a)
        {
            using(AOEContext context = new AOEContext())
            {
                context.Armies.Attach(a);
                context.Entry(a).State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
    }
}
