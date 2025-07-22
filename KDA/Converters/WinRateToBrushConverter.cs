// 승률 색상 컨버터

using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace KDA.Converters
{
    public class WinRateToBrushConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is int winRate)
            {
                // 승률이 50%를 초과하면 빨강, 아니면 회색을 반환
                if (winRate > 50)
                    return new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF3A3A"));
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