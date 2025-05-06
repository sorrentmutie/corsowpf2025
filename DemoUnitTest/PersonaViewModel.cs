using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoUnitTest
{
    public class PersonaViewModel : INotifyPropertyChanged
    {
        private string _nome;
        public string Nome
        {
            get { return _nome; }
            set
            {
                if (_nome != value)
                {
                    _nome = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Nome)));
                }
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;
    }
}
