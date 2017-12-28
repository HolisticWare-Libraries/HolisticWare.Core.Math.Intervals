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
    public class IntervalParsingTests
    {
        [Test()] // NUnit.Framework.TestAttribute
        public void Constructing()
        {
            List<Interval<int>> intervals_int = new List<Interval<int>>()
            {
                new Interval<int>(-3),
                new Interval<int>(-3,6),
                new Interval<int>(0,3, false, false),
                new Interval<int>(0,3, false, true),
                new Interval<int>(0,3, true, false),
                new Interval<int>(0,3, true, true),
                new Interval<int>(11,11, true, true),
            };

            foreach(Interval<int> i in intervals_int)
            {
                Console.WriteLine($"interval = {i}");
            }

            List<Interval<double>> intervals_double = new List<Interval<double>>()
            {
                new Interval<double>(-10.1,3.3),
                new Interval<double>(-10.1,3.3, false, false),
                new Interval<double>(-10.1,3.3, false, true),
                new Interval<double>(-10.1,3.3, true, false),
                new Interval<double>(-10.1,3.3, true, true),
            };

            foreach (Interval<double> i in intervals_double)
            {
                Console.WriteLine($"interval = {i}");
            }

            return;
        }
    }
}
