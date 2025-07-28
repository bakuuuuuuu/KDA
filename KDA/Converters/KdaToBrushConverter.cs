// 평점 색상 컨버터

using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace KDA.Converters
{
    public class KdaToBrushConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is double kda)
            {
                // 평점이 10을 초과하면 주황색
                if (kda > 10.0)
                    return new SolidColorBrush((Color)ColorConverter.ConvertFromString("#C68C44"));
                // 평점이 3.0을 초과하면 파란색
                else if (kda > 3.0)
                    return new SolidColorBrush((Color)ColorConverter.ConvertFromString("#54B8A4"));
                // 그 외에는 회색
                else
                    return new SolidColorBrush((Color)ColorConverter.ConvertFromString("#C5C2C2"));
            }
            return Brushes.Transparent;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}