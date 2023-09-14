using System;
using System.Collections.Generic;
using UWP_Toolkit.Exceptions;

namespace UWP_Toolkit.Math;

public static class Integer
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
    /// <summary>
    /// Check if a number is even.
    /// </summary>
    /// <param name="number"></param>
    /// <returns></returns>
    public static bool IsEven(this int number)
    {
        if (number % 2 == 0) return true;
        return false;
    }

    /// <summary>
    /// Generate a sequence of odd numbers up to the given number.
    /// <para>Output: { 0, 2, 4, 6, 8, 10}</para>
    /// </summary>
    /// <param name="number"></param>
    /// <returns></returns>
    public static IEnumerable<int> Evens(this int number)
    {
        for (int i = 0; i <= number; i++)
            if (i.IsEven())
                yield return i;
    }

    /// <summary>
    /// Check if a number is odd.
    /// </summary>
    /// <param name="number"></param>
    /// <returns></returns>
    public static bool IsOdd(this int number)
    {
        if (number % 2 != 0) return true;
        return false;
    }

    /// <summary>
    /// Generate a sequence of even numbers up to the given number.
    /// <para>Output: {1 ,3 ,5 ,7 ,9}</para>
    /// </summary>
    /// <param name="number"></param>
    /// <returns></returns>
    public static IEnumerable<int> Odds(this int number)
    {
        for (int i = 0; i <= number; i++)
            if (i.IsOdd())
                yield return i;
    }

    /// <summary>
    /// Check if a number is divisible by another number.
    /// </summary>
    /// <param name="number"></param>
    /// <param name="divider"></param>
    /// <returns>Returns true if the number is divisible by the divisor, otherwise false</returns>
    /// <exception cref="DivideByZeroException">The divider cannot be zero.</exception>
    public static bool IsDivisibleBy(this int number, int divider)
    {
        if (divider == 0) throw new DivideByZeroException();
        if (number % divider == 0)
            return true;
        return false;
    }

    /// <summary>
    /// Check if a number is a multiple of another number.
    /// </summary>
    /// <param name="number"></param>
    /// <param name="multiple"></param>
    /// <returns></returns>
    /// <exception cref="MultipleOfZeroException"></exception>
    public static bool IsMultipleOf(this int number, int multiple)
    {
        if (multiple == 0) throw new MultipleOfZeroException("The multiple cannot be zero.");
        if (number % multiple == 0)
            return true;
        return false;
    }

    /// <summary>
    /// Check if the number is prime.
    /// </summary>
    /// <param name="number"></param>
    /// <returns></returns>
    public static bool IsPrime(this int number)
    {
        if (number == 0) return false;
        int prime = 0;
        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0)
                prime++;
            if (prime > 2) break;
        }
        return prime == 2;
    }

    /// <summary>
    /// Get the prime numbers until the quantity.
    /// </summary>
    /// <param name="quantity"></param>
    /// <returns></returns>
    public static IEnumerable<int> Primes(this int quantity)
    {
        for (int i = 0; i <= quantity; i++)
            //i.IsPrime().IfTrue(IsPrime => yield return i);
            if (i.IsPrime()) yield return i;
    }
}
