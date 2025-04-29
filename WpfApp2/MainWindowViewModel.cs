using System.Windows.Input;
using WpfApp2.Customers;
using WpfApp2.Helpers;
using WpfApp2.Orders;

namespace WpfApp2
{
    public class MainWindowViewModel : BaseViewModel
    {
        #region old
        //public ObservableCollection<Persona> Persone { get; set; }
        //    = new ObservableCollection<Persona>();

        //public ObservableCollection<Customer> Customers { get; set; }
        //    = new ObservableCollection<Customer>();

        //public ICommand AggiungiPersonaCommand { get; }

        //private string _title = "Main Title";
        //public string Title
        //{
        //    get { return _title; }
        //    set => SetProperty(ref _title, value);
        //}

        //public MainWindowViewModel()
        //{
        //    Persone.Add(new Persona { Nome = "Mario", Età = 30, Temperatura = 36.5, Ruolo = "Insegnante" });
        //    Persone.Add(new Persona { Nome = "Luigi", Età = 35, Temperatura = 37.0, Ruolo = "Studente" });
        //    Persone.Add(new Persona { Nome = "Peach", Età = 28, Temperatura = 36.8, Ruolo = "Insegnante" });
        //    Persone.Add(new Persona { Nome = "Toad", Età = 25, Temperatura = 37.2 });
        //    var service = new CustomersService();
        //    var customers = service.GetAllCustomersAsync().Result;
        //    customers.ForEach(customer => Customers.Add(customer));
        //    AggiungiPersonaCommand = new RelayCommand(AggiungiPersona);

        //}

        //private void AggiungiPersona()
        //{
        //    Persone.Add(new Persona { Id = 1, Nome = "Nuova Persona" });
        //}
        #endregion
        private object _currentViewModel;
        private ICustomersRepository _customersService;
        private IOrdersRepository _ordersService;
        public object CurrentViewModel
        {
            get { return _currentViewModel; }
            set => SetProperty(ref _currentViewModel, value, nameof(CurrentViewModel));
        }
        public MainWindowViewModel(
            IOrdersRepository ordersService,
            ICustomersRepository customersService)
        {
            _customersService = customersService;
            _ordersService = ordersService;
            //CurrentViewModel = new CustomersListViewModel(customers);
            CurrentViewModel = new OrdersListViewModel(ordersService, customersService);
        }

        private RelayCommand goToOrdersCommand;
        public ICommand GoToOrdersCommand
        {
            get
            {
                if (goToOrdersCommand == null)
                {
                    goToOrdersCommand = new RelayCommand(GoToOrders);
                }

                return goToOrdersCommand;
            }
        }

        private void GoToOrders()
        {
            CurrentViewModel = new OrdersListViewModel(_ordersService, _customersService);
        }

        private RelayCommand goToCustomersCommand;
        public ICommand GoToCustomersCommand
        {
            get
            {
                if (goToCustomersCommand == null)
                {
                    goToCustomersCommand = new RelayCommand(GoToCustomers);
                }

                return goToCustomersCommand;
            }
        }

        private void GoToCustomers()
        {
            CurrentViewModel = new CustomersListViewModel(_customersService);
        }
    }
}
