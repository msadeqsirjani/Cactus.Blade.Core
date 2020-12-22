using System;

public static partial class Extension
{
    /// <summary>
    /// Returns the last character of a string.
    /// </summary>
    /// 
    /// <returns>
    /// The value at the last character in the source string.
    /// </returns>
    /// <param name="this">A <see cref="T:System.String"/> to return the last character of.</param>
    /// <exception cref="T:System.ArgumentNullException"><paramref name="this"/> is null.</exception>
    /// <exception cref="T:System.InvalidOperationException">The source string is empty.</exception>
    public static char Last(this string @this)
    {
        if (@this == null)
            throw new ArgumentNullException(nameof(@this));

        var length = @this.Length;

        if (length == 0)
            throw new InvalidOperationException($"{nameof(@this)} string cannot be empty but is.");

        return @this[length - 1];
    }

    /// <summary>
    /// Returns the last character of a string that satisfies a specified condition.
    /// </summary>
    /// 
    /// <returns>
    /// The last character in the string that passes the test in the specified predicate function.
    /// </returns>
    /// <param name="this">An <see cref="T:System.String"/> to return a character from.</param>
    /// <param name="predicate">A function to test each character for a condition.</param>
    /// <exception cref="T:System.ArgumentNullException"><paramref name="this"/> or <paramref name="predicate"/> is null.</exception>
    /// <exception cref="T:System.InvalidOperationException">No character satisfies the condition in <paramref name="predicate"/>.-or-The source string is empty.</exception>
    public static char Last(this string @this, Func<char, bool> predicate)
    {
        return LastImplementation(@this, predicate, true);
    }

    internal static char LastImplementation(string @this, Func<char, bool> predicate, bool throwExceptionOnEmptyOrNotFound)
    {
        if (@this == null)
            throw new ArgumentNullException(nameof(@this));
        if (predicate == null)
            throw new ArgumentNullException(nameof(predicate));

        var length = @this.Length;

        if (length == 0)
        {
            if (throwExceptionOnEmptyOrNotFound)
            {
                throw new InvalidOperationException("Source string cannot be empty but is.");
            }
            return default;

        }

        var chars = @this.ToCharArray();
        var i = @this.Length;
        while (i-- > 0)
        {
            var character = chars[i];
            if (predicate(character))
                return character;
        }

        if (throwExceptionOnEmptyOrNotFound)
            throw new InvalidOperationException(
                "Predicate test did not match any characters in source string: " + @this);

        return default;
    }
}