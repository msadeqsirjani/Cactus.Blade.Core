using System;

public static partial class Extension
{
    /// <summary>
    /// Returns a substring from the start of a string with specified length.
    /// </summary>
    /// 
    /// <returns>
    /// A <see cref="T:System.String"/> that contains at least the specified number of characters.
    /// </returns>
    /// <param name="this">The string to return a substring from.</param>
    /// <param name="count">The length of substring to return.</param>
    /// <exception cref="T:System.ArgumentNullException"><paramref name="this"/> is null.</exception>
    public static string Take(this string @this, int count)
    {
        if (@this.IsNull())
            throw new ArgumentNullException(nameof(@this));
        return count <= 0
            ? string.Empty
            : @this.Substring(0, count.Min(@this.Length));
    }
}