using System;
using System.Collections.Generic;

namespace Core.Math.Intervals
{
    /// <summary>
    /// Interval converting to enumerables
    /// </summary>
    public static partial class IntervalToListExtensionMethods
    {
        public static List<ushort> ToList(this Interval<ushort> interval)
        {
            List<ushort> retval = new List<ushort>();

            for (ushort i = interval.BoundLower; i <= interval.BoundUpper; i++)
            {
                if
                    (
                        i == interval.BoundLower && interval.IsBoundLowerIncluded
                        ||
                        i == interval.BoundUpper && interval.IsBoundUpperIncluded
                    )
                {
                    retval.Add(i);
                }
                else
                {
                    retval.Add(i);
                }
            }

            return retval;
        }

        public static List<short> ToList(this Interval<short> interval)
        {
            List<short> retval = new List<short>();

            for (short i = interval.BoundLower; i <= interval.BoundUpper; i++)
            {
                if
                    (
                        i != interval.BoundLower
                        ||
                        i != interval.BoundUpper
                        ||
                        i == interval.BoundLower && interval.IsBoundLowerIncluded
                        ||
                        i == interval.BoundUpper && interval.IsBoundUpperIncluded
                    )
                {
                    retval.Add(i);
                }
            }

            return retval;
        }

        public static List<int> ToList(this Interval<int> interval)
        {
            List<int> retval = new List<int>();

            for (int i = interval.BoundLower; i <= interval.BoundUpper; i++)
            {
                if
                    (
                        i == interval.BoundLower && interval.IsBoundLowerIncluded
                        ||
                        i == interval.BoundUpper && interval.IsBoundUpperIncluded
                    )
                {
                    retval.Add(i);
                }
                else
                {
                    retval.Add(i);
                }
            }

            return retval;
        }
    }
}
