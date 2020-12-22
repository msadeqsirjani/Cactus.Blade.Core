using System;

public static partial class Extension
{
    /// <summary>
    /// Returns the character at a specified index in a string or a default value if the index is out of range.
    /// </summary>
    /// 
    /// <returns>
    /// default(<see cref="T:System.Char"/>) if the index is outside the bounds of the source string; otherwise, the character at the specified position in the source string.
    /// </returns>
    /// <param name="this">A <see cref="T:System.String"/> to return a character from.</param>
    /// <param name="index">The zero-based index of the character to retrieve.</param>
    /// <exception cref="T:System.ArgumentNullException"><paramref name="this"/> is null.</exception>
    public static char ElementAtOrDefault(this string @this, int index)
    {
        if (@this == null)
            throw new ArgumentNullException(nameof(@this));
        if (index < 0 || index >= @this.Length)
            return default;
        return @this[index];
    }
}