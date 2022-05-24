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
        
        public static ObservableCollection<Order> GetOrders()
        {
            ObservableCollection<Order> orders = new ObservableCollection<Order>(DbConnection.fermaEntities.Order);
            return orders;
        }
        public static ObservableCollection<Employee> GetEmployees()
        {
            ObservableCollection<Employee> employees = new ObservableCollection<Employee>(DbConnection.fermaEntities.Employee);
            return employees;
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
        public static ObservableCollection<StatusSbora> GetStatusSbora()
        {
            ObservableCollection<StatusSbora> statusSbora = new ObservableCollection<StatusSbora>(DbConnection.fermaEntities.StatusSbora);
            return statusSbora;
        }
        public static ObservableCollection<ProductCategory> GetProductCategories()
        {
            ObservableCollection<ProductCategory> productCategories = new ObservableCollection<ProductCategory>(DbConnection.fermaEntities.ProductCategory);
            return productCategories;
        }
        public static ProductCategory GetProductCategory(string name)
        {
            return GetProductCategories().FirstOrDefault(pc => pc.Name == name);
        }

        public static User GetUserId(int idUser)
        {
            ObservableCollection<User> users = new ObservableCollection<User>(DbConnection.fermaEntities.User);
            var currentUser = users.Where(u => u.ID == idUser).FirstOrDefault();
            return currentUser;
        }
        
        //public static User GetPostId()

        public static User GetUser(string idEmployee, string password)
        {
            ObservableCollection<User> users = new ObservableCollection<User>(DbConnection.fermaEntities.User);
            var currentUser = users.Where(u => u.IdEmployee.ToString() == idEmployee && u.Password.ToString() == password).FirstOrDefault();
            return currentUser;
        }

        public static KlientAuth GetKlient(string phoneNumber)
        {
            var klients = DbConnection.fermaEntities.KlientAuth;
            var currentKlient = klients.Where(u => u.PhoneNumber == phoneNumber).FirstOrDefault();
            return currentKlient;
        }

       public static ObservableCollection<MoreInfoHorse> GetMoreInfoHorse()
        {
            ObservableCollection<MoreInfoHorse> moreInfoHorses = new ObservableCollection<MoreInfoHorse>(DbConnection.fermaEntities.MoreInfoHorse);
            return moreInfoHorses;
        }
        public static void RefreshData()
        {
            DbConnection.fermaEntities.SaveChanges();
            NewItemAddedEvent?.Invoke();
        }
        public delegate void NewItemAddedDelegate();

        public static event NewItemAddedDelegate NewItemAddedEvent;
    }
}
