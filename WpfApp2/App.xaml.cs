using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Windows;
using WpfApp2.Customers;
using WpfApp2.Models;
using WpfApp2.Orders;
using WpfApp2.Services;

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
                    services.AddSingleton<ChildWindow>();
                    services.AddSingleton<IClock, SystemClock>();
                    services.AddSingleton<C>();
                    services.AddSingleton<B>();
                    services.AddSingleton<A>();
                    services.AddSingleton<PersonaService>();
                    services.AddSingleton<ChildWindowService>();
                    services.AddSingleton<GlobalService>();
                    services.AddSingleton<ICustomersRepository, CustomersService>();
                    services.AddSingleton<IOrdersRepository, OrdersService>();
                    services.AddSingleton<CustomersListViewModel>();
                })
                .Build();
        }

        protected override async void OnStartup(StartupEventArgs e)
        {
            Application.Current.Resources.Add("Locator", new ViewModelLocator());
            //Application.Current.Resources["Locator"] = AppHost.Services.GetRequiredService<ViewModelLocator>();

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
