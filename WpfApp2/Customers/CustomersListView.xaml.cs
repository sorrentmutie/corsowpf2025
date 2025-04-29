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

namespace WpfApp2.Customers
{
    /// <summary>
    /// Logica di interazione per CustomersListView.xaml
    /// </summary>
    public partial class CustomersListView : UserControl
    {
        public CustomersListView()
        {
            //var repository = new CustomersService();
            var repository = App.AppHost.Services.GetService<ICustomersRepository>();

            DataContext = new CustomersListViewModel(repository);
            InitializeComponent();
        }
    }
}
