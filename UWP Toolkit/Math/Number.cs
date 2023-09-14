using System;
using System.Collections.Generic;
using System.Numerics;
using UWP_Toolkit.Exceptions;

namespace UWP_Toolkit.Math;

public static class Number
{
    // System.Numerics.Complex
    //typeof(Int128), typeof(UInt128) only available in .NET 7.0 or higher
    //  int256 https://github.com/NethermindEth/int256
    private readonly static List<Type> INTEGERS = new() { typeof(Byte), typeof(SByte), typeof(Int16), typeof(UInt16), typeof(Int32), typeof(UInt32), typeof(Int64), typeof(UInt64), typeof(BigInteger) };
    private readonly static List<Type> DECIMAL = new() { typeof(Single), typeof(Double), typeof(Decimal) };

    /// <summary>
    /// Check if the number is between two numbers.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="number"></param>
    /// <param name="minValue"></param>
    /// <param name="maxValue"></param>
    /// <returns></returns>
    /// <exception cref="MinMaxException"></exception>
    public static bool IsBetween<T>(this T number, T minValue, T maxValue) where T : struct, IComparable<T>
    {
        if (minValue.CompareTo(maxValue) > 0)
            throw new MinMaxException("The minValue cannot be greater than the maxValue.");
        return number.CompareTo(minValue) >= 0 && number.CompareTo(maxValue) <= 0;
    }

    /// <summary>
    /// Check if the number is positive. Zero is considered positive or negative.
    /// </summary>
    /// <param name="number"></param>
    /// <returns></returns>
    public static bool IsPositive<T>(this T number) where T : struct, IComparable<T>
    {
        T zero = default(T);
        return number.CompareTo(zero) >= 0;
    }

    /// <summary>
    /// Check if the number is negative. Zero is considered positive or negative.
    /// </summary>
    /// <param name="number"></param>
    /// <returns></returns>
    public static bool IsNegative<T>(this T number) where T : struct, IComparable<T>
    {
        T zero = default(T);
        return number.CompareTo(zero) <= 0;
    }

    /// <summary>
    /// Check if the number is zero.
    /// </summary>
    /// <param name="number"></param>
    /// <returns></returns>
    public static bool IsZero<T>(this T number) where T : struct, IComparable<T>
    {
        T zero = default(T);
        return number.CompareTo(zero) == 0;
    }

    /// <summary>
    /// Check if the number is integer.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="number"></param>
    /// <returns></returns>
    public static bool IsInteger<T>(this T number) where T : struct, IComparable<T> => INTEGERS.Contains(number.GetType());

    /// <summary>
    /// Check if the number is decimal.(float,32bits: Single, double,64bits: Double or decimal)
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="number"></param>
    /// <returns></returns>
    public static bool IsDecimal<T>(this T number) where T : struct, IComparable<T> => DECIMAL.Contains(number.GetType());

    /// <summary>
    /// Check if the number is natural. Zero is considered natural default, but you can change it.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="number"></param>
    /// <param name="includeZero"></param>
    /// <returns></returns>
    public static bool IsNatural<T>(this T number, bool includeZero = true) where T : struct, IComparable<T>
    {
        int min = includeZero ? 0 : 1;
        T zero = default(T);
        return IsInteger(number) && number.CompareTo(zero) >= min;
    }
}
