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
using System.Windows.Shapes;
using WpfApp2.Services;

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for ChildWindow.xaml
    /// </summary>
    public partial class ChildWindow : Window
    {
        private ChildWindowService _childWindowService;
        private GlobalService _globalService;
        public ChildWindow(ChildWindowService childWindowService, GlobalService globalService)
        {
            InitializeComponent();
            _childWindowService = childWindowService;
            _globalService = globalService;

            _globalService.IncreaseCounter();

            var childWindowViewModel = _childWindowService.GetChildWindowViewModel();
            childWindowViewModel.Counter = globalService.GetCounter();

            DataContext = childWindowViewModel;
        }
    }
}
