using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Data;

namespace GeeDemos.MultiBinding.ValueConverters
{
    public class RadioButtonConverter : IValueConverter
    {

        public static RadioButtonConverter Default = new RadioButtonConverter();

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (EqualityComparer<double>.Default.Equals((double)value, (double)parameter))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is bool b && b == true)
                return parameter;
            else
                return Binding.DoNothing;
        }
    }
}