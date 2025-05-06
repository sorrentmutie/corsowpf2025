using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace DemoDependencyProperty
{
    public class HighlightButton : Button
    {
        public bool IsHighlighted
        {
            get { return (bool)GetValue(IsHighlightedProperty); }
            set { SetValue(IsHighlightedProperty, value); }
        }

        // Using a DependencyProperty as the backing store for IsHighlighted.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IsHighlightedProperty =
            DependencyProperty.Register(
                "IsHighlighted",
                typeof(bool),
                typeof(HighlightButton),
                new PropertyMetadata(false, IsHighlightedPropertyChanged));

        private static void IsHighlightedPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            HighlightButton button = d as HighlightButton;
            button.IsHighlighted = (bool)e.NewValue;
            if (!button.IsHighlighted)
            {
                button.Height = 200;
            }
            else
            {
                button.CustomHeight += 50;
                button.Content = button.CustomHeight;
            }
        }

        public int CustomHeight
        {
            get { return (int)GetValue(CustomHeightProperty); }
            set { SetValue(CustomHeightProperty, value); }
        }

        // Using a DependencyProperty as the backing store for CustomHeight.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CustomHeightProperty =
            DependencyProperty.Register("CustomHeight", typeof(int), typeof(HighlightButton), new PropertyMetadata(100, IsCustomHeightPropertyChanged));

        private static void IsCustomHeightPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            HighlightButton button = d as HighlightButton;
            button.CustomHeight = (int)e.NewValue;
            if (button.CustomHeight >= 300)
            {
                button.Background = Brushes.ForestGreen;
                button.CustomHeight = 0;
            }
        }
    }
}
