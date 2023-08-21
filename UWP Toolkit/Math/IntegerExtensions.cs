using System;
using System.Collections.Generic;

namespace UWP_Toolkit.Math;

public static class IntegerExtensions
{
    //public static long Fibonacci(int n)
    //{
    //    Recursive Fibonacci
    //    if (n == 0)
    //        return 0;
    //    if (n < 2)
    //        return 1;
    //    return Fibonacci(n - 1) + Fibonacci(n - 2);
    //}
    /// <summary>
    /// Get a list of Fibonacci numbers. Return Exception if n is less than 0.
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentOutOfRangeException">
    /// If <paramref name="n"/> is less than 0.
    /// </exception>
    public static List<ulong> Fibonacci(this int n)
    {
        //Iterative Fibonacci
        if (n < 0)
            throw new ArgumentOutOfRangeException(nameof(n), "n must be greater than or equal to 0.");
        List<ulong> list = new() { 0, 1 };
        if (n <= 1)
            return list.GetRange(0, (n + 1));
        for (int i = 2; i <= n; i++)
            list.Add(list[i - 1] + list[i - 2]);
        return list;
    }
}
