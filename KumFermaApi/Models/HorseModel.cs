using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.DB;
using Core.MyDb;

namespace KumFermaApi.Models
{
    public class HorseModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public Nullable<int> IdType { get; set; }
        public Nullable<System.DateTime> Birthdate { get; set; }
        public Nullable<int> IdPoroda { get; set; }

        public HorseModel(Horse horse)
        {
            ID = horse.ID;
            Name = horse.Name;
            IdType = horse.IdType;
            Birthdate = horse.Birthdate;
            IdPoroda = horse.IdPoroda;
        }
    }
}
