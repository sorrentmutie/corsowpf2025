using System.Collections.Generic;
using System.Threading.Tasks;

namespace WpfApp2.Orders
{
    public interface IOrdersRepository
    {
        Task<List<Order>> GetAllOrdersAsync();
        Task<Order> GetOrderByIdAsync(string id);
        Task AddOrderAsync(Order order);
    }
}
