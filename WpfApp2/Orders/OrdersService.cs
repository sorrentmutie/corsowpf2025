using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WpfApp2.Orders
{
    public class OrdersService : IOrdersRepository
    {
        private static List<Order> orders = new List<Order>()
        {
            new Order()
            {
                Id = Guid.NewGuid().ToString(),
                CustomerId = "1",
                Date = DateTime.Now,
                Total = 1000,
            }
        };
        public async Task AddOrderAsync(Order order)
        {
            await DoSomethingAsync();
            orders.Add(order);
        }

        public async Task<List<Order>> GetAllOrdersAsync()
        {
            await DoSomethingAsync();
            return orders;
        }

        public async Task<Order> GetOrderByIdAsync(string id)
        {
            await DoSomethingAsync();
            return orders.FirstOrDefault(order => order.Id == id);
        }

        private Task DoSomethingAsync()
        {
            return Task.CompletedTask;
        }
    }
}
