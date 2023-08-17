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
}
