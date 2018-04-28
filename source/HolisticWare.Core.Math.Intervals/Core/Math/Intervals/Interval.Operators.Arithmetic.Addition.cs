using System;
using System.Globalization;

namespace Core.Math.Intervals
{
    /// <summary>
    /// Interval
    /// </summary>
    /// <see cref="https://en.wikipedia.org/wiki/Interval_(mathematics)"/>
    /// <see cref="https://en.wikipedia.org/wiki/Interval_arithmetic"/>
    /// http://mathworld.wolfram.com/Interval.html
    public partial class Interval<T>
    {
        
        public static Interval<T> operator +(Interval<T> i1, Interval<T> i2)
        {
            return new Interval<T>
                            (
                                ArithmeticHelpers.Addition(i1.BoundLower + i2.BoundLower), 
                                ArithmeticHelpers.Addition(i1.BoundUpper + i2.BoundUpper)
                            );
        }

    }
}
