using System;
using System.Collections.Generic;
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

            if (ToGetData.IsCorrectUser(id, password))
            {
                user = ToGetData.GetUser(id, password);
                Console.WriteLine("Привет, " + user.Employee.FirstName + user.Employee.Name + "(id:" +user.IdEmployee + ")");
            }

            else if (ToGetData.IsUncurrentUser(id, password))
                Console.WriteLine("Упс! Введите верные данные");


            Console.WriteLine("Вот твоё меню:");
            var idPostCurrentUser = user.Employee.IdPost;
            while (true)
            {
                switch (idPostCurrentUser)
                {
                    case "1":
                        Console.WriteLine("1. Список лошадей");
                        var listHorses = ToGetData.GetHorses();

                }
            }

            Console.ReadKey();
        }
    }
}
