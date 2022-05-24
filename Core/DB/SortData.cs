using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.MyDb;

namespace Core.DB
{
    public class SortData
    {
        private static ObservableCollection<Horse> _horses { get; set; }
        private static ObservableCollection<Order> _orders { get; set; }
        private static ObservableCollection<MoreInfoHorse> _moreInfoHorses { get; set; }
        public static ObservableCollection<Horse> SortHorseBreed(Poroda poroda)
        {
            return _horses = new ObservableCollection<Horse>(DbConnection.fermaEntities.Horse.Where(por => por.Poroda.Name == poroda.Name).ToList());
        }
        public static ObservableCollection<Order> SortOrdeProductName(Product product)
        {
            return _orders = new ObservableCollection<Order>(DbConnection.fermaEntities.Order.Where(prod => prod.Product.Name == product.Name).ToList());
        }
        public static ObservableCollection<Order> SortStatusOrder(StatusOrder statusOrder)
        {
            return _orders = new ObservableCollection<Order>(DbConnection.fermaEntities.Order.Where(status => status.StatusOrder.Name == statusOrder.Name).ToList());
        }
        public static ObservableCollection<MoreInfoHorse> SortDopInfoIdHorse(Horse horse)
        {
            return _moreInfoHorses = new ObservableCollection<MoreInfoHorse>(DbConnection.fermaEntities.MoreInfoHorse.Where(idHor => idHor.IdHorse == horse.ID).ToList());
        }
    }
}
