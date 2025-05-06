using System.ComponentModel;

namespace DemoEditableObject
{
    public class Persona : INotifyPropertyChanged, IEditableObject
    {
        private string _nome;
        private string _cognome;

        private Persona _backupPersona;
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
        public string Cognome
        {
            get { return _cognome; }
            set
            {
                if (_cognome != value)
                {
                    _cognome = value;
                    OnPropertyChanged(nameof(Cognome));
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void BeginEdit()
        {
            _backupPersona = new Persona() { Nome = Nome, Cognome = Cognome };
        }

        public void CancelEdit()
        {
            Nome = _backupPersona.Nome;
            Cognome = _backupPersona.Cognome;
        }

        public void EndEdit()
        {
            _backupPersona = new Persona();
        }

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
