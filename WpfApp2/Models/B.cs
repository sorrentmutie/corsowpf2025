using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2.Models
{
    public class B
    {
        private readonly C c;

        public int InitialValue { get; set; } = 5;

        public B(C c)
        {
            Console.WriteLine("Sono nel costruttore di B");
            // var c = new C();
            this.c = c;
            InitialValue = c.InitialValue;
        }

        public void DoSomething()
        {
            Console.WriteLine("Doing something in B...");
            Console.WriteLine("Done in B!");
        }
    }
}
