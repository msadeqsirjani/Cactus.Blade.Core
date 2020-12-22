using System;

public static partial class Extension
{
    /// <summary>
    /// Returns the last element of a string, or a default value if the string is empty.
    /// </summary>
    /// 
    /// <returns>
    /// default(<see cref="T:System.Char"/>) if the source string is empty; otherwise, the last string in the <see cref="T:System.String"/>.
    /// </returns>
    /// <param name="this">A <see cref="T:System.String"/> to return the last character of.</param>
    /// <exception cref="T:System.ArgumentNullException"><paramref name="this"/> is null.</exception>
    public static char LastOrDefault(this string @this)
    {
        if (@this == null)
            throw new ArgumentNullException(nameof(@this));

        var length = @this.Length;
        return length == 0
            ? default
            : @this[length - 1];
    }

    /// <summary>
    /// Returns the last character of a string that satisfies a condition or a default value if no such character is found.
    /// </summary>
    /// 
    /// <returns>
    /// default(<see cref="T:System.Char"/>) if the string is empty or if no characters pass the test in the predicate function; otherwise, the last character that passes the test in the predicate function.
    /// </returns>
    /// <param name="this">A <see cref="T:System.String"/> to return an character from.</param>
    /// <param name="predicate">A function to test each character for a condition.</param>
    /// <exception cref="T:System.ArgumentNullException"><paramref name="this"/> or <paramref name="predicate"/> is null.</exception>
    public static char LastOrDefault(this string @this, Func<char, bool> predicate)
    {
        return LastImplementation(@this, predicate, false);
    }
}