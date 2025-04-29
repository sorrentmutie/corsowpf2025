using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2.ViewModels
{
    public class ChildWindowViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private int numeroDiPersone;
        private int counter;
        private bool isChecked;
        public int NumeroDiPersone
        {
            get => numeroDiPersone;
            set
            {
                if (value != numeroDiPersone)
                {
                    numeroDiPersone = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(NumeroDiPersone)));
                }
            }
        }
        public int Counter
        {
            get => counter;
            set
            {
                if (value != counter)
                {
                    counter = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Counter)));
                    IsChecked = counter > 5;
                }
            }
        }
        public bool IsChecked
        {
            get => isChecked;
            set
            {
                if (value != isChecked)
                {
                    isChecked = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(IsChecked)));
                }
            }
        }
    }
}
