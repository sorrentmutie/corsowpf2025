using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;
using WpfApp2.Helpers;

namespace WpfApp2.Customers
{
    public class CustomersListViewModel : INotifyPropertyChanged
    {
        private readonly ICustomersRepository _customersRepository;
        private Customer selectedCustomer;

        public event PropertyChangedEventHandler PropertyChanged;

        //= new CustomersService();
        public Customer SelectedCustomer
        {
            get
            {
                return selectedCustomer;
            }
            set
            {
                if (value != selectedCustomer)
                {
                    selectedCustomer = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(SelectedCustomer)));
                    ((RelayCommand)RemoveCustomerCommand).RaiseCanExecuteChanged();
                }
            }
        }

        public ObservableCollection<Customer> Customers { get; set; } = new ObservableCollection<Customer>();

        public ICommand AddCustomerCommand { get; set; }
        public ICommand RemoveCustomerCommand { get; set; }

        public CustomersListViewModel(ICustomersRepository customerRepository)
        {
            _customersRepository = customerRepository;
            var customers = _customersRepository.GetAllCustomersAsync().Result;
            foreach (var customer in customers)
            {
                Customers.Add(customer);
            }
            AddCustomerCommand = new RelayCommand(AddCustomer);
            RemoveCustomerCommand = new RelayCommand(RemoveCustomer, IsCustomerSelected);
        }

        private void AddCustomer()
        {
            Customers.Add(new Customer { Id = Guid.NewGuid().ToString(), FullName = "New Customer" });
        }

        private void RemoveCustomer()
        {
            Customers.Remove(SelectedCustomer);
        }

        private bool IsCustomerSelected()
        {
            return SelectedCustomer != null;
        }
    }
}
