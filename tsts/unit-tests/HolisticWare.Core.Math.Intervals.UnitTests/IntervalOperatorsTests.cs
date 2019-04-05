using System;
using System.Collections.Generic;

//------------------------------------------------------------------------------
// cross framework fixes
#if XUNIT
//https://xunit.github.io/docs/comparisons.html
using Xunit;

// Aliases
// dummy XUnit does need testFixture
using Test              = Xunit.FactAttribute;
using TestFixture       = System.ObsoleteAttribute;  
using TestFixtureSetUp  = System.ObsoleteAttribute;
#endif
#if NUNIT
using NUnit.Framework;
using Fact= NUnit.Framework.TestAttribute;
#endif
//------------------------------------------------------------------------------

using Core.Math.Intervals;

namespace UnitTests.HolisticWare.Core.Math.Intervals
{
    #if XUNIT
    [TestFixture()]
    #endif
    public partial class IntervalOperatorsTests
    {
        Interval<int> interval_ints_01 = null;

        Interval<int> interval_ints_11 = null;
        Interval<int> interval_ints_12 = null;
        Interval<int> interval_ints_13 = null;
        Interval<int> interval_ints_14 = null;

        Interval<int> interval_ints_21 = null;

        Interval<double> interval_doubles_11 = null;
        Interval<double> interval_doubles_12 = null;
        Interval<double> interval_doubles_13 = null;
        Interval<double> interval_doubles_14 = null;

        Interval<DateTime> interval_datetime_11 = null;
        Interval<DateTime> interval_datetime_12 = null;
        Interval<DateTime> interval_datetime_13 = null;
        Interval<DateTime> interval_datetime_14 = null;

        Interval<ushort>    interval_ushort_11 = null;
        Interval<short>     interval_short_11 = null;
        Interval<uint>      interval_uint_11 = null;
        Interval<long>      interval_ulong_11 = null;
        Interval<ulong>     interval_long_11 = null;
        Interval<decimal>   interval_decimal_11 = null;

        /*
        Intentionally excluded with generics constraints
        
        Interval<bool>      interval_bool_11 = null;
        Interval<string>    interval_string_11 = null;

        // Interval<char>   could be practical
        Interval<char>      interval_char_11 = null;
        */
    }
}
