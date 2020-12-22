using System;

public static partial class Extension
{
    /// <summary>
    /// Returns the first character of a string.
    /// </summary>
    /// 
    /// <returns>
    /// The first character in the specified string.
    /// </returns>
    /// <param name="this">The <see cref="T:System.String"/> to return the first character of.</param>
    /// <exception cref="T:System.ArgumentNullException"><paramref name="this"/> is null.</exception>
    /// <exception cref="T:System.InvalidOperationException">The source string is empty.</exception>
    public static char First(this string @this)
    {
        if (@this.IsNullOrEmpty())
            throw new InvalidOperationException($"The {nameof(@this)} string cannot be empty or null but is.");

        return @this[0];
    }
}