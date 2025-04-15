using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using WpfApp2.Models;

namespace WpfApp2
{
    /// <summary>
    /// Logica di interazione per App.xaml
    /// </summary>
    public partial class App : Application
    {            
        public static IHost AppHost { get; private set; }

        public App()
        {
            AppHost = Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) =>
                {
                    services.AddSingleton<MainWindow>();
                    services.AddSingleton<IClock, SystemClock>();
                    services.AddSingleton<C>();
                    services.AddSingleton<B>();
                    services.AddSingleton<A>();
                })
                .Build();
        }

        protected override async void OnStartup(StartupEventArgs e)
        {
            await AppHost.StartAsync();
            var mainForm = AppHost.Services.GetRequiredService<MainWindow>();

            mainForm.Show();
        }

        protected override async void OnExit(ExitEventArgs e)
        {
            await AppHost.StopAsync();
            AppHost.Dispose();
            base.OnExit(e);
        }

    }
}
