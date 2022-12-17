using System;
using System.Windows;
using System.Windows.Data;

namespace InfographicLab4.Converters
{
    public class MarginConverter: IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (value is int)
            {
                return new Thickness((int)value, 0, 0, 0);
            }
            return new Thickness();
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
