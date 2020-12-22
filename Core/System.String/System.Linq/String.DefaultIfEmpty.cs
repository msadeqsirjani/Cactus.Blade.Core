using System;

public static partial class Extension
{
    /// <summary>
    /// Returns the string.
    /// </summary>
    /// 
    /// <returns>
    /// The <paramref name="this"/>.
    /// </returns>
    /// <param name="this">The sequence to return.</param>
    /// <exception cref="T:System.ArgumentNullException"><paramref name="this"/> is null.</exception>
    public static string DefaultIfEmpty(this string @this)
    {
        if (@this == null)
            throw new ArgumentNullException(nameof(@this));

        return @this.IsEmpty() ? new string('\0', 1) : @this;
    }
}