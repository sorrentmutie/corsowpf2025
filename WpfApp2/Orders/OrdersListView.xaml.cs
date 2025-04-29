using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfApp2.Customers;

namespace WpfApp2.Orders
{
    /// <summary>
    /// Interaction logic for OrdersListView.xaml
    /// </summary>
    public partial class OrdersListView : UserControl
    {
        public OrdersListView()
        {
            var ordersService = 
                App.AppHost.Services.GetService<IOrdersRepository>();

            var customersService =
                App.AppHost.Services.GetService<ICustomersRepository>();

            var vm = new OrdersListViewModel(ordersService, customersService);
            DataContext = vm;
            InitializeComponent();
        }
    }
}
