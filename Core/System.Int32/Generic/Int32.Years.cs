using System;

public static partial class Extension
{
    // <summary>
    //     An Int32 extension method that years the given this.
    // </summary>
    // <param name = "this" > The @this to act on.</param>
    // <returns>A TimeSpan.</returns>
    public static TimeSpan Years(this int @this)
    {
        var leap = @this / 4;

        var days = 365 * @this + leap;

        return TimeSpan.FromDays(days);
    }
}