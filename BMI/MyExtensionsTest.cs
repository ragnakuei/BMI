using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BMI
{
    [TestClass]
    public class MyExtensionsTest
    {
        [TestMethod]
        public void GetDescription_ShouldBe_太胖()
        {
            var actual = MyExtensions.GetEnumDescription(BmiResult.Fat);

            var expected = "太胖";

            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void GetDescription_ShouldBe_Exception()
        {
            var actual = MyExtensions.GetEnumDescription(Test.item1);

            string expected = null;

            Assert.AreEqual(expected, actual);
        }
    }

    enum Test
    {
        item1
    }
}