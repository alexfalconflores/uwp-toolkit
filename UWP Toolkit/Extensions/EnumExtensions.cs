using System;

namespace UWP_Toolkit.Extensions;

/// <summary>
/// Enum Extensions.
/// </summary>
public static class EnumExtensions
{
    /// <summary>
    /// Convert Enum to Char.
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Char value</returns>
    public static char ToChar(this Enum value) => Convert.ToChar(value);

    /// <summary>
    /// Convert Enum to Short.
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Short number</returns>
    public static short ToShort(this Enum value) => Convert.ToInt16(value);

    /// <summary>
    /// Convert Enum to UShort.
    /// </summary>
    /// <param name="value"></param>
    /// <returns>UShort number</returns>
    public static ushort ToUShort(this Enum value) => Convert.ToUInt16(value);

    /// <summary>
    /// Convert Enum to Int.
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Int number</returns>
    public static int ToInt(this Enum value) => Convert.ToInt32(value);

    /// <summary>
    /// Convert Enum to UInt.
    /// </summary>
    /// <param name="value"></param>
    /// <returns>UInt number</returns>
    public static uint ToUInt(this Enum value) => Convert.ToUInt32(value);

    /// <summary>
    /// Convert Enum to Long.
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Long number</returns>
    public static long ToLong(this Enum value) => Convert.ToInt64(value);

    /// <summary>
    /// Convert Enum to ULong.
    /// </summary>
    /// <param name="value"></param>
    /// <returns>ULong number</returns>
    public static ulong ToULong(this Enum value) => Convert.ToUInt64(value);

    /// <summary>
    /// Convert Enum to Double.
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Double number</returns>
    public static double ToDouble(this Enum value) => Convert.ToDouble(value);

    /// <summary>
    /// Convert Enum to Float.
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Float number</returns>
    public static float ToFloat(this Enum value) => Convert.ToSingle(value);

    /// <summary>
    /// Convert Enum to Decimal.
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Decimal number</returns>
    public static decimal ToDecimal(this Enum value) => Convert.ToDecimal(value);
}
