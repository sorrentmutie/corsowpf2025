using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WpfApp2.Customers
{


    public class CustomersService : ICustomersRepository
    {

        private static List<Customer> customers =
    new List<Customer>
    {
            new Customer { Id = "1",
                FullName = "Mario Rossi", PhoneNumber = "6235324257"},
            new Customer { Id = "2",
                FullName = "Luigi Bianchi", PhoneNumber = "7235324257"},
            new Customer { Id = "3",
                FullName = "Giuseppe verdi", PhoneNumber = "8235324257"}
    };


        public async Task AddCustomerAsync(Customer customer)
        {
            await DoSomethingAsync();
            customers.Add(customer);
        }

        public async Task<List<Customer>> GetAllCustomersAsync()
        {
            await DoSomethingAsync();
            return customers;
        }

        public async Task<Customer> GetCustomerByIdAsync(string id)
        {
            await DoSomethingAsync();
            var customer = customers.FirstOrDefault(c => c.Id == id);
            return customer;
        }

        public async Task<Customer> GetCustomerByNameAsync(string name)
        {
            await DoSomethingAsync();
            return customers.FirstOrDefault(c => c.FullName == name);
        }

        public async Task RemoveCustomerAsync(Customer selectedCustomer)
        {
            await DoSomethingAsync();
            customers.Remove(selectedCustomer);
        }

        private Task DoSomethingAsync()
        {
            return Task.CompletedTask;
        }

    }
}
