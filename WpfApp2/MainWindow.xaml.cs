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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfApp2.Models;

namespace WpfApp2
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly A a;

        public MainWindow(A a)
        {
            InitializeComponent();
            //IClock myClock = new SystemClock();
            //var c = new C(myClock);
            //var b = new B(c);
            //var a = new A(b);
            a.DoSomething();
            this.a = a;
            myLabel.Content = a.DoSomething();
        }
    }
}
