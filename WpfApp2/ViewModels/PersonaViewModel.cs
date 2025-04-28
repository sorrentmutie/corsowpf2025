using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using WpfApp2.Models;

namespace WpfApp2.ViewModels
{
    public class PersonaViewModel : INotifyPropertyChanged
    {
        public Persona Persona { get; set; }
        public ObservableCollection<Persona> Persone { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        public void AddPersona()
        {
            Persone.Add(new Persona
            {
                Id = 1,
                Nome = "AAAAAA"
            });
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Persone)));
        }
    }
}
