using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using Core.DB;
//using KumysnayaFermaKursach.DB;
using Core.MyDb;

namespace KumysnayaFermaKursach
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static User user { get; set; }
        public static KlientAuth klient { get; set; }
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            Stopwatch stopWatch = new Stopwatch();

            //Task timerTask = new Task(async () => { SetTimer(); });
            Task.Run(async () => { SetTimer(); } );       

        }
        public async void SetTasks()
        {
            Task checkUserTask = Task.Run(async () => { CheckUser(); });
            Task setTimerTask = new Task(async () => { SetTimer(); });

            checkUserTask.ContinueWith(x => setTimerTask);
        }

        public async Task<bool> CheckUser()
        {
            while (true)
            {
                if (user != null)
                    break;
            }
            return true;
        }

        public async void SetTimer()
        {
            while (true)
            {
                Thread.Sleep(60000);
                if (user != null)
                {
                    user.Employee.AmountHours += 1;
                    ToGetData.RefreshData();  
                }
            }
        }
    }
}
