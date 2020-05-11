using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject3
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var calc = new ClassLibrary1.Class1();
            var result = calc.GetInt("42");
            Assert.AreEqual(42, result);
        }
    }
}
