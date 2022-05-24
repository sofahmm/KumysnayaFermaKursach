using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.MyDb;

namespace Core.DB
{
    public class AddData
    {
        public static bool AddKlient(KlientAuth klient)
        {
            try
            {
                DbConnection.fermaEntities.KlientAuth.Add(klient);
                DbConnection.fermaEntities.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static bool AddMoreInfoHorse(MoreInfoHorse moreInfoHorse)
        {
            try
            {
                DbConnection.fermaEntities.MoreInfoHorse.Add(moreInfoHorse);
                DbConnection.fermaEntities.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static bool AddSborMilk(SborMilk sborMilk)
        {
            try
            {
                DbConnection.fermaEntities.SborMilk.Add(sborMilk);
                DbConnection.fermaEntities.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static bool AddHorse(Horse horse)
        {
            try
            {
                DbConnection.fermaEntities.Horse.Add(horse);
                DbConnection.fermaEntities.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static bool AddOrder(Order order)
        {
            try
            {
                DbConnection.fermaEntities.Order.Add(order);
                DbConnection.fermaEntities.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
