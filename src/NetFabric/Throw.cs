using System.Diagnostics.CodeAnalysis;

namespace NetFabric
{
    [ExcludeFromCodeCoverage]
    static class Throw
    {
        [DoesNotReturn]
        public static void ArgumentException(string paramName, string? message = default)
            => throw new ArgumentException(paramName: paramName, message: message);

        [DoesNotReturn]
        public static void ArgumentNullException(string paramName, string? message = default)
            => throw new ArgumentNullException(paramName: paramName, message: message);

        [DoesNotReturn]
        public static T ArgumentNullException<T>(string paramName, string? message = default)
            => throw new ArgumentNullException(paramName: paramName, message: message);

        [DoesNotReturn]
        public static ref readonly T ArgumentNullExceptionRef<T>(string paramName, string? message = default)
            => throw new ArgumentNullException(paramName: paramName, message: message);

        [DoesNotReturn]
        public static void ArgumentOutOfRangeException(string paramName, string? message = default)
            => throw new ArgumentOutOfRangeException(paramName: paramName, message: message);

        [DoesNotReturn]
        public static T ArgumentOutOfRangeException<T>(string paramName, string? message = default)
            => throw new ArgumentOutOfRangeException(paramName: paramName, message: message);

        [DoesNotReturn]
        public static ref readonly T ArgumentOutOfRangeExceptionRef<T>(string paramName, string? message = default)
            => throw new ArgumentOutOfRangeException(paramName: paramName, message: message);

        [DoesNotReturn]
        public static void InvalidOperationException(string? message = default)
            => throw new InvalidOperationException(message);

        [DoesNotReturn]
        public static T InvalidOperationException<T>()
            => throw new InvalidOperationException();

        [DoesNotReturn]
        public static void NotSupportedException()
            => throw new NotSupportedException();

        [DoesNotReturn]
        public static T NotSupportedException<T>()
            => throw new NotSupportedException();

        [DoesNotReturn]
        public static void ObjectDisposedException(string objectName)
            => throw new ObjectDisposedException(objectName);

        [DoesNotReturn]
        public static T ObjectDisposedException<T>(string objectName)
            => throw new ObjectDisposedException(objectName);
    }
}