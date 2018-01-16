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
        : System.Collections.Generic.IEqualityComparer<Interval<T>>
    {
        public static bool operator ==(Interval<T> i1, Interval<T> i2)
        {
            bool retval = false;

            return retval;
        }

        public static bool operator !=(Interval<T> i1, Interval<T> i2)
        {
            bool retval = false;

            return retval;
        }

        public static bool operator <(Interval<T> i1, Interval<T> i2)
        {
            bool retval = false;

            return retval;
        }

        public static bool operator >(Interval<T> i1, Interval<T> i2)
        {
            bool retval = false;

            return retval;
        }

        public static bool operator <=(Interval<T> i1, Interval<T> i2)
        {
            bool retval = false;

            return retval;
        }

        public static bool operator >=(Interval<T> i1, Interval<T> i2)
        {
            bool retval = false;

            return retval;
        }

        public bool Equals(Interval<T> x, Interval<T> y)
        {
            return x.Equals(y);
        }

        public bool Equals(Interval<T> i)
        {
            if (i == null) 
            {
                return false;
            }

            return
                (this.BoundLower.Equals(i.BoundLower) && this.IsBoundLowerIncluded == i.IsBoundLowerIncluded)
                &&
                (this.BoundUpper.Equals(i.BoundUpper) && this.IsBoundUpperIncluded == i.IsBoundUpperIncluded)
                ;
        }

        public override bool Equals(object obj)
        {
            // Check for null values and compare run-time types.
            if (ReferenceEquals(null, obj) || obj == null || this.GetType() != obj.GetType())
            {
                return false;
            }
            if (ReferenceEquals(this, obj)) 
            {
                return true;
            }

            if (obj.GetType() != GetType()) 
            {
                return false;
            }

            return Equals(obj as Interval<T>);
        }

        public int GetHashCode(T obj)
        {
            throw new NotImplementedException();
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = 13;
                hashCode = (hashCode * 397) ^ this.BoundLower.GetHashCode();
                hashCode = (hashCode * 397) ^ this.BoundUpper.GetHashCode();
                return hashCode;
            }
        }        

        public int GetHashCode(Interval<T> obj)
        {
            return obj.GetHashCode();
        }
    }
}
