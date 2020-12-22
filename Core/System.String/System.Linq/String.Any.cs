using System;

public static partial class Extension
{
    /// <summary>
    /// Determines whether a string contains any elements (opposite of empty).
    /// </summary>
    /// 
    /// <returns>
    /// true if the source string contains any characters; otherwise, false.
    /// </returns>
    /// <param name="this">The <see cref="T:System.String"/> to check for emptiness.</param>
    /// <exception cref="T:System.ArgumentNullException"><paramref name="this"/> is null.</exception>
    public static bool Any(this string @this)
    {
        if (@this == null)
            throw new ArgumentNullException(nameof(@this));
        return @this.Length != 0;
    }
}