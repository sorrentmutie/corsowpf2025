using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2.Models
{
    public class Indirizzo
    {
        public int Id { get; set; }
        public string Strada { get; set; }
        public string Civico { get; set; }
        public string CAP { get; set; }
        public string Comune { get; set; }
    }
}
