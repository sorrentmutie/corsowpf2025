using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp2.ViewModels;

namespace WpfApp2.Services
{
    public class ChildWindowService
    {
        private readonly PersonaService _personaService;
        public ChildWindowService(PersonaService personaService)
        {
            _personaService = personaService;
        }
        public ChildWindowViewModel GetChildWindowViewModel()
        {
            return new ChildWindowViewModel() { NumeroDiPersone = _personaService.CachePersone.Count };
        }
    }
}
