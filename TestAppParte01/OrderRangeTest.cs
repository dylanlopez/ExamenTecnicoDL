using AppParte01;
using NUnit.Framework;
using System.Collections.Generic;

namespace TestAppParte01
{
    [TestFixture]
    public class OrderRangeTest
    {
        private OrderRange _orderRange;

        [SetUp()]
        public void Init()
        {
            _orderRange = new OrderRange();
        }

        [TestCase(new int[] { 1, 2, 3, 4 }, "[2, 4]  [1, 3]")]
        [TestCase(new int[] { 10, 1, 3, 5, 20, 7, 9 }, "[10, 20]  [1, 3, 5, 7, 9]")]
        public void TestBuildAreEqual(int[] entrada, string expected)
        {
            var salida = _orderRange.build(new List<int>(entrada));
            Assert.AreEqual(expected, salida);
        }

        [TestCase(new int[] { 1, 2, 3, 4 }, "[1, 2]  [3, 4]")]
        [TestCase(new int[] { 10, 1, 3, 5, 20, 7, 9 }, "[10, 1, 3, 5, 20]  [7, 9]")]
        public void TestBuildAreNotEqual(int[] entrada, string expected)
        {
            var salida = _orderRange.build(new List<int>(entrada));
            Assert.AreNotEqual(expected, salida);
        }
    }
}