using System.ComponentModel;

namespace WpfApp2.Models
{
    public class Persona: INotifyPropertyChanged
    {
        private int età;

        public int Id { get; set; }
        public string Nome { get; set; }
        //public int Età { get; set; }
        public int Età
        {
            get => età;
            set
            {
                if (età != value)
                {
                    età = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Età)));
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }

}
