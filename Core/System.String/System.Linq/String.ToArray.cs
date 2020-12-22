using System;
using System.Collections.Generic;

public static partial class Extension
{
    /// <summary>
    /// Creates a <see cref="T:System.Collections.Generic.List`1"/> from an <see cref="T:System.String"/>.
    /// </summary>
    /// 
    /// <returns>
    /// A <see cref="T:System.Collections.Generic.List`1"/> that contains elements from the input sequence.
    /// </returns>
    /// <param name="this">The <see cref="T:System.String"/> to create a <see cref="T:System.Collections.Generic.List`1"/> from.</param>
    /// <exception cref="T:System.ArgumentNullException"><paramref name="this"/> is null.</exception>
    public static List<char> ToList(this string @this)
    {
        if (@this == null)
            throw new ArgumentNullException(nameof(@this));

        return new List<char>(@this.ToCharArray());
    }
}