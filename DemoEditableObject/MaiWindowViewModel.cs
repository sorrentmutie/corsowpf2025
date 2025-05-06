using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoEditableObject
{
    public class MaiWindowViewModel
    {
        public ObservableCollection<Persona> Persone { get; set; }

        public MaiWindowViewModel()
        {
            Persone = new ObservableCollection<Persona>
            {
                new Persona { Nome = "Mario" },
                new Persona { Nome = "Luigi" },
                new Persona { Nome = "Peach" }
            };
        }
    }
}
