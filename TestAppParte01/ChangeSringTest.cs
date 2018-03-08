using AppParte01;
using NUnit.Framework;

namespace TestAppParte01
{
    [TestFixture]
    public class ChangeSringTest
    {
        private ChangeString _changeString;

        [SetUp()]
        public void Init()
        {
            _changeString = new ChangeString();
        }

        [TestCase("az12dZ56*op", "ba12eA56*pq")]
        [TestCase("zZ98*/aeZz", "aA98*/bfAa")]
        public void TestBuildAreEqual(string entrada, string expected)
        {
            var salida = _changeString.build(entrada);
            Assert.AreEqual(expected, salida);
        }

        [TestCase("az12dZ56*op", "ba23eA67*pq")]
        [TestCase("az12dZ56*op", "az12dZ56*op")]
        public void TestBuildAreNotEqual(string entrada, string expected)
        {
            var salida = _changeString.build(entrada);
            Assert.AreNotEqual(expected, salida);
        }
    }
}