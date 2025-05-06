using System.Collections.ObjectModel;

namespace DemoEditableObject
{
    public class MaiWindowViewModel
    {
        public ObservableCollection<Persona> Persone { get; set; }

        public MaiWindowViewModel()
        {
            Persone = new ObservableCollection<Persona>
            {
                new Persona { Nome = "Mario", Cognome = "M" },
                new Persona { Nome = "Luigi", Cognome = "L" },
                new Persona { Nome = "Peach", Cognome = "P" }
            };
        }
    }
}
