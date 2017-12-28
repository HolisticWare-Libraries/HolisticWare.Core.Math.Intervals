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
        public static explicit operator Interval<T>(T t)  
        {
            Interval<T> i = new Interval<T>(t);  

            return i;
        }

        public static explicit operator T(Interval<T> i)
        {
            T t = default(T);

            return t;
        }
    }
}
