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
using WpfApp2.Controls;
using WpfApp2.Models;
using WpfApp2.Services;
using WpfApp2.ViewModels;

namespace WpfApp2
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private PersonaService _personaService;
        private ChildWindowService _childWindowService;
        private GlobalService _globalService;
        public Persona Persona { get; set; }
        public MainWindow(PersonaService personaService, ChildWindowService childWindowService, GlobalService globalService)
        {
            InitializeComponent();

            var x = Application.Current.Resources["Locator"] as ViewModelLocator;

            _personaService = personaService;
            _childWindowService = childWindowService;
            _globalService = globalService;

            _globalService.IncreaseCounter();

            //DataContext = _personaService.GetPeople();
        }

        private void AddPerson_Click(object sender, RoutedEventArgs e)
        {
            ((PersonaViewModel)DataContext).AddPersona();
        }

        private void ShowChildWindow_Click(object sender, RoutedEventArgs e)
        {
            new ChildWindow(_childWindowService, _globalService).Show();
        }
    }
}
