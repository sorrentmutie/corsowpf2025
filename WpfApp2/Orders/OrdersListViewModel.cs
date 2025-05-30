﻿using System.Collections.ObjectModel;
using WpfApp2.Customers;

namespace WpfApp2.Orders
{
    public class OrdersListViewModel
    {
        private readonly IOrdersRepository _ordersRepository;
        //= new OrdersService();
        private readonly ICustomersRepository _customersRepository;
        // = new CustomersService();

        public ObservableCollection<OrderDTO> Orders { get; set; } = new ObservableCollection<OrderDTO>();

        public OrdersListViewModel(IOrdersRepository ordersRepository,
            ICustomersRepository customersRepository)
        {
            _ordersRepository = ordersRepository;
            _customersRepository = customersRepository;
            var orders = _ordersRepository.GetAllOrdersAsync().Result;
            foreach (var order in orders)
            {
                var customer = _customersRepository.GetCustomerByIdAsync(order.CustomerId).Result;
                if (customer != null)
                {
                    Orders.Add(new OrderDTO()
                    {
                        Id = order.Id,
                        Date = order.Date,
                        Total = order.Total,
                        CustomerName = customer.FullName
                    });
                }
            }
        }
    }
}
