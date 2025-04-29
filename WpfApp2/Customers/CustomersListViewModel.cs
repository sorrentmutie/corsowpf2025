using System.Collections.ObjectModel;

namespace WpfApp2.Customers
{
    public class CustomersListViewModel
    {
        private readonly ICustomersRepository _customersRepository;
            //= new CustomersService();

        public ObservableCollection<Customer> Customers { get; set; } = new ObservableCollection<Customer>();




        public CustomersListViewModel(ICustomersRepository customerRepository)
        {
            _customersRepository = customerRepository;
            var customers = _customersRepository.GetAllCustomersAsync().Result;
            foreach (var customer in customers)
            {
                Customers.Add(customer);
            }
        }

    }
}
