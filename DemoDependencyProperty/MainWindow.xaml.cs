using System.Windows;

namespace DemoDependencyProperty
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // myControl.Titolo = "Nuovo Titolo";
        }

        private void ChangeHighlight(object sender, RoutedEventArgs e)
        {
            Button1.IsHighlighted = !Button1.IsHighlighted;
        }
    }
}
