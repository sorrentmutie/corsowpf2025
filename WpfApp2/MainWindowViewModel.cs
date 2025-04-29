using System.Collections.ObjectModel;
using System.ComponentModel;
using WpfApp2.Customers;
using System.Windows.Input;
using WpfApp2.Helpers;
using WpfApp2.Models;

namespace WpfApp2
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {

        public ObservableCollection<Persona> Persone { get; set; }
            = new ObservableCollection<Persona>();

        public ICommand AggiungiPersonaCommand { get; }


        public ObservableCollection<Customer> Customers { get; set; }
            = new ObservableCollection<Customer>();


        private string _title = "Main Title";
        public string Title
        {
            get { return _title; }
            set
            {
                _title = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Title)));
            }
        }

        public MainWindowViewModel()
        {
            Persone.Add(new Persona { Nome = "Mario", Età = 30, Temperatura = 36.5, Ruolo = "Insegnante" });
            Persone.Add(new Persona { Nome = "Luigi", Età = 35, Temperatura = 37.0, Ruolo = "Studente" });
            Persone.Add(new Persona { Nome = "Peach", Età = 28, Temperatura = 36.8, Ruolo = "Insegnante" });
            Persone.Add(new Persona { Nome = "Toad", Età = 25, Temperatura = 37.2 });
            var service = new CustomersService();
            var customers = service.GetAllCustomersAsync().Result;
            customers.ForEach(customer => Customers.Add(customer));
            AggiungiPersonaCommand = new RelayCommand(AggiungiPersona);

        }

        private void AggiungiPersona()
        {
            Persone.Add(new Persona { Id = 1, Nome = "Nuova Persona" });
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
