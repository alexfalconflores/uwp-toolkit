using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;

namespace UWP_Toolkit.Extensions;

public static class ScrollViewerExtension
{
    /// <summary>
    /// Get the <see cref="ScrollViewer"/> from <see cref="DependencyObject"/> if exists.
    /// </summary>
    /// <param name="obj"></param>
    /// <returns>
    /// Returns <see cref="ScrollViewer"/> if exists, otherwise <see langword="null"/>.
    /// </returns>
    public static ScrollViewer GetScrollViewer(this DependencyObject obj)
    {
        if (obj is ScrollViewer viewer) return viewer;
        for (int i = 0; i < VisualTreeHelper.GetChildrenCount(obj); i++)
        {
            DependencyObject child = VisualTreeHelper.GetChild(obj, i);
            ScrollViewer result = GetScrollViewer(child);
            if (result is not null) return result;
        };
        return null;
    }
}
