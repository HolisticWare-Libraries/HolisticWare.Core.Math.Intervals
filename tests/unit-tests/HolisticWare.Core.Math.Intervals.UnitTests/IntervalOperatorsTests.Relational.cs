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
        public void Equality()
        {
            bool? equal = null;

            equal = (new Interval<int>("(1,2]") == new Interval<int>("(1,2]"));

            Assert.Equals(equal, true);

            return;
        }

        [Test()] // NUnit.Framework.TestAttribute
        public void LessThan()
        {
            i01 = new Interval<int>();

            Console.WriteLine($"interval i01 = {i01}");

            i11 = new Interval<int>("(1, 2)");
            i12 = new Interval<int>("[2, 3)");

            i21 = i11 + i12;

            i11 = new Interval<int>("(1, 2]");
            i12 = new Interval<int>("[2, 3]");

            i21 = i11 + i12;

            return;
        }

        [Test()] // NUnit.Framework.TestAttribute
        public void GreaterThan()
        {
            return;
        }
    }
}
