using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Data;

namespace GeeDemos.MultiBinding.ValueConverters
{
    public class CsvMultiValueConverter : IMultiValueConverter
    {
        public static CsvMultiValueConverter Default = new CsvMultiValueConverter();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="values"></param>
        /// <param name="targetType"></param>
        /// <param name="parameter"></param>
        /// <param name="culture"></param>
        /// <returns></returns>
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            var s = string.Empty;
            // no foreach here, use index i to determine when to append ;
            for (int i = 0; i < values.Length; i++)
            {
                if (i > 0) s += ";";    //avoid dangling ";" at the end of the string
                s += (string)values[i];
            }
            return s;
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            var s = ((string)value).Split(';');
            return s.ToArray<object>();
        }
    }
}
