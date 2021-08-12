using Convenience.Extensions;
using NUnit.Framework;
using System;

namespace ConvencienceLibTests {
    public class MathTests {
        [TestCase(100, 0, 200)]
        [TestCase(123, 0, 300)]
        [TestCase(33, 23, 44)]
        [TestCase(101230, 11323, 3333444)]
        [TestCase(-22, -55, -5)]
        [TestCase(-22.3, -55.2, -5.12)]
        [TestCase(0.0001, 0.00001, 0.00011)]
        public void Test_Clamp_IsValue(IComparable value, IComparable min, IComparable max) {
            Assert.AreEqual(value, Convenience.Math.Clamp(value, min, max));
            Assert.AreEqual(value, value.Clamp(min, max));
        }

        [TestCase(100, 101, 200)]
        [TestCase(12, 44, 300)]
        [TestCase(3, 23, 44)]
        [TestCase(101230, 1132300, 3333444)]
        [TestCase(-222, -5, 3344)]
        [TestCase(-55.3, -22.2, -5.12)]
        [TestCase(0.0001, 0.001, 0.0011)]
        public void Test_Clamp_IsMin(IComparable value, IComparable min, IComparable max) {
            Assert.AreEqual(min, Convenience.Math.Clamp(value, min, max));
            Assert.AreEqual(min, value.Clamp(min, max));
        }

        [TestCase(1000, 2, 200)]
        [TestCase(312, 44, 300)]
        [TestCase(55, -1, 44)]
        [TestCase(401230, 113230, 333444)]
        [TestCase(2, -5, -1)]
        [TestCase(-2, -50, -10)]
        [TestCase(-22.3, -55.2, -25.12)]
        [TestCase(0.0001, 0.00001, 0.00009)]
        public void Test_Clamp_IsMax(IComparable value, IComparable min, IComparable max) {
            Assert.AreEqual(max, Convenience.Math.Clamp(value, min, max));
            Assert.AreEqual(max, value.Clamp(min, max));
        }
    }
}