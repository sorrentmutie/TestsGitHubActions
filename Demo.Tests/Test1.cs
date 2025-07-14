using DemoConsole;

namespace Demo.Tests
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var c = new Calculator();
            var a = 5;
            var b = 4;
            var expected = 9;
            var calculated = c.Sum(a, b);
            Assert.AreEqual(expected, calculated, "Sum of {0} and {1} should be {2}", a, b, expected);
        }
    }
}
