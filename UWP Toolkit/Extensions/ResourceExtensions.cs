using System;
using Windows.ApplicationModel.Resources;
using Windows.UI.Xaml;

namespace UWP_Toolkit.Extensions;

public static class ResourceExtensions
{
    private static ResourceLoader _resLoader = new();

    public static string GetLocalized(this string resourceKey) =>
        _resLoader.GetString(resourceKey);

    /// <summary>
    /// Replaces the format item in a specified string with the string representation of a corresponding object in a specified array.
    /// </summary>
    /// <param name="resourceKey"></param>
    /// <param name="args">An object array that contains zero or more objects to format.</param>
    /// <returns>A copy of format in which the format items have been replaced by the string representation
    ///     of the corresponding objects in args.</returns>
    public static string Format(this string resourceKey, params object[] args) =>
        string.Format(resourceKey, args);
    /// <summary>
    /// Get the <see cref="Double"/> resource from <see cref="Application.Current.Resources"/> by <see langword="string"/>.
    /// </summary>
    /// <param name="resourceKey"></param>
    /// <returns></returns>
    public static double GetDouble(this string resourceKey) =>
        (double)Application.Current.Resources[resourceKey];

    /// <summary>Get the <see cref="Style"/> by <see langword="string"/>.</summary>
    /// <param name="resourceKey"></param>
    /// <returns><see cref="Style"/></returns>
    /// <exception cref="NullReferenceException"></exception>
    public static Style GetStyle(this string resourceKey) =>
        Application.Current.Resources[resourceKey] as Style ?? throw new NullReferenceException($"{resourceKey} is null");
}
