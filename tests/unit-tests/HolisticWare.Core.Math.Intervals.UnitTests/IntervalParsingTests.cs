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
    public class IntervalConstructorTests
    {
        Interval<int> i01 = null;

        Interval<int> i11 = null;
        Interval<int> i12 = null;
        Interval<int> i13 = null;
        Interval<int> i14 = null;

        Interval<double> d11 = null;
        Interval<double> d12 = null;
        Interval<double> d13 = null;
        Interval<double> d14 = null;

        [Test()] // NUnit.Framework.TestAttribute
        public void Parsing()
        {
            i01 = new Interval<int>();

            Console.WriteLine($"interval i01 = {i01}");

            i11 = new Interval<int>("(1, 2)");
            i12 = new Interval<int>("(1, 2]");
            i13 = new Interval<int>("[1, 2)");
            i14 = new Interval<int>("[1, 2]");

            Console.WriteLine($"interval i11 = {i11}");
            Console.WriteLine($"interval i12 = {i12}");
            Console.WriteLine($"interval i13 = {i13}");
            Console.WriteLine($"interval i14 = {i14}");

            d11 = new Interval<double>("(1.5, 2.1)");
            d12 = new Interval<double>("(1.5, 2.1]");
            d13 = new Interval<double>("[1.5, 2.1)");
            d14 = new Interval<double>("[1.5, 2.1]");

            Console.WriteLine($"interval d11 = {d11}");
            Console.WriteLine($"interval d12 = {d12}");
            Console.WriteLine($"interval d13 = {d13}");
            Console.WriteLine($"interval d14 = {d14}");


            return;
        }
    }
}
