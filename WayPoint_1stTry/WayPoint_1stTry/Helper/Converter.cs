using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using WayPoint_1stTry.Models;

namespace WayPoint_1stTry.Helper
{
    public class Converter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var points = value as ICollection<Waypoint>;
            string result="";
            foreach (var point in points)
            {
                result += "PointCOde:" + point.PointCode + "\t" + "X:" + point.X + "\t" + "Y" + point.Y + "\t" + "Height" + point.Height+"\n";
            }
            return result;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return Binding.DoNothing;
        }
    }
}
