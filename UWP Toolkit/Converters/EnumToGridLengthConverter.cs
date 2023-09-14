using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Data;

namespace UWP_Toolkit.Converters;

/// <summary>
/// Convert an enum to a GridLength
/// </summary>
public class EnumToGridLengthConverter : IValueConverter
{
    /// <inheritdoc/>
    public object Convert(object value, Type targetType, object parameter, string language)
    {
        if (value is null || !value.GetType().IsEnum)
            throw new ArgumentException("The values is not a validate enum", nameof(value));
        int enumValue = (int)value; // Get the enum value as an int
        return new GridLength(enumValue, GridUnitType.Pixel); // Return a GridLength with the enum value as the pixel length
        // Pixel Example:
        //  <ColumnDefinition Width="10"/> // is a pixel width of 10
        //  <ColumnDefinition Width="2*"/> // is a star(Proportional) width of 2
        //  <ColumnDefinition Width="Auto"/> // is a auto width
    }

    /// <inheritdoc/>
    public object ConvertBack(object value, Type targetType, object parameter, string language)
    {
        throw new NotImplementedException();
    }
}