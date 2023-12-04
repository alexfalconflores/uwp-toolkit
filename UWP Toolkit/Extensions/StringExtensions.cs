using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Versioning;
using System.Text.RegularExpressions;
using UWP_Toolkit.Exceptions;
using UWP_Toolkit.Internal.Buffers;

namespace UWP_Toolkit.Extensions;

public static class StringExtensions
{
    /// <summary>
    /// Removes all leading and trailing white-space characters from the current <see cref="string"/> object.
    /// </summary>
    /// <param name="value"></param>
    /// <returns><see langword="string"/></returns>
    public static string TrimAround(this string value)
    {
        return value.TrimStart().TrimEnd();
    }

    /// <summary>
    /// Indicates whether the specified string is <see langword="null"/> or an <see cref="System.String.Empty"/> string.
    /// </summary>
    /// <param name="value">The <see cref="string"/> to test.</param>
    /// <returns><see langword="true"/> if the value parameter is <see langword="null"/> or an empty string (""); otherwise, <see langword="false"/>.</returns>
    public static bool IsNullOrEmpty(this string value)
    {
        return string.IsNullOrEmpty(value);
    }

    /// <summary>
    /// Indicates whether a specified string is <see langword="null"/>, empty, or consists only of white-space
    /// characters.
    /// </summary>
    /// <param name="text">The <see langword="string"/> to test.</param>
    /// <returns>
    /// <see langword="true"/> if the value parameter is <see langword="null"/> or <see cref="System.String.Empty"/>, or if value consists
    /// exclusively of white-space characters.
    ///</returns>
    public static bool IsNullOrWhiteSpace(this string value)
    {
        return string.IsNullOrWhiteSpace(value);
    }

    /// <summary>
    /// Concatenates the members of a collection, using the specified separator between each member.
    /// </summary>
    /// <typeparam name="T">The type of the members of values.</typeparam>
    /// <param name="collection">A collection that contains the objects to concatenate</param>
    /// <param name="separator">The string to use as a separator.separator is included in the returned string
    /// only if values has more than one element.</param>
    /// <returns>A string that consists of the members of values delimited by the separator string.
    /// If values has no members, the method returns System.String.Empty.</returns>
    /// <exception cref="ArgumentNullException">values is null.</exception>
    public static string Join<T>(this IEnumerable<T> collection, string? separator)
    {
        if (collection is null) throw new ArgumentNullException(nameof(collection));
        return string.Join(separator, collection);
    }

    /// <summary>
    /// Repeats the given string n times.
    /// </summary>
    /// <param name="input"></param>
    /// <param name="numberRepeat"></param>
    /// <returns>
    /// Returns the repeated string.
    /// </returns>
    /// <exception cref="ArgumentNullException"></exception>
    public static string Repeat(this string input, int numberRepeat = 1)
    {
        if (input is null) throw new ArgumentNullException(nameof(input));
        string result = "";
        for (int i = 0; i < numberRepeat; i++)
            result += input;
        return result;
    }

    private static string CaseRegex => @"[^A-Za-z0-9]+";

    /// <summary>
    /// Converts string to <see href="https://en.wikipedia.org/wiki/Camel_case">camelCase</see>.
    /// </summary>
    /// <param name="input"></param>
    /// <returns>Returns the <see href="https://en.wikipedia.org/wiki/Camel_case">camelCase</see> string.</returns>
    /// <exception cref="ArgumentNullException"></exception>
    public static string ToCamelCase(this string input)
    {
        if (input is null) throw new ArgumentNullException(nameof(input));
        input = input.ToLowerInvariant();
        string[] words = Regex.Split(input, CaseRegex).Where(words => !string.IsNullOrEmpty(words)).ToArray();
        string result = "";
        for (int i = 0; i < words.Length; i++)
        {
            if (i == 0) result += words[i];
            else result += char.ToUpperInvariant(words[i][0]) + words[i].Substring(1);
        }
        return result;
    }

    // TODO : ADD URL TO PASCAL CASE
    /// <summary>
    /// Converts string to <see href="">PascalCase</see>.
    /// </summary>
    /// <param name="input"></param>
    /// <returns>Returns the <see href="">PascalCase</see> string.</returns>
    /// <exception cref="ArgumentNullException"></exception>
    public static string ToPascalCase(this string input)
    {
        if (input is null) throw new ArgumentNullException(nameof(input));
        input = input.ToLowerInvariant();
        string[] words = Regex.Split(input, CaseRegex).Where(words => !string.IsNullOrEmpty(words)).ToArray();
        string result = "";
        for (int i = 0; i < words.Length; i++)
            result += char.ToUpperInvariant(words[i][0]) + words[i].Substring(1);
        return result;
    }

    /// <summary>
    /// Converts string to <see href="https://en.wikipedia.org/wiki/Letter_case#Special_case_styles">kebab-case</see>.
    /// </summary>
    /// <param name="input"></param>
    /// <returns>Returns the <see href="https://en.wikipedia.org/wiki/Letter_case#Special_case_styles">kebab-case</see> string.</returns>
    /// <exception cref="ArgumentNullException"></exception>
    public static string ToKebabCase(this string input)
    {
        if (input is null) throw new ArgumentNullException(nameof(input));
        input = input.ToLowerInvariant();
        string[] words = Regex.Split(input, CaseRegex).Where(words => !string.IsNullOrEmpty(words)).ToArray();
        return words.Join("-");
    }

    /// <summary>
    /// Converts string to <see href="https://en.wikipedia.org/wiki/Snake_case">snake_case</see>.
    /// </summary>
    /// <param name="input"></param>
    /// <returns>Returns the <see href="https://en.wikipedia.org/wiki/Snake_case">snake_case</see> string</returns>
    /// <exception cref="ArgumentNullException"></exception>
    public static string ToSnakeCase(this string input)
    {
        if (input is null) throw new ArgumentNullException(nameof(input));
        input = input.ToLowerInvariant();
        string[] words = Regex.Split(input, CaseRegex).Where(words => !string.IsNullOrEmpty(words)).ToArray();
        return words.Join("_");
    }

    /// <summary>
    /// Converts the characters "&", "<", ">", '"', and "'" in string to their corresponding HTML entities.
    /// </summary>
    /// <param name="input"></param>
    /// <returns>Returns the escaped string</returns>
    /// <exception cref="ArgumentNullException"></exception>
    public static string HtmlEscape(this string input)
    {
        if (input is null) throw new ArgumentNullException(nameof(input));
        return WebUtility.HtmlEncode(input);
    }

    /// <summary>
    /// The inverse of <see cref="HtmlEscape(string)"/>; this method converts the HTML entities &amp;, &lt;, &gt;, &quot;, and &#39; in string to their corresponding characters."/>
    /// </summary>
    /// <param name="input"></param>
    /// <returns> Returns the unescaped string.</returns>
    /// <exception cref="ArgumentNullException"></exception>
    public static string HtmlUnEscape(this string input)
    {
        if (input is null) throw new ArgumentNullException(nameof(input));
        return WebUtility.HtmlDecode(input);
    }

    /// <summary>
    /// Reverses a string.
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    public static string ReverseString(this string input)
    {
        var reversed = input.Reverse();
        return string.Concat(reversed);
    }
}
