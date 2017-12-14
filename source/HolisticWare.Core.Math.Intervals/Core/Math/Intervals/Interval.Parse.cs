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
        public static Interval<T> Parse(string interval_notation)
        {
            Interval<T> retval = default(Interval<T>);

            string interval_notation_for_parsing;
            interval_notation_for_parsing = interval_notation.TrimStart().TrimEnd();

            int idx_lower_e = -1;
            int idx_lower_i = -1;

            idx_lower_e = interval_notation_for_parsing.IndexOf(Interval<T>.BoundLowerExcludedChar);
            idx_lower_i = interval_notation_for_parsing.IndexOf(Interval<T>.BoundLowerIncludedChar);

            if (idx_lower_e != -1 && idx_lower_i == -1)
            {
                retval.IsBoundLowerIncluded = false;
                interval_notation_for_parsing = interval_notation_for_parsing.Remove(idx_lower_e, 1);
            }

            if (idx_lower_e == -1 && idx_lower_i != -1)
            {
                retval.IsBoundLowerIncluded = true;
                interval_notation_for_parsing = interval_notation_for_parsing.Remove(idx_lower_i, 1);
            }

            int idx_upper_e = -1;
            int idx_upper_i = -1;

            idx_upper_e = interval_notation_for_parsing.IndexOf(Interval<T>.BoundUpperExcludedChar);
            idx_upper_i = interval_notation_for_parsing.IndexOf(Interval<T>.BoundUpperIncludedChar);

            if (idx_upper_e != -1 && idx_upper_i == -1)
            {
                retval.IsBoundUpperIncluded = false;
                interval_notation_for_parsing = interval_notation_for_parsing.Remove(idx_upper_e, 1);
            }

            if (idx_upper_e == -1 && idx_upper_i != -1)
            {
                retval.IsBoundUpperIncluded = true;
                interval_notation_for_parsing = interval_notation_for_parsing.Remove(idx_upper_i, 1);
            }

            string[] interval = interval_notation_for_parsing.Split(new char[]{','});
            if (interval.Length > 2)
            {
                throw new InvalidOperationException("Interval parsing error");
            }

            try
            {
                retval.BoundLower = (T)Convert.ChangeType(interval[0], typeof(T));
            }
            catch(Exception exc)
            {
                System.Text.StringBuilder sb = new System.Text.StringBuilder();
                sb.AppendLine($"Interval<T>.Parse(string).BoundLower Error: ");
                sb.AppendLine($"    Data = {interval[1]}");

                throw new InvalidOperationException(sb.ToString(), exc);
            }
            try
            {
                retval.BoundUpper = (T)Convert.ChangeType(interval[1], typeof(T));
            }
            catch (Exception exc)
            {
                System.Text.StringBuilder sb = new System.Text.StringBuilder();
                sb.AppendLine($"Interval<T>.Parse(string).BoundUpper Error: ");
                sb.AppendLine($"    Data = {interval[1]}");

                throw new InvalidOperationException(sb.ToString(), exc);
            }

            return retval;    

        }
    }
}
