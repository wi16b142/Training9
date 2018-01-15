using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace Training9.Converters
{
    class PriorityToPositionX : IValueConverter
    {
        int Priority = 0;
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            Priority = (int)value;

            switch (Priority)
            {
                case 1: return 115;
                case 2: return 220;
                case 3: return 325;
            }

            return 0;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
