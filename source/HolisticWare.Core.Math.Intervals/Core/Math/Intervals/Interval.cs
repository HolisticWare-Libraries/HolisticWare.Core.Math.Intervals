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
            /*
            TODO:
            Error CS0315: 
            The type 'int' cannot be used as type parameter 'T' in the generic type or method 'Interval<T>'. 
            There is no boxing conversion from 'int' to 'HolisticWare.Math.INumeric<int>'

             where 
                T : global::HolisticWare.Math.INumeric<T>
            */
        where T : 
                    struct,
                    IComparable,
                    IComparable<T>,
                    IConvertible,
                    IEquatable<T>,
                    IFormattable
    {
        public T BoundUpper
        {
            get;
            set;
        }

        public T BoundLower
        {
            get;
            set;
        }

        public bool IsBoundUpperIncluded
        {
            get;
            set;
        }

        public bool IsBoundLowerIncluded
        {
            get;
            set;
        }

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

        //public static Interval<T> Parse(string interval_notation)
        public Interval(string interval_notation)
        {

            return;
        }

        public Interval
                (
                    T bound_lower, T bound_upper, 
                    bool include_bound_lower = true, bool include_bound_upper = true
                ) 
        {
            this.BoundLower = bound_lower;
            this.BoundUpper = bound_upper;
            this.IsBoundLowerIncluded = include_bound_lower;
            this.IsBoundUpperIncluded = include_bound_upper;

            return;
        }

        public Interval() 
            : 
            this (default(T), default(T), true, true)
        {
            return;
        }

        public Interval(T n)
            :
            this(n, n, true, true)
        {
            return;
        }

        static Interval()
        {
            Interval<T>.BoundLowerIncludedChar = '[';
            Interval<T>.BoundLowerExcludedChar = '(';
            Interval<T>.BoundUpperIncludedChar = ']';
            Interval<T>.BoundUpperExcludedChar = ')';

            return;
        }

        public override string ToString()
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            if (this.IsBoundLowerIncluded == true)
            {
                sb.Append('[');   
            }
            else
            {
                sb.Append('(');   
            }
            sb.Append(this.BoundLower).Append(", ").Append(this.BoundUpper);
            if (this.IsBoundUpperIncluded == true)
            {
                sb.Append(']');
            }
            else
            {
                sb.Append(')');
            }

            return sb.ToString();
        }

        /// <summary>
        /// Validate if Interval/Range is valid 
        /// BoundLower (lower bound) is less or equal to BoundUpper(upper bound) 
        /// (minimum is less or equal to maximum)
        /// </summary>
        /// <returns>
        /// <c>true</c> if BoundLower is less or equal to BoundUpper
        /// </returns>
        public bool IsValid()
        {
            return this.BoundLower.CompareTo(this.BoundUpper) <= 0;
        }


        public bool Contains(T element)
        {
            bool lower_lt_element  = this.BoundLower.CompareTo(element) < 0;
            bool lower_lte_element = this.BoundLower.CompareTo(element) <= 0;
            bool upper_lt_element = this.BoundUpper.CompareTo(element) < 0;
            bool upper_lte_element = this.BoundLower.CompareTo(element) <= 0;

            bool contained =
                lower_lt_element && lower_lte_element
                &&
                upper_lt_element && upper_lte_element
                ;
            
            return contained;
        }

        public bool Open
        {
            get
            {
                return OpenLeft && OpenRight;                
            }
        }

        public bool OpenLeft
        {
            get
            {
                bool retval = false;

                return retval;
            }
        }

        public bool OpenRight
        {
            get
            {
                bool retval = false;

                return retval;
            }
        }

        public bool ClosedLeft
        {
            get
            {
                bool retval = false;

                return retval;
            }
        }

        public bool ClosedRight
        {
            get
            {
                bool retval = false;

                return retval;
            }
        }

        public double Centre
        {
            get
            {
                double l = (double) (object) BoundLower;
                double u = (double) (object) BoundUpper;

                return (l + u) / 2.0;
            }
        }

        public bool IsClosed
        {
            get
            {
                return IsBoundLowerIncluded && IsBoundUpperIncluded;   
            }
        }

        public bool IsOpen
        {
            get
            {
                return ! IsClosed;
            }
        }

    }
}
