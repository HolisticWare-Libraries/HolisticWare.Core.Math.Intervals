using System;
using System.Globalization;

namespace Core.Math.Intervals
{
    /// <summary>
    /// Interval
    /// </summary>
    /// <a cref="https://en.wikipedia.org/wiki/Interval_(mathematics)"/>
    /// <a cref="https://en.wikipedia.org/wiki/Interval_arithmetic"/>
    /// <a href="http://mathworld.wolfram.com/Interval.html" />
    public partial class Interval<T>
    {

        //public static Interval<T> operator +(Interval<T> i1, Interval<T> i2)
        //{
        //    return new Interval<T>
        //                    (
        //                        ArithmeticHelpers.Addition(i1.BoundLower + i2.BoundLower), 
        //                        ArithmeticHelpers.Addition(i1.BoundUpper + i2.BoundUpper)
        //                    );
        //}


        public static Interval<T> operator +(Interval<T> i1, Interval<T> i2)
        {
            return new Interval<double>
                            (
                                i1.BoundLower + i2.BoundLower,
                                i1.BoundUpper + i2.BoundUpper
                            );
        }
    }
}
