using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2.Models
{
    public class C
    {
        private readonly IClock clock;

        public int InitialValue { get; set; } = 15;
        public C(IClock clock)
        {
            Console.WriteLine("Sono nel costruttore di C");

            if(clock.GetCurrentTime().Hour <=12 )
            {
                InitialValue = 10;
            }
            else
            {
                InitialValue = 30;
            }

            this.clock = clock;
        }
        public void DoSomething()
        {
            Console.WriteLine("Doing something in C...");
            Console.WriteLine("Done in C!");
        }
    }
}
