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
                // 평점이 3.0을 초과시 파랑, 아니면 회색을 반환
                if (kda > 3.0)
                    return new SolidColorBrush((Color)ColorConverter.ConvertFromString("#54B8A4"));
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