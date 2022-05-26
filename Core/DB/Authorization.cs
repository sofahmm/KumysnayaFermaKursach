using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DB
{
    public class Authorization
    {
        public static bool IsCorrectUser(string Id, string password)
        {
            var users = DbConnection.fermaEntities.User.ToList();
            var currentUser = users.Where(a => a.IdEmployee.ToString() == Id && a.Password.ToString() == password).ToList();
            return currentUser.Count == 1;
        }
        public static bool IsCorrectKlient(string phoneNumber)
        {
            var klient = DbConnection.fermaEntities.KlientAuth.ToList();
            var currentKlient = klient.Where(a => a.PhoneNumber == phoneNumber).ToList();
            return currentKlient.Count == 1;
        }

        public static bool IsUncurrentUser(int Id, int password)
        {
            var users = DbConnection.fermaEntities.User;
            var currentUser = users.Where(a => a.IdEmployee == Id && a.Password == password).ToList();
            return currentUser.Count == 0;
        }
        public static bool IsUncurrentKlient(string phoneNumber)
        {
            var klients = DbConnection.fermaEntities.KlientAuth;
            var currenKlient = klients.Where(a => a.PhoneNumber == phoneNumber).ToList();
            return currenKlient.Count == 0;

        }


    }
}
