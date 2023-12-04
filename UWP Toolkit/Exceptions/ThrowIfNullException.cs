using System;
using System.Diagnostics.CodeAnalysis;

namespace UWP_Toolkit.Exceptions;

/// <summary>
/// The ArgumentException is thrown when an argument is null when it shouldn't be.
/// Ported from .NET 7.0 source code.
/// </summary>
[Serializable]
public class ThrowIfNullException : ArgumentNullException
{
    /// <summary>Throws an <see cref="ArgumentNullException"/> if <paramref name="argument"/> is null.
    /// Ported from .NET 7.0 source code.</summary>
    /// <param name="argument">The reference type argument to validate as non-null.</param>
    /// <param name="paramName">The name of the parameter with which <paramref name="argument"/> corresponds.</param>
    public static void ThrowIfNull([NotNull] object? argument, [System.Runtime.CompilerServices.CallerArgumentExpression("argument")] string? paramName = null)
    {
        if (argument is null)
        {
            Throw(paramName);
        }
    }

    [DoesNotReturn]
    internal static void Throw(string? paramName) =>
            throw new ArgumentNullException(paramName);
}
