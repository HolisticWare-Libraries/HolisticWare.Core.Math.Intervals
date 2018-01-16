using System;

namespace Core.Math.Intervals
{
    /// <summary>
    /// Interval
    /// </summary>
    /// <see cref="https://en.wikipedia.org/wiki/Interval_(mathematics)"/>
    /// <see cref="https://en.wikipedia.org/wiki/Interval_arithmetic"/>
    /// http://mathworld.wolfram.com/Interval.html
    public partial class IntervalBase
    {
        public static char BoundLowerIncludedChar
        {
            get;
            set;
        }

        public static char BoundLowerExcludedChar
        {
            get;
            set;
        }

        public static char BoundUpperIncludedChar
        {
            get;
            set;
        }

        public static char BoundUpperExcludedChar
        {
            get;
            set;
        }
    }
}
