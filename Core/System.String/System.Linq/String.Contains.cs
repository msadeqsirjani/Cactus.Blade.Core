using System;

public static partial class Extension
{
    /// <summary>
    /// Determines whether a string contains a specified character by using the default equality comparer.
    /// </summary>
    /// 
    /// <returns>
    /// true if the source strings contains a character that has the specified value; otherwise, false.
    /// </returns>
    /// <param name="this">A string in which to locate a value.</param>
    /// <param name="value">The value to locate in the sequence.</param>
    /// <exception cref="T:System.ArgumentNullException"><paramref name="this"/> is null.</exception>
    public static bool Contains(this string @this, char value)
    {
        if (@this == null)
            throw new ArgumentNullException(nameof(@this));
        return @this.IndexOf(value) >= 0;
    }
}