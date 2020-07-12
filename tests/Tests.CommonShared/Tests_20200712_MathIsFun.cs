// /*
//    Copyright (c) 2017-12
//
//    moljac
//    Test.cs
//
//    Permission is hereby granted, free of charge, to any person
//    obtaining a copy of this software and associated documentation
//    files (the "Software"), to deal in the Software without
//    restriction, including without limitation the rights to use,
//    copy, modify, merge, publish, distribute, sublicense, and/or sell
//    copies of the Software, and to permit persons to whom the
//    Software is furnished to do so, subject to the following
//    conditions:
//
//    The above copyright notice and this permission notice shall be
//    included in all copies or substantial portions of the Software.
//
//    THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
//    EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
//    OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
//    NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
//    HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
//    WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
//    FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
//    OTHER DEALINGS IN THE SOFTWARE.
// */

#if XUNIT
using Xunit;
// NUnit aliases
using Test = Xunit.FactAttribute;
using OneTimeSetUp = HolisticWare.Core.Testing.UnitTests.UnitTestsCompatibilityAliasAttribute;
// XUnit aliases
using TestClass = HolisticWare.Core.Testing.UnitTests.UnitTestsCompatibilityAliasAttribute;
#elif NUNIT
using NUnit.Framework;
// MSTest aliases
using TestInitialize = NUnit.Framework.SetUpAttribute;
using TestProperty = NUnit.Framework.PropertyAttribute;
using TestClass = NUnit.Framework.TestFixtureAttribute;
using TestMethod = NUnit.Framework.TestAttribute;
using TestCleanup = NUnit.Framework.TearDownAttribute;
// XUnit aliases
using Fact = NUnit.Framework.TestAttribute;
#elif MSTEST
using Microsoft.VisualStudio.TestTools.UnitTesting;
// NUnit aliases
using Test = Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute;
using OneTimeSetUp = Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute;
// XUnit aliases
using Fact = Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute;
#endif

#if BENCHMARKDOTNET
using BenchmarkDotNet.Running;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Attributes.Jobs;
#else
using Benchmark = HolisticWare.Core.Testing.BenchmarkTests.Benchmark;
using ShortRunJob = HolisticWare.Core.Testing.BenchmarkTests.ShortRunJob;
#endif

using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;


using Core.Math.Intervals;

namespace UnitTests.Core.Math.Intervals
{
    /// <summary>
    /// 
    /// </summary>
    /// <see cref="https://www.mathsisfun.com/sets/intervals.html"/>
    public partial class Tests_20200712_MathIsFun
    {
        //[Benchmark()]
        //public double Internval_of_int_Constructor_default_01(Span<int> span)
        //{
        //}

        [Test()]
        public void Internval_of_int_Constructor_01_default_01()
        {
            Interval<int> interval = new Interval<int>();

            #if NUNIT
            Assert.AreEqual(interval.BoundLower,    0);
            Assert.AreEqual(interval.BoundUpper,    0);
            Assert.AreEqual(interval.Centre,        0);
            #elif XUNIT
            Assert.Equal(interval.BoundLower,       0);
            Assert.Equal(interval.BoundUpper,       0);
            Assert.Equal(interval.Centre,           0);
            #elif MSTEST
            Assert.AreEqual(interval.BoundLower,    0);
            Assert.AreEqual(interval.BoundUpper,    0);
            Assert.AreEqual(interval.Centre,        0);
            #endif


            return;
        }

        [Test()]
        public void Internval_of_int_Constructor_02_int_01()
        {
            Interval<int> interval = new Interval<int>(2);

            #if NUNIT
            Assert.AreEqual(interval.BoundLower,    2.00);
            Assert.AreEqual(interval.BoundUpper,    2.00);
            //Assert.AreEqual(interval.Centre,        2.00);
            #elif XUNIT
            Assert.Equal(interval.BoundLower,       2.00);
            Assert.Equal(interval.BoundUpper,       2.00);
            //Assert.Equal(interval.Centre,           2.00);
            #elif MSTEST
            Assert.AreEqual(interval.BoundLower,    2.00);
            Assert.AreEqual(interval.BoundUpper,    2.00);
            //Assert.AreEqual(interval.Centre,        2.00);
            #endif

            return;
        }

        [Test()]
        public void Internval_of_int_Constructor_03_string_01()
        {
            Interval<int> interval = new Interval<int>("[1,2]");

            // Assert
            //#if NUNIT
            //Assert.AreEqual(average, 3.00, 0.01);
            //#elif XUNIT
            //Assert.Equal(average, 3.00, 2);
            //#elif MSTEST
            //Assert.AreEqual(average, 3.00, 0.01);
            //#endif

            return;
        }

        [Test()]
        public void Internval_of_int_Constructor_04_bounds_01()
        {
            Interval<int> interval = new Interval<int>(3, 4, true, false);

            // Assert
            //#if NUNIT
            //Assert.AreEqual(average, 3.00, 0.01);
            //#elif XUNIT
            //Assert.Equal(average, 3.00, 2);
            //#elif MSTEST
            //Assert.AreEqual(average, 3.00, 0.01);
            //#endif

            return;
        }
    }
}
