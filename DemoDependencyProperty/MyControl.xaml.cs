using System.Windows;
using System.Windows.Controls;

namespace DemoDependencyProperty
{
    /// <summary>
    /// Logica di interazione per MyControl.xaml
    /// </summary>
    public partial class MyControl : UserControl
    {
        public string Titolo
        {
            get { return (string)GetValue(TitoloProperty); }
            set { SetValue(TitoloProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Titolo.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TitoloProperty =
            DependencyProperty.Register(
                "Titolo",
                typeof(string),
                typeof(MyControl), new PropertyMetadata(
                    "TitoloDefault", OnTitoloChanged));

        private static void OnTitoloChanged(
            DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var control = d as MyControl;
            string nuovoTitolo = e.NewValue as string;
            control.MyLabel.Content = nuovoTitolo;
            // Fai qualcosa con titolo
        }

        public MyControl()
        {
            InitializeComponent();
            MyLabel.Content = Titolo;
        }

    }
}
