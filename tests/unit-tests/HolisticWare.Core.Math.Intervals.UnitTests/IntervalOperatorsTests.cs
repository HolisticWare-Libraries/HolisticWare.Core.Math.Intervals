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
        Interval<int> i01 = null;

        Interval<int> i11 = null;
        Interval<int> i12 = null;
        Interval<int> i13 = null;
        Interval<int> i14 = null;

        Interval<int> i21 = null;

        Interval<double> d11 = null;
        Interval<double> d12 = null;
        Interval<double> d13 = null;
        Interval<double> d14 = null;

    }
}
