using System.Collections.Generic;
using System.Threading.Tasks;

namespace WpfApp2.Customers
{
    public interface ICustomersRepository
    {
        Task<List<Customer>> GetAllCustomersAsync();
        Task<Customer> GetCustomerByIdAsync(string id);
        Task AddCustomerAsync(Customer customer);
    }
}
