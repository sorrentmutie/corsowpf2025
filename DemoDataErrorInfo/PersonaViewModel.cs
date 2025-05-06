using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace DemoDataErrorInfo
{
    public class PersonaViewModel : INotifyPropertyChanged, IDataErrorInfo
    {
        private string _nome;
        private string _cognome;
        private string _email;

        //private List<ValidationResult> errors = new List<ValidationResult>();

        //private string _messaggioErrore;

        [Required(ErrorMessage = "Il nome è obbligatorio")]
        [MinLength(3, ErrorMessage = "Il nome deve essere lungo almeno 3 caratteri")]
        public string Nome
        {
            get => _nome;
            set
            {
                if (_nome != value)
                {
                    _nome = value;
                    OnPropertyChanged(nameof(Nome));
                }
            }
        }

        [Required(ErrorMessage = "Il cognome è obbligatorio")]
        [MinLength(2, ErrorMessage = "Il cognome deve essere lungo almeno 2 caratteri")]
        public string Cognome
        {
            get => _cognome;
            set
            {
                if (_cognome != value)
                {
                    _cognome = value;
                    OnPropertyChanged(nameof(Cognome));
                }
            }
        }

        [RegularExpression(@".*\.com$", ErrorMessage = "L'indirizzo mail deve finire con .com")]
        public string Email
        {
            get => _email;
            set
            {
                if (_email != value)
                {
                    _email = value;
                    OnPropertyChanged(nameof(Email));
                }
            }
        }

        //public string MessaggioErrore
        //{
        //    get
        //    {
        //        string errore = "";
        //        errors.ForEach(error => { errore += $"{error.ErrorMessage} "; });
        //        _messaggioErrore = errore;
        //        return _messaggioErrore;
        //    }
        //    set
        //    {
        //        if (_messaggioErrore != value)
        //        {
        //            _messaggioErrore = value;
        //            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(MessaggioErrore)));
        //        }
        //    }
        //}

        public string this[string columnName]
        {
            get
            {
                var context = new ValidationContext(this)
                {
                    MemberName = columnName
                };
                var results = new List<ValidationResult>();
                bool isValid = Validator.TryValidateProperty(
                    GetType().GetProperty(columnName).GetValue(this),
                    context,
                    results);
                return results.FirstOrDefault()?.ErrorMessage;
            }
        }

        public string Error => null;

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
