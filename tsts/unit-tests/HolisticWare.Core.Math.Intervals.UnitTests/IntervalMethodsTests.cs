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

using Core;
using Core.Math.Intervals;

namespace UnitTests.HolisticWare.Core.Math.Intervals
{
    #if XUNIT
    [TestFixture()]
    #endif
    public class IntervalMethodsTests
    {
        Interval<short>     interval_shorts_01 = null;
        Interval<int>       interval_ints_01 = null;
        Interval<long>      interval_longs_01 = null;
        Interval<double>    interval_doubles_01 = null;
        Interval<float>     interval_floats_01 = null;
        Interval<decimal>   interval_decimals_01 = null;
        Interval<DateTime>  interval_datetimes_01 = null;

        [Test()] // NUnit.Framework.TestAttribute
        public void ToList()
        {
            interval_shorts_01  = new Interval<short>("(1, 21)");
            interval_ints_01    = new Interval<int>("(1, 21)");
            interval_longs_01   = new Interval<long>("(1, 21)");

            List<short> shorts = interval_shorts_01.ToList();

            return;
        }
    }
}
