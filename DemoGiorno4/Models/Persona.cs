using System.ComponentModel;

namespace DemoGiorno4.Models
{
    public class Persona : INotifyPropertyChanged
    {
        private string _nome;
        private string _cognome;
        private string _email;
        public string Nome
        {
            get
            {
                return _nome;
            }
            set
            {
                if (value == string.Empty || value != _nome)
                {
                    _nome = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Nome)));
                }
            }
        }
        public string Cognome
        {
            get
            {
                return _cognome;
            }
            set
            {
                if (value == string.Empty || value != _cognome)
                {
                    _cognome = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Cognome)));
                }
            }
        }
        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                if (value == string.Empty || value != _email)
                {
                    _email = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Email)));
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public Persona()
        {
            Nome = string.Empty;
            Cognome = string.Empty;
            Email = string.Empty;
        }
    }
}
