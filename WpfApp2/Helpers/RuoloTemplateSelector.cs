using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace WpfApp2.Helpers
{
    public class RuoloTemplateSelector: DataTemplateSelector
    {
        public DataTemplate InsegnanteTemplate { get; set; }
        public DataTemplate StudenteTemplate { get; set; }

        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            var persona = item as Models.Persona;

            if(persona == null)
                return base.SelectTemplate(item, container);
            // Se l'oggetto non è di tipo Persona, restituisci il template predefinito
            return persona.Ruolo == "Insegnante" ? 
                InsegnanteTemplate : StudenteTemplate;

        }
    }
}
