using System;

namespace UWP_Toolkit.Extensions;

public static class DoubleExtensions
{
    /// <summary>
    /// Check if the number is NaN.
    /// </summary>
    /// <param name="number"></param>
    /// <returns></returns>
    [Obsolete("This method is deprecated. Please install the package 'DotToolkit' from Nuget and use 'DotToolkit.Extensions' instead.")]
    public static bool IsNaN(this double number) => double.IsNaN(number);
}
