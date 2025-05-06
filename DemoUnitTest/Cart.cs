using System;
using System.Collections.ObjectModel;

namespace DemoUnitTest
{
    public class Cart
    {
        private string _id;
        private ObservableCollection<Product> _productList = new ObservableCollection<Product>();

        public string Id { get { return _id; } private set { } }
        public DateTime CreationTime { get; private set; }
        public ObservableCollection<Product> ProductList { get { return _productList; } set { } }

        public Cart(DateTime dateTime)
        {
            Id = Guid.NewGuid().ToString().Substring(0, 8);
            CreationTime = dateTime;
            ProductList = new ObservableCollection<Product>()
            {
                //new Product() { Id = Guid.NewGuid().ToString().Substring(0, 8) },
            };
        }
    }
}
