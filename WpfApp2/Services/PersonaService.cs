using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp2.Models;
using WpfApp2.ViewModels;

namespace WpfApp2.Services
{
    public class PersonaService
    {
        public ObservableCollection<Persona> CachePersone { get; set; }
        public PersonaService()
        {
            CachePersone = new ObservableCollection<Persona>()
            {
                new Persona
                {
                    Id = 1,
                    Nome = "Federico",
                    Età = 26,
                    Temperatura = 34.1,
                    Indirizzi = new ObservableCollection<Indirizzo>()
                    {
                        new Indirizzo
                        {
                            Id = 0,
                            CAP = "12042",
                            Comune = "Bra",
                            Strada = "Via Col Vento",
                            Civico = "6B"
                        },
                        new Indirizzo
                        {
                            Id = 1,
                            CAP = "12042?",
                            Comune = "Sommariva del Bosco",
                            Strada = "Via Del Campo",
                            Civico = "8C"
                        }
                    }
                },
                new Persona
                {
                    Id = 2,
                    Nome = "Alberto",
                    Età = 99,
                    Temperatura = 38.1
                },
                new Persona
                {
                    Id = 3,
                    Nome = "Luigi",
                    Età = 2,
                    Temperatura = 41.1
                }
            };
        }
        public PersonaViewModel GetPeople()
        {
            return new PersonaViewModel
            {
                Persona = CachePersone.First(),
                Persone = CachePersone
            };
        }
    }
}
