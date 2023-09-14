using System;
using System.Runtime.Serialization;

namespace UWP_Toolkit.Exceptions;

/// <summary>
/// The exception that is thrown when a value is outside the range of valid values.
/// </summary>
[Serializable]
public class MinMaxException : ArithmeticException
{
    /// <summary>
    /// Initializes a new instance of the <see cref="MinMaxException"/> class.
    /// </summary>
    public MinMaxException() : base()
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="MinMaxException"/> class with a specified error message.
    /// </summary>
    /// <param name="message"></param>
    public MinMaxException(string? message) : base(message)
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="MinMaxException"/> class with a specified error message and a reference to the inner exception that is the cause of this exception.
    /// </summary>
    /// <param name="message"></param>
    /// <param name="innerException"></param>
    public MinMaxException(string? message, Exception? innerException) : base(message, innerException)
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="MinMaxException"/> class with serialized data.
    /// </summary>
    /// <param name="info"></param>
    /// <param name="context"></param>
    protected MinMaxException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }
}
