using System;

public static partial class Extension
{
    /// <summary>
    /// Determines whether two strings are equal.
    /// </summary>
    /// 
    /// <returns>
    /// true if the two strings are equal; otherwise, false.
    /// </returns>
    /// <param name="this">An <see cref="T:System.String"/> to compare to <paramref name="value"/>.</param>
    /// <param name="value">An <see cref="T:System.String"/> to compare to the first <see cref="T:System.String"/>.</param>
    /// <exception cref="T:System.ArgumentNullException"><paramref name="this"/> or <paramref name="value"/> is null.</exception>
    public static bool SequenceEqual(this string @this, string value)
    {
        if (@this.IsNull())
            throw new ArgumentNullException(nameof(@this));
        if (value.IsNull())
            throw new ArgumentNullException(nameof(value));

        return @this == value;
    }

    /// <summary>
    /// Determines whether two strings are equal by comparing their elements by using a specified <see cref="T:System.Collections.Generic.IEqualityComparer`1"/>.
    /// </summary>
    /// 
    /// <returns>
    /// true if the two strings are of equal equal according to <paramref name="comparison"/>; otherwise, false.
    /// </returns>
    /// <param name="this">An <see cref="T:System.String"/> to compare to <paramref name="value"/>.</param>
    /// <param name="value">An <see cref="T:System.String"/> to compare to the first <see cref="T:System.String"/>.</param>
    /// <param name="comparison">An <see cref="T:System.StringComparison"/> to use to compare strings.</param>
    /// <exception cref="T:System.ArgumentNullException"><paramref name="this"/> or <paramref name="value"/> is null.</exception>
    public static bool SequenceEqual(this string @this, string value, StringComparison comparison)
    {
        if (@this == null)
            throw new ArgumentNullException(nameof(@this));
        if (value == null)
            throw new ArgumentNullException(nameof(value));

        return @this.EqualsComparison(value, comparison);
    }

}