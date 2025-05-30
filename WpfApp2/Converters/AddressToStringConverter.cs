﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using WpfApp2.Models;

namespace WpfApp2.Converters
{
    public class AddressToStringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var indirizzo = (Indirizzo)value;
            return $"{indirizzo.Comune} - {indirizzo.Strada} / {indirizzo.Civico} \\ {indirizzo.CAP}";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
