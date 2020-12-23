public static partial class Extension
{
    /// <summary>
    ///     A T extension method that check if the value is between inclusively the minimum and maximum.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="minimum">The minimum value.</param>
    /// <param name="maximum">The maximum value.</param>
    /// <returns>true if the value is between inclusively the minimum and maximum, otherwise false.</returns>
    /// ###
    /// <typeparam name="T">Generic type parameter.</typeparam>
    public static bool InRange(this System.DateTime @this, System.DateTime minimum,
        System.DateTime maximum)
    {
        return @this.CompareTo(minimum) >= 0 && @this.CompareTo(maximum) <= 0;
    }
}