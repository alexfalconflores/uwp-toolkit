namespace UWP_Toolkit.Extensions;

public static class FloatExtensions
{
    //public static float Clamp(this float value, float min, float max)
    //{
    //    if (value < min)
    //        return min;
    //    if (value > max)
    //        return max;
    //    return value;
    //}

    /// <summary>
    /// Check if the number is NaN.
    /// </summary>
    /// <param name="number"></param>
    /// <returns></returns>
    public static bool IsNaN(this float number) => float.IsNaN(number);
}
