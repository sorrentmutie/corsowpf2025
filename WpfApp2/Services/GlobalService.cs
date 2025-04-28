using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2.Services
{
    public class GlobalService
    {
        private int _counter;
        public GlobalService()
        {
            _counter = 0;
        }
        public int GetCounter()
        {
            return _counter;
        }
        public void IncreaseCounter()
        {
            _counter++;
        }
    }
}
