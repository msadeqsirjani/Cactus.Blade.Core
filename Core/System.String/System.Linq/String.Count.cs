using System;

public static partial class Extension
{
    /// <summary>
    /// Returns the number of characters in a string.
    /// </summary>
    /// 
    /// <returns>
    /// The number of characters in the input string.
    /// </returns>
    /// <param name="this">A string that contains characters to be counted.</param>
    /// <exception cref="T:System.ArgumentNullException"><paramref name="this"/> is null.</exception>
    public static int Count(this string @this)
    {
        if (@this == null)
            throw new ArgumentNullException(nameof(@this));
        return @this.Length;
    }
}