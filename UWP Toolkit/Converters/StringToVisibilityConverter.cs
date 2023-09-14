using System;
using UWP_Toolkit.Extensions;
using Windows.UI.Xaml.Data;

namespace UWP_Toolkit.Converters;

/// <summary>
/// Check if a string is null or empty and return a Visibility value. if the string is null or empty, return Collapsed, otherwise return Visible.
/// </summary>
public class StringToVisibilityConverter : IValueConverter
{
    /// <inheritdoc/>
    public object Convert(object value, Type targetType, object parameter, string language)
    {
        if (value is string str)
        {
            return str.IsNullOrWhiteSpace() ? Windows.UI.Xaml.Visibility.Collapsed : Windows.UI.Xaml.Visibility.Visible;
        }
        return Windows.UI.Xaml.Visibility.Collapsed;
    }

    /// <inheritdoc/>
    public object ConvertBack(object value, Type targetType, object parameter, string language)
    {
        throw new NotImplementedException();
    }
}