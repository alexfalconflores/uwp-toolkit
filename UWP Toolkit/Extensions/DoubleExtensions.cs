namespace UWP_Toolkit.Extensions;

public static class DoubleExtensions
{
    /// <summary>
    /// Check if the number is NaN.
    /// </summary>
    /// <param name="number"></param>
    /// <returns></returns>
    public static bool IsNaN(this double number) => double.IsNaN(number);
}
