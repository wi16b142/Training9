using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace Training9.Converters
{
    class CategoryToPositionY : IValueConverter
    {
        string Category = "";

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            Category = (string)value;

            switch (Category)
            {
                case "Category 1": return 5;
                case "Category 2": return 110;
                case "Category 3": return 215;
                case "Category 4": return 320;
                case "Category 5": return 425;
            }

            return 0;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
