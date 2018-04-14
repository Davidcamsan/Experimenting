using System;
using System.Globalization;
using Xamarin.Forms;

namespace Experimenting.ViewModels
{
    public class GradeToPercentConverter : IValueConverter
    {

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return String.Format("{0}%", value);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}
