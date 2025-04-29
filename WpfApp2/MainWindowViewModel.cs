using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp2.Models;

namespace WpfApp2
{
    public class MainWindowViewModel: INotifyPropertyChanged
    {

        public ObservableCollection<Persona> Persone { get; set; } 
            = new ObservableCollection<Persona>();


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
            Persone.Add(new Persona { Nome = "Mario", Età = 30, Temperatura = 36.5, Ruolo="Insegnante" });
            Persone.Add(new Persona { Nome = "Luigi", Età = 35, Temperatura = 37.0, Ruolo = "Studente" });
            Persone.Add(new Persona { Nome = "Peach", Età = 28, Temperatura = 36.8, Ruolo = "Insegnante" });
            Persone.Add(new Persona { Nome = "Toad", Età = 25, Temperatura = 37.2 });

        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
