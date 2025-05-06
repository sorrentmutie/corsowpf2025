using DemoGiorno4.Models;
using System.Collections.ObjectModel;
using System.ComponentModel;
using WpfApp2.Helpers;

namespace DemoGiorno4.ViewModels
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        private Persona _nuovaPersona = new Persona();
        public ObservableCollection<Persona> Persone { get; set; }
        public RelayCommand<Persona> EliminaPersonaCommand { get; }
        public RelayCommand<Persona> AggiungiPersonaCommand { get; }
        public Persona NuovaPersona
        {
            get
            {
                return _nuovaPersona;
            }
            set
            {
                if (value != _nuovaPersona)
                {
                    _nuovaPersona = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(NuovaPersona)));
                }
            }
        }


        public MainWindowViewModel()
        {
            Persone = new ObservableCollection<Persona>()
            {
                new Persona() { Nome = "Mario", Cognome = "Rossi", Email = "m@gmail.com"},
                new Persona() { Nome = "Luigi", Cognome = "Bianchi", Email = "b@gmail.com"},
            };

            EliminaPersonaCommand = new RelayCommand<Persona>(EliminaPersona);
            AggiungiPersonaCommand = new RelayCommand<Persona>(AggiungiPersona);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void EliminaPersona(Persona persona)
        {
            if (persona != null && Persone.Contains(persona))
            {
                Persone.Remove(persona);
            }
        }

        private void AggiungiPersona(Persona persona)
        {
            if (persona != null)
            {
                Persone.Add(persona);
                NuovaPersona = new Persona();
            }
        }
    }
}
