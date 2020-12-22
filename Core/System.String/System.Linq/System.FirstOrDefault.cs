using System;

public static partial class Extension
{
    /// <summary>
    /// Returns the first character of a string, or a default value if the string is empty.
    /// </summary>
    /// 
    /// <returns>
    /// default(<see cref="T:System.Char"/>) if <paramref name="this"/> is empty; otherwise, the first character in <paramref name="this"/>.
    /// </returns>
    /// <param name="this">The <see cref="T:System.String"/> to return the first character of.</param>
    /// <exception cref="T:System.ArgumentNullException"><paramref name="this"/> is null.</exception>
    public static char FirstOrDefault(this string @this)
    {
        if (@this == null)
            throw new ArgumentNullException(nameof(@this));

        return @this.Length == 0
            ? default
            : @this[0];
    }
}