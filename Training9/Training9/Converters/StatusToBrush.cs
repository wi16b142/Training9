using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace Training9.Converters
{
    class StatusToBrush : IValueConverter
    {
        Brush green = new SolidColorBrush(Colors.Green);
        Brush yellow = new SolidColorBrush(Colors.Yellow);
        Brush red = new SolidColorBrush(Colors.Red);

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string status = (string)value;

            switch (status)
            {
                case "ready": return green;
                case "processing": return yellow;                
                case "waiting": return red;
            }

            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
