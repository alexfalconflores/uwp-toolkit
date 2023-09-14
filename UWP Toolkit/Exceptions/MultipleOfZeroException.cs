using System;
using System.Runtime.Serialization;

namespace UWP_Toolkit.Exceptions;

/// <summary>
/// The exception that is thrown when an attempt is made to divide an integer or BigInteger value by zero.
/// </summary>
[Serializable]
public class MultipleOfZeroException : ArithmeticException
{
    /// <summary>
    /// Initializes a new instance of the <see cref="MultipleOfZeroException"/> class
    /// </summary>
    public MultipleOfZeroException() : base()
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="MultipleOfZeroException"/> class with a specified error message.
    /// </summary>
    /// <param name="message"></param>
    public MultipleOfZeroException(string? message) : base(message)
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="MultipleOfZeroException"/> class with a specified error message and a reference to the inner exception that is the cause of this exception.
    /// </summary>
    /// <param name="message"></param>
    /// <param name="innerException"></param>
    public MultipleOfZeroException(string? message, Exception? innerException) : base(message, innerException)
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="MultipleOfZeroException"/> class with serialized data.
    /// </summary>
    /// <param name="info"></param>
    /// <param name="context"></param>
    protected MultipleOfZeroException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }
}
