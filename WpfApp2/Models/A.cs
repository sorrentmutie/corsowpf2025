using System;
using System.Threading;

namespace WpfApp2.Models
{
    public class A
    {
        private readonly B b;

        public A(B b)
        {
            Console.WriteLine("Sono nel costruttore");
            this.b = b;
        }

        public string DoSomething()
        {
            Console.WriteLine("Doing something...");

           // var b = new B();
            b.DoSomething();

            return $"Done! {b.InitialValue}";
        }
    }
}
