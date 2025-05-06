using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoEditableObject
{
    public class Persona : INotifyPropertyChanged, IEditableObject
    {
        private string _nome;
        private string _backupNome;

        public string Nome
        {
            get { return _nome; }
            set
            {
                if (_nome != value)
                {
                    _nome = value;
                    OnPropertyChanged(nameof(Nome));
                }
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        public void BeginEdit()
        {
            _backupNome = Nome;
        }

        public void CancelEdit()
        {
            Nome = _backupNome;
        }

        public void EndEdit()
        {
            _backupNome = "";
        }

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
