using Microsoft.Extensions.DependencyInjection;
using System.Windows;
using WpfApp2.Customers;
using WpfApp2.Orders;

namespace WpfApp2
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region old
        //private PersonaService _personaService;
        //private ChildWindowService _childWindowService;
        //private GlobalService _globalService;
        //public Persona Persona { get; set; }
        //public MainWindow(PersonaService personaService, ChildWindowService childWindowService, GlobalService globalService)
        //{
        //    InitializeComponent();

        //    var x = Application.Current.Resources["Locator"] as ViewModelLocator;

        //    _personaService = personaService;
        //    _childWindowService = childWindowService;
        //    _globalService = globalService;

        //    _globalService.IncreaseCounter();

        //    //DataContext = _personaService.GetPeople();
        //}

        //private void AddPerson_Click(object sender, RoutedEventArgs e)
        //{
        //    ((PersonaViewModel)DataContext).AddPersona();
        //}

        //private void ShowChildWindow_Click(object sender, RoutedEventArgs e)
        //{
        //    new ChildWindow(_childWindowService, _globalService).Show();
        //}
        #endregion

        public MainWindow()
        {
            InitializeComponent();
            var ordersService = App.AppHost.Services.GetService<IOrdersRepository>();
            var customersService = App.AppHost.Services.GetService<ICustomersRepository>();
            DataContext = new MainWindowViewModel(ordersService, customersService);
        }
    }
}
