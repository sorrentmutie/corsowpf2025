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
using WpfApp2.Models;

namespace WpfApp2.Controls
{
    /// <summary>
    /// Interaction logic for PersonDataControl.xaml
    /// </summary>
    public partial class PersonDataControl : UserControl
    {
        public Persona ViewModel { get; set; }
        public PersonDataControl()
        {
            InitializeComponent();
            //ViewModel.Indirizzi
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ViewModel.Età++;
        }
    }
}
