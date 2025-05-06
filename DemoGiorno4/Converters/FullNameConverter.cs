using System;
using System.Globalization;
using System.Windows.Data;

namespace DemoGiorno4.Converters
{
    public class FullNameConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            string nome = values[0].ToString();
            string cognome = values[1].ToString();

            return $"{nome} {cognome}";
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            string nomecompleto = value as string;
            if (string.IsNullOrEmpty(nomecompleto))
            {
                return new object[] { "", "" };
            }
            string[] nome_cognome = nomecompleto.Split(' ');
            string nome = string.Empty;
            string cognome = string.Empty;
            if (nome_cognome.Length > 0)
            {
                nome = nome_cognome[0];
            }
            if (nome_cognome.Length > 1)
            {
                cognome = nome_cognome[1];
            }
            return new object[] { nome, cognome };
        }
    }
}
