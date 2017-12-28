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
        [Test()] // NUnit.Framework.TestAttribute
        public void Addition_Sum_Union()
        {
            i11 = new Interval<int>("(1, 2)");
            i12 = new Interval<int>("[2, 3)");

            i21 = i11 + i12;

            i11 = new Interval<int>("(1, 2]");
            i12 = new Interval<int>("[2, 3]");

            i21 = i11 + i12;

            return;
        }
    }
}
