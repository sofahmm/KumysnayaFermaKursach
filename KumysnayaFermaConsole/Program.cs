using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.DB;
using Core.MyDb;

namespace KumysnayaFermaConsole
{
    class Program
    {
        public static User user { get; set; }
        public static KlientAuth klient { get; set; }
        public static Horse _horse { get; set; }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите свой айди:");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите свой пароль:");
            int password = Convert.ToInt32(Console.ReadLine());

            if (Authorization.IsCorrectUser(id.ToString(), password.ToString()))
            {
                user = ToGetData.GetUser(id.ToString(), password.ToString());
                Console.WriteLine("Привет, " + user.Employee.FirstName + user.Employee.Name + "(id:" +user.IdEmployee + ")");
            }

            else if (Authorization.IsUncurrentUser(id, password))
                Console.WriteLine("Упс! Введите верные данные");


            Console.WriteLine("Вот твоё меню:");
            var idPostCurrentUser = user.Employee.IdPost;
                switch (idPostCurrentUser)
                {
                    case 1:
                        Console.WriteLine("1. Список лошадей");
                        Console.WriteLine("2. Дополнительная информация о лошади");
                        int act = Convert.ToInt32(Console.ReadLine());
                        if(act == 1)
                        {
                            foreach(var i  in ToGetData.GetHorses())
                            {
                                Console.WriteLine(i.ID);
                                Console.WriteLine(i.Name);
                                Console.WriteLine(i.Poroda.Name);
                                Console.WriteLine(i.Birthdate);
                                Console.WriteLine(i.HorseType.Name);
                            }
                        }
                        else if(act == 2)
                        {
                        foreach (var horse in ToGetData.GetMoreInfoHorse())
                        {
                            Console.WriteLine(horse.IdHorse);
                            Console.WriteLine(horse.IndexBody);
                            Console.WriteLine(horse.Weight);
                            Console.WriteLine(horse.Puls);
                            Console.WriteLine(horse.TemperatureBody);
                            Console.WriteLine("Выбрать дату/лошадь для просмотра");
                            Console.WriteLine("1. Дату");
                            Console.WriteLine("2. Лошадь");
                            int select = int.Parse(Console.ReadLine());
                            if(select == 2)
                            {
                                Horse f = new Horse();
                                Console.WriteLine("Введите айди лошади:");
                                //f.ID  idHorse = int.Parse(Console.ReadLine());
                                //if(idHorse == 100002)
                                //{
                                    
                                //    idHorse = f.ID;
                                //    foreach (var he in SortData.SortDopInfoIdHorse(idHorse))
                                //    {
                                //        Console.WriteLine(horse.IdHorse);
                                //        Console.WriteLine(horse.IndexBody);
                                //        Console.WriteLine(horse.Weight);
                                //        Console.WriteLine(horse.Puls);
                                //        Console.WriteLine(horse.TemperatureBody);
                                //    }
                                //}
                            }
                        }
                    }
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    default:
                        Console.WriteLine("Bye!");
                        break;
                }
            Console.ReadKey();
        }
    }
}
