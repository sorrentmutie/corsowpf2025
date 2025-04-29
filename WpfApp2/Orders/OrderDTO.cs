using System;

namespace WpfApp2.Orders
{
    public class OrderDTO
    {
        public string Id { get; set; }
        public DateTime Date { get; set; }
        public double Total { get; set; }
        public string CustomerName { get; set; }
    }
}
