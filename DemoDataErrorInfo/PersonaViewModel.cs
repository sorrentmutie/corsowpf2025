using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DemoDataErrorInfo
{
    public class PersonaViewModel : INotifyPropertyChanged, IDataErrorInfo
    {
        private string _nome;

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


        public string this[string columnName]
        {
            get { 
               var context = new ValidationContext(this) { 
                   MemberName = columnName };
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
