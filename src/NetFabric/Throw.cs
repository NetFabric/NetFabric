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
    /// <param name="message">The error message that explains the reason for the exception.</param>
    /// <exception cref="ArgumentOutOfRangeException">Always thrown.</exception>
    [DoesNotReturn]
    public static void ArgumentOutOfRangeException(string parameterName, string? message = default)
        => throw new ArgumentOutOfRangeException(paramName: parameterName, message: message);

    /// <summary>
    /// Throws <see cref="ArgumentOutOfRangeException"/>.
    /// </summary>
    /// <typeparam name="T">The type returned by the method.</typeparam>
    /// <param name="parameterName">The name of the parameter that caused the current exception.</param>
    /// <param name="message">The error message that explains the reason for the exception.</param>
    /// <returns>Does not return.</returns>
    /// <exception cref="ArgumentOutOfRangeException">Always thrown.</exception>
    [DoesNotReturn]
    public static T ArgumentOutOfRangeException<T>(string parameterName, string? message = default)
        => throw new ArgumentOutOfRangeException(paramName: parameterName, message: message);

    /// <summary>
    /// Throws <see cref="ArgumentOutOfRangeException"/>.
    /// </summary>
    /// <typeparam name="T">The type returned by the method.</typeparam>
    /// <param name="parameterName">The name of the parameter that caused the current exception.</param>
    /// <param name="message">The error message that explains the reason for the exception.</param>
    /// <returns>Does not return.</returns>
    /// <exception cref="ArgumentOutOfRangeException">Always thrown.</exception>
    [DoesNotReturn]
    public static ref readonly T ArgumentOutOfRangeExceptionRef<T>(string parameterName, string? message = default)
        => throw new ArgumentOutOfRangeException(paramName: parameterName, message: message);

    /// <summary>
    /// Throws <see cref="InvalidOperationException"/>.
    /// </summary>
    /// <param name="message">The error message that explains the reason for the exception.</param>
    /// <exception cref="InvalidOperationException">Always thrown.</exception>
    [DoesNotReturn]
    public static void InvalidOperationException(string? message = default)
        => throw new InvalidOperationException(message);

    /// <summary>
    /// Throws <see cref="InvalidOperationException"/>.
    /// </summary>
    /// <typeparam name="T">The type returned by the method.</typeparam>
    /// <returns>Does not return.</returns>
    /// <exception cref="InvalidOperationException">Always thrown.</exception>
    [DoesNotReturn]
    public static T InvalidOperationException<T>()
        => throw new InvalidOperationException();

    /// <summary>
    /// Throws <see cref="NotSupportedException"/>.
    /// </summary>
    /// <exception cref="NotSupportedException">Always thrown.</exception>
    [DoesNotReturn]
    public static void NotSupportedException()
        => throw new NotSupportedException();

    /// <summary>
    /// Throws <see cref="NotSupportedException"/>.
    /// </summary>
    /// <typeparam name="T">The type returned by the method.</typeparam>
    /// <returns>Does not return.</returns>
    /// <exception cref="NotSupportedException">Always thrown.</exception>
    [DoesNotReturn]
    public static T NotSupportedException<T>()
        => throw new NotSupportedException();

    /// <summary>
    /// Throws <see cref="ObjectDisposedException"/>.
    /// </summary>
    /// <param name="objectName">The name of the object that caused this exception.</param>
    /// <exception cref="ObjectDisposedException">Always thrown.</exception>
    [DoesNotReturn]
    public static void ObjectDisposedException(string objectName)
        => throw new ObjectDisposedException(objectName);

    /// <summary>
    /// Throws <see cref="ObjectDisposedException"/>.
    /// </summary>
    /// <typeparam name="T">The type returned by the method.</typeparam>
    /// <param name="objectName">The name of the object that caused this exception.</param>
    /// <returns>Does not return.</returns>
    /// <exception cref="ObjectDisposedException">Always thrown.</exception>
    [DoesNotReturn]
    public static T ObjectDisposedException<T>(string objectName)
        => throw new ObjectDisposedException(objectName);

    /// <summary>
    /// Throws <see cref="Exception"/>.
    /// </summary>
    /// <param name="message">The error message that explains the reason for the exception.</param>
    /// <param name="innerException">The exception that is the cause of the current exception, or a null reference if no inner exception is specified.</param>
    /// <exception cref="Exception">Always thrown.</exception>
    [DoesNotReturn]
    public static void Exception(string? message, Exception? innerException)
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
    public static T Exception<T>(string? message, Exception? innerException)
        => throw new Exception(message, innerException);
}