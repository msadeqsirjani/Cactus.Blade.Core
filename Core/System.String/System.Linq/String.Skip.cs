using System;

public static partial class Extension
{
    /// <summary>
    /// Bypasses the specified number of starting characters and returns the remainder of the string.
    /// </summary>
    /// 
    /// <param name="this">An <see cref="T:System.String"/> to return a substring from.</param>
    /// <param name="count">The number of characters to skip before returning the remaining elements.</param>
    /// <returns>
    /// An <see cref="T:System.String"/> which is the subset of <paramref name="this"/> after skipping <paramref name="count"/> elements..
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException"><paramref name="this"/> is null.</exception>
    public static string Skip(this string @this, int count)
    {
        if (@this == null)
            throw new ArgumentNullException(nameof(@this));

        return count <= 0
            ? @this
            : count >= @this.Length
                ? string.Empty
                : @this[count..];
    }
}