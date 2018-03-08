using AppParte01;
using NUnit.Framework;

namespace TestAppParte01
{
    [TestFixture]
    public class MoneyPartsTest
    {
        private MoneyParts _moneyParts;

        [SetUp()]
        public void Init()
        {
            _moneyParts = new MoneyParts();
        }

        [TestCase(0.1, "[0.05, 0.05]  [0.1]")]
        [TestCase(0.5, "[0.05, 0.05, 0.05, 0.05, 0.05, 0.05, 0.05, 0.05, 0.05, 0.05]  [0.1, 0.1, 0.1, 0.1, 0.1]  [0.5]")]
        public void TestBuildAreEqual(decimal entrada, string expected)
        {
            var salida = _moneyParts.build(entrada);
            Assert.AreEqual(expected, salida);
        }

        [TestCase(0.1, "[0.05, 0.05]")]
        [TestCase(0.5, "[0.5]")]
        public void TestBuildAreNotEqual(decimal entrada, string expected)
        {
            var salida = _moneyParts.build(entrada);
            Assert.AreNotEqual(expected, salida);
        }
    }
}