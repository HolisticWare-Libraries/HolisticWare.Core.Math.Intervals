using System;

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
            Interval<T> retval = new Interval<T>();

            return retval;
        }

        public static Interval<T> operator -(Interval<T> i1, Interval<T> i2)
        {
            Interval<T> retval = new Interval<T>();

            return retval;
        }

        public static Interval<T> operator *(Interval<T> i1, Interval<T> i2)
        {
            Interval<T> retval = new Interval<T>();

            return retval;
        }

        public static Interval<T> operator /(Interval<T> i1, Interval<T> i2)
        {
            Interval<T> retval = new Interval<T>();

            return retval;
        }
    }
}
