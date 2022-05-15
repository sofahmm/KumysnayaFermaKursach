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
        public static bool IsCorrectUser(string Id, string password)
        {
            var users = DbConnection.fermaEntities.User.ToList();
            var currentUser = users.Where(a => a.IdEmployee.ToString() == Id && a.Password.ToString() == password).ToList();
            return currentUser.Count == 1;
        }
        public static bool IsUncurrentUser(string Id, string password)
        {
            ObservableCollection<User> users = new ObservableCollection<User>(DbConnection.fermaEntities.User);
            var currentUser = users.Where(a => a.IdEmployee.ToString() == Id && a.Password.ToString() == password).ToList();
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
        public static ObservableCollection<Order> GetOrders()
        {
            ObservableCollection<Order> orders = new ObservableCollection<Order>(DbConnection.fermaEntities.Order);
            return orders;
        }
        public static ObservableCollection<Horse> GetHorses()
        {
            ObservableCollection<Horse> horses = new ObservableCollection<Horse>(DbConnection.fermaEntities.Horse);
            return horses;
        }
        public static ObservableCollection<HorseType> GetHorseTypes()
        {
            ObservableCollection<HorseType> horseTypes = new ObservableCollection<HorseType>(DbConnection.fermaEntities.HorseType);
            return horseTypes;
        }
        public static ObservableCollection<Unit> GetUnits()
        {
            ObservableCollection<Unit> units = new ObservableCollection<Unit>(DbConnection.fermaEntities.Unit);
            return units;
        }
        public static ObservableCollection<Poroda> GetBreeds()
        {
            ObservableCollection<Poroda> poroda = new ObservableCollection<Poroda>(DbConnection.fermaEntities.Poroda);
            return poroda;
        }
        public static ObservableCollection<StatusOrder> GetStatusOrders()
        {
            ObservableCollection<StatusOrder> statusOrders = new ObservableCollection<StatusOrder>(DbConnection.fermaEntities.StatusOrder);
            return statusOrders;
        }
        public static ObservableCollection<Product> GetProducts()
        {
            ObservableCollection<Product> products = new ObservableCollection<Product>(DbConnection.fermaEntities.Product);
            return products;
        }
        public static ObservableCollection<SborMilk> GetSborMilks()
        {
            ObservableCollection<SborMilk> sborMilks = new ObservableCollection<SborMilk>(DbConnection.fermaEntities.SborMilk);
            return sborMilks;
        }

        public static ObservableCollection<ProductCategory> GetProductCategories()
        {
            ObservableCollection<ProductCategory> productCategories = new ObservableCollection<ProductCategory>(DbConnection.fermaEntities.ProductCategory);
            return productCategories;
        }
        public static User GetUserId(int idUser)
        {
            ObservableCollection<User> users = new ObservableCollection<User>(DbConnection.fermaEntities.User);
            var currentUser = users.Where(u => u.ID == idUser).FirstOrDefault();
            return currentUser;
        }


        public static User GetUser(string idEmployee, string password)
        {
            ObservableCollection<User> users = new ObservableCollection<User>(DbConnection.fermaEntities.User);
            var currentUser = users.Where(u => u.IdEmployee.ToString() == idEmployee && u.Password.ToString() == password).FirstOrDefault();
            return currentUser;
        }
    }
}
