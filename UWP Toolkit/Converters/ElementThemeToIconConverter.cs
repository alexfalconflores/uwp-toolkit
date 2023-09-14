using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Data;

namespace UWP_Toolkit.Converters;

/// <summary>
/// Convert an ElementTheme to a Symbol Icon. Default is a TVMonitor 'uE7F4', Light is a Sun 'uE706', Dark is a Moon 'uE708'
/// </summary>
public class ElementThemeToIconConverter : IValueConverter
{
    /// <inheritdoc/>
    public object Convert(object value, Type targetType, object parameter, string language) =>
            value switch
            {
                ElementTheme.Default => "\uE7F4",
                ElementTheme.Light => "\uE706",
                ElementTheme.Dark => "\uE708",
                _ => null,
            };
    /// <inheritdoc/>
    public object ConvertBack(object value, Type targetType, object parameter, string language) =>
        throw new NotImplementedException();
}
