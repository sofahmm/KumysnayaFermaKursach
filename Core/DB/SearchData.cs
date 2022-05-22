using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.MyDb;

namespace Core.DB
{
    public class SearchData
    {
        public static ObservableCollection<SborMilk> sborMilks { get; set; }
        public static ObservableCollection<SborMilk> searchSborMilks(string sbor)
        {
            return sborMilks = new ObservableCollection<SborMilk>(DbConnection.fermaEntities.SborMilk.Where(s => s.IdHorse.ToString().Contains(sbor)));
        }
    }
}
