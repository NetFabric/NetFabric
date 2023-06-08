using System.Diagnostics.CodeAnalysis;

namespace NetFabric;

/// <summary>
/// Provides methods to throw exceptions.
/// </summary>
/// <remarks>
/// Methods that throw exceptions cannot be inlined by the JIT compiler. Only if thrown within a called method.
/// Using the methods in this class allows exceptions to be thrown and still let the method be a candidate to be inlined.
/// </remarks>
[ExcludeFromCodeCoverage]
public static class Throw
{
    /// <summary>
    /// Throws <see cref="ArgumentException"/>.
    /// </summary>
    /// <param name="parameterName">The name of the parameter that caused the current exception.</param>
    /// <param name="message">The error message that explains the reason for the exception.</param>
    /// <exception cref="ArgumentException">Always thrown.</exception>
    [DoesNotReturn]
    public static void ArgumentException(string parameterName, string? message = default)
        => throw new ArgumentException(paramName: parameterName, message: message);

    /// <summary>
    /// Throws <see cref="ArgumentException"/>.
    /// </summary>
    /// <typeparam name="T">The type returned by the method.</typeparam>
    /// <param name="parameterName">The name of the parameter that caused the current exception.</param>
    /// <param name="message">The error message that explains the reason for the exception.</param>
    /// <exception cref="ArgumentException">Always thrown.</exception>
    [DoesNotReturn]
    public static T ArgumentException<T>(string parameterName, string? message = default)
        => throw new ArgumentException(paramName: parameterName, message: message);

    /// <summary>
    /// Throws <see cref="ArgumentNullException"/>.
    /// </summary>
    /// <param name="parameterName">The name of the parameter that caused the current exception.</param>
    /// <param name="message">The error message that explains the reason for the exception.</param>
    /// <exception cref="ArgumentNullException">Always thrown.</exception>
    [DoesNotReturn]
    public static void ArgumentNullException(string parameterName, string? message = default)
        => throw new ArgumentNullException(paramName: parameterName, message: message);

    /// <summary>
    /// Throws <see cref="ArgumentNullException"/>.
    /// </summary>
    /// <typeparam name="T">The type returned by the method.</typeparam>
    /// <param name="parameterName">The name of the parameter that caused the current exception.</param>
    /// <param name="message">The error message that explains the reason for the exception.</param>
    /// <returns>Does not return.</returns>
    /// <exception cref="ArgumentNullException">Always thrown.</exception>
    [DoesNotReturn]
    public static T ArgumentNullException<T>(string parameterName, string? message = default)
        => throw new ArgumentNullException(paramName: parameterName, message: message);

    /// <summary>
    /// Throws <see cref="ArgumentNullException"/>.
    /// </summary>
    /// <typeparam name="T">The type returned by the method.</typeparam>
    /// <param name="parameterName">The name of the parameter that caused the current exception.</param>
    /// <param name="message">The error message that explains the reason for the exception.</param>
    /// <returns>Does not return.</returns>
    /// <exception cref="ArgumentNullException">Always thrown.</exception>
    [DoesNotReturn]
    public static ref readonly T ArgumentNullExceptionRef<T>(string parameterName, string? message = default)
        => throw new ArgumentNullException(paramName: parameterName, message: message);

    /// <summary>
    /// Throws <see cref="ArgumentOutOfRangeException"/>.
    /// </summary>
    /// <param name="parameterName">The name of the parameter that caused the current exception.</param>
    /// <param name="actualValue">The value of the argument that causes this exception.</param>
    /// <param name="message">The error message that explains the reason for the exception.</param>
    /// <exception cref="ArgumentOutOfRangeException">Always thrown.</exception>
    [DoesNotReturn]
    public static void ArgumentOutOfRangeException(string parameterName, object? actualValue, string? message = default)
        => throw new ArgumentOutOfRangeException(paramName: parameterName, actualValue: actualValue, message: message);

    /// <summary>
    /// Throws <see cref="ArgumentOutOfRangeException"/>.
    /// </summary>
    /// <typeparam name="T">The type returned by the method.</typeparam>
    /// <param name="parameterName">The name of the parameter that caused the current exception.</param>
    /// <param name="actualValue">The value of the argument that causes this exception.</param>
    /// <param name="message">The error message that explains the reason for the exception.</param>
    /// <returns>Does not return.</returns>
    /// <exception cref="ArgumentOutOfRangeException">Always thrown.</exception>
    [DoesNotReturn]
    public static T ArgumentOutOfRangeException<T>(string parameterName, object? actualValue, string? message = default)
        => throw new ArgumentOutOfRangeException(paramName: parameterName, actualValue: actualValue, message: message);

    /// <summary>
    /// Throws <see cref="ArgumentOutOfRangeException"/>.
    /// </summary>
    /// <typeparam name="T">The type returned by the method.</typeparam>
    /// <param name="parameterName">The name of the parameter that caused the current exception.</param>
    /// <param name="actualValue">The value of the argument that causes this exception.</param>
    /// <param name="message">The error message that explains the reason for the exception.</param>
    /// <returns>Does not return.</returns>
    /// <exception cref="ArgumentOutOfRangeException">Always thrown.</exception>
    [DoesNotReturn]
    public static ref readonly T ArgumentOutOfRangeExceptionRef<T>(string parameterName, object? actualValue, string? message = default)
        => throw new ArgumentOutOfRangeException(paramName: parameterName, actualValue: actualValue, message: message);

    /// <summary>
    /// Throws <see cref="InvalidOperationException"/>.
    /// </summary>
    /// <param name="message">The error message that explains the reason for the exception.</param>
    /// <param name="innerException">The exception that is the cause of the current exception, or a null reference if no inner exception is specified.</param>
    /// <exception cref="InvalidOperationException">Always thrown.</exception>
    [DoesNotReturn]
    public static void InvalidOperationException(string? message = default, Exception? innerException = default)
        => throw new InvalidOperationException(message: message, innerException: innerException);

    /// <summary>
    /// Throws <see cref="InvalidOperationException"/>.
    /// </summary>
    /// <typeparam name="T">The type returned by the method.</typeparam>
    /// <param name="message">The error message that explains the reason for the exception.</param>
    /// <param name="innerException">The exception that is the cause of the current exception, or a null reference if no inner exception is specified.</param>
    /// <returns>Does not return.</returns>
    /// <exception cref="InvalidOperationException">Always thrown.</exception>
    [DoesNotReturn]
    public static T InvalidOperationException<T>(string? message = default, Exception? innerException = default)
        => throw new InvalidOperationException(message: message, innerException: innerException);

    /// <summary>
    /// Throws <see cref="NotSupportedException"/>.
    /// </summary>
    /// <param name="message">The error message that explains the reason for the exception.</param>
    /// <param name="innerException">The exception that is the cause of the current exception, or a null reference if no inner exception is specified.</param>
    /// <exception cref="NotSupportedException">Always thrown.</exception>
    [DoesNotReturn]
    public static void NotSupportedException(string? message = default, Exception? innerException = default)
        => throw new NotSupportedException(message: message, innerException: innerException);

    /// <summary>
    /// Throws <see cref="NotSupportedException"/>.
    /// </summary>
    /// <typeparam name="T">The type returned by the method.</typeparam>
    /// <param name="message">The error message that explains the reason for the exception.</param>
    /// <param name="innerException">The exception that is the cause of the current exception, or a null reference if no inner exception is specified.</param>
    /// <returns>Does not return.</returns>
    /// <exception cref="NotSupportedException">Always thrown.</exception>
    [DoesNotReturn]
    public static T NotSupportedException<T>(string? message = default, Exception? innerException = default)
        => throw new NotSupportedException(message: message, innerException: innerException);

    /// <summary>
    /// Throws <see cref="ObjectDisposedException"/>.
    /// </summary>
    /// <param name="objectName">The name of the object that caused this exception.</param>
    /// <param name="message">The error message that explains the reason for the exception.</param>
    /// <exception cref="ObjectDisposedException">Always thrown.</exception>
    [DoesNotReturn]
    public static void ObjectDisposedException(string objectName, string? message = default)
        => throw new ObjectDisposedException(objectName: objectName, message: message);

    /// <summary>
    /// Throws <see cref="ObjectDisposedException"/>.
    /// </summary>
    /// <typeparam name="T">The type returned by the method.</typeparam>
    /// <param name="objectName">The name of the object that caused this exception.</param>
    /// <param name="message">The error message that explains the reason for the exception.</param>
    /// <returns>Does not return.</returns>
    /// <exception cref="ObjectDisposedException">Always thrown.</exception>
    [DoesNotReturn]
    public static T ObjectDisposedException<T>(string objectName, string? message = default)
        => throw new ObjectDisposedException(objectName: objectName, message: message);

    /// <summary>
    /// Throws <see cref="Exception"/>.
    /// </summary>
    /// <param name="message">The error message that explains the reason for the exception.</param>
    /// <param name="innerException">The exception that is the cause of the current exception, or a null reference if no inner exception is specified.</param>
    /// <exception cref="Exception">Always thrown.</exception>
    [DoesNotReturn]
    public static void Exception(string? message = default, Exception? innerException = default)
        => throw new Exception(message, innerException);

    /// <summary>
    /// Throws <see cref="Exception"/>.
    /// </summary>
    /// <typeparam name="T">The type returned by the method.</typeparam>
    /// <param name="message">The error message that explains the reason for the exception.</param>
    /// <param name="innerException">The exception that is the cause of the current exception, or a null reference if no inner exception is specified.</param>
    /// <returns>Does not return.</returns>
    /// <exception cref="Exception">Always thrown.</exception>
    [DoesNotReturn]
    public static T Exception<T>(string? message = default, Exception? innerException = default)
        => throw new Exception(message, innerException);
}