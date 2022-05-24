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
        static void Main(string[] args)
        {
            Console.WriteLine("Введите свой айди:");
            string id = Console.ReadLine();
            Console.WriteLine("Введите свой пароль:");
            string password = Console.ReadLine();

            if (Authorization.IsCorrectUser(id, password))
            {
                user = ToGetData.GetUser(id, password);
                Console.WriteLine("Привет, " + user.Employee.FirstName + user.Employee.Name + "(id:" +user.IdEmployee + ")");
            }

            else if (Authorization.IsUncurrentUser(id, password))
                Console.WriteLine("Упс! Введите верные данные");


            Console.WriteLine("Вот твоё меню:");
            var idPostCurrentUser = user.Employee.IdPost;
                switch (idPostCurrentUser)
                {
                    case 1:
                        //ObservableCollection<Horse> horses = new ObservableCollection<Horse>(DbConnection.fermaEntities.Horse).ToList();
                        Console.WriteLine("1. Список лошадей");
                        int act = Convert.ToInt32(Console.ReadLine());
                        if(act == 1)
                        {
                            var listHorses = ToGetData.GetHorses();
                            for (int i = 0; listHorses.Count > i; i++)
                            {

                            }
                            Console.WriteLine(listHorses);
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
