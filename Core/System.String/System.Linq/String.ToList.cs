using System;

public static partial class Extension
{
    /// <summary>
    /// Creates an array from a <see cref="T:System.String"/>.
    /// </summary>
    /// 
    /// <returns>
    /// An array that contains the characters from the input string.
    /// </returns>
    /// <param name="this">An <see cref="T:System.String"/> to create an array from.</param>
    /// <exception cref="T:System.ArgumentNullException"><paramref name="this"/> is null.</exception>
    public static char[] ToArray(this string @this)
    {
        if (@this == null)
            throw new ArgumentNullException(nameof(@this));

        return @this.ToCharArray();
    }
}