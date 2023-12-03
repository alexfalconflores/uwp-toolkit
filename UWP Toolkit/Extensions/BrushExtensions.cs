using Windows.UI;
using Windows.UI.Xaml.Media;

namespace UWP_Toolkit.Extensions;

/// <summary>
/// Brush Extensions.
/// </summary>
public static class BrushExtensions
{
    /// <summary>
    /// Convert a color to a SolidColorBrush.
    /// </summary>
    /// <param name="color"></param>
    /// <returns></returns>
    public static SolidColorBrush ToSolidColorBrush(this Color color)
    {
        return new SolidColorBrush(color);
    }
}
