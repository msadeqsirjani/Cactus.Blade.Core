using System;

public static partial class Extension
{
    /// <summary>
    /// Returns the character at a specified index in a string.
    /// </summary>
    /// 
    /// <returns>
    /// The character at the specified position in the source string.
    /// </returns>
    /// <param name="this">A <see cref="T:System.String"/> to return a character from.</param>
    /// <param name="index">The zero-based index of the character to retrieve.</param>
    /// <exception cref="T:System.ArgumentNullException"><paramref name="this"/> is null.</exception>
    /// <exception cref="T:System.ArgumentOutOfRangeException"><paramref name="index"/> is less than 0 or greater than or equal to the number of elements in <paramref name="this"/>.</exception>
    public static char ElementAt(this string @this, int index)
    {
        if (@this == null)
            throw new ArgumentNullException(nameof(@this));
        if (index < 0 || index >= @this.Length)
            throw new ArgumentOutOfRangeException(nameof(index), index,
                $"Argument of of range. Requested character index {index} of a string with {@this.Length} characters.");
        return @this[index];
    }
}
