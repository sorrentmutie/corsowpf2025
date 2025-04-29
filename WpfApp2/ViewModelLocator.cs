using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2
{
    public class ViewModelLocator
    {
        public MainWindowViewModel Vm { get; set; }

        public ViewModelLocator()
        {
            Vm = new MainWindowViewModel();
        }
    }
}
