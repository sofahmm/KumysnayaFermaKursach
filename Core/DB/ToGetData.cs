using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.MyDb;

namespace Core.DB
{
    public class ToGetData
    {
        public static bool IsCorrectUser(int Id, int password)
        {
            ObservableCollection<User> users = new ObservableCollection<User>(DbConnection.fermaEntities.User);
            var currentUser = users.Where(a => a.IdEmployee == Id && a.Password == password).ToList();
            return currentUser.Count == 1;
        }
        public static bool IsUncurrentUser(int Id, int password)
        {
            ObservableCollection<User> users = new ObservableCollection<User>(DbConnection.fermaEntities.User);
            var currentUser = users.Where(a => a.IdEmployee == Id && a.Password == password).ToList();
            return currentUser.Count == 0;
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
    }
}
