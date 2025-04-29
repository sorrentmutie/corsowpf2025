using System;

namespace WpfApp2.Orders
{
    public class Order
    {
        public string Id { get; set; }
        public DateTime Date { get; set; }
        public double Total { get; set; }
        public string CustomerId { get; set; }
    }
}
