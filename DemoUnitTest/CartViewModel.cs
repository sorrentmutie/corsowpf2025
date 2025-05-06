using System;
using System.ComponentModel;
using System.Windows.Input;

namespace DemoUnitTest
{
    public class CartViewModel : INotifyPropertyChanged
    {
        private Cart _cart;
        private IDiscountService _discountService;
        private ICurrentTime _currentTimeService;

        public Cart Cart
        {
            get { return _cart; }
            set
            {
                if (_cart != value)
                {
                    _cart = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Cart)));
                }
            }
        }
        public ICommand AddProductToCartCommand { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;

        public CartViewModel(IDiscountService discountService, ICurrentTime currentTimeService, DateTime creationTime)
        {
            _discountService = discountService;
            _currentTimeService = currentTimeService;
            AddProductToCartCommand = new RelayCommand<Product>(AddProductToCart, CanAddProductToCart);
            Cart = new Cart(creationTime);
        }

        private bool CanAddProductToCart(Product product)
        {
            var canAddProductToCart = Cart.CreationTime >= _currentTimeService.CurrentTime.AddDays(-7);
            return canAddProductToCart;
        }

        private void AddProductToCart(Product product)
        {
            if (CanAddProductToCart(product))
            {
                var discount = _discountService.Discount(product.Category);
                product.Price = (1 - discount) * product.Price;
                Cart.ProductList.Add(product);
            }
        }
    }
}
