using System;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace WpfApp2.Models
{
    public class Persona: INotifyPropertyChanged
    {
        private int età;
        private string nome;
        private double temperatura;
        private Indirizzo indirizzoSelezionato;

        public int Id { get; set; }
        //public string Nome { get; set; }
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

        public string Nome
        {
            get => nome;
            set
            {
                if (nome != value)
                {
                    nome = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Nome)));
                }
            }
        }

        public double Temperatura
        {
            get => temperatura;
            set
            {
                if (Math.Abs(temperatura - value) > 0.01)
                {
                    temperatura = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Temperatura)));
                }
            }
        }

        public Indirizzo IndirizzoSelezionato
        {
            get => indirizzoSelezionato;
            set
            {
                if (value != indirizzoSelezionato)
                {
                    indirizzoSelezionato = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(IndirizzoSelezionato)));
                }
            }
        }

        public ObservableCollection<Indirizzo> Indirizzi { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
    }

}
