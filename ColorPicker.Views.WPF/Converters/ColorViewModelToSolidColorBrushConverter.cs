using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace ColorPicker.Views.WPF.Converters;

public class ColorViewModelToSolidColorBrushMultiConverter : IMultiValueConverter
{
    public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
    {
        if (values.Length == 4 && values[0] is float red && values[1] is float green && values[2] is float blue &&
            values[3] is float alpha)
            return new SolidColorBrush(new Color
            {
                R = (byte)(red * byte.MaxValue),
                G = (byte)(green * byte.MaxValue),
                B = (byte)(blue * byte.MaxValue),
                A = (byte)(alpha * byte.MaxValue)
            });
        throw new ArgumentException();
    }

    public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}