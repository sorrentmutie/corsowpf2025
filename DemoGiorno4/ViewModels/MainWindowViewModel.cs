using DemoGiorno4.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp2.Helpers;

namespace DemoGiorno4.ViewModels
{
    public class MainWindowViewModel
    {
        public ObservableCollection<Persona> Persone { get; set; }
        public RelayCommand<Persona> EliminaPersonaCommand { get; }


        public MainWindowViewModel()
        {
            Persone = new ObservableCollection<Persona>()
            {
                new Persona() { Nome = "Mario", Cognome = "Rossi", Email = "m@gmail.com"},
                new Persona() { Nome = "Luigi", Cognome = "Bianchi", Email = "b@gmail.com"},
            };

            EliminaPersonaCommand = new RelayCommand<Persona>(
                  EliminaPersona, CanEliminaPersona);

        }

        private bool CanEliminaPersona(Persona persona)
        {
            return persona != null;
        }

        private void EliminaPersona(Persona persona)
        {
            if (persona != null && Persone.Contains(persona)) { 
                Persone.Remove(persona);
            };
        }
    }
}
