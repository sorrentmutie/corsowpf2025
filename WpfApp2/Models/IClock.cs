using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2.Models
{
    public interface IClock
    {
        DateTime GetCurrentTime();
    }

    public class StaticClock : IClock
    {
        public DateTime GetCurrentTime()
        {
            return new DateTime(2000, 1, 1);
        }
    }

    public class AtomicClock : IClock
    {
        public DateTime GetCurrentTime()
        {
            return new DateTime(2025, 1, 1);
        }
    }

    public class SystemClock : IClock
    {
        public DateTime GetCurrentTime()
        {
            return DateTime.Now;
        }
    }
}
