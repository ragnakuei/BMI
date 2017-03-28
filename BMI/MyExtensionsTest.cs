using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace BMI
{
    [TestClass]
    public class MyExtensionsTest
    {
        [TestMethod]
        public void GetDescription_ShouldBe_太瘦()
        {
            var actual = MyExtensions.GetEnumDescription(BmiResult.Fat);

            var expected = "太胖";

            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void GetDescription_ShouldBe_Exception()
        {
            var actual = MyExtensions.GetEnumDescription(this);

        }

        [TestMethod]
        public void GetDescription_ShouldBe_Exception_Message()
        {
            try
            {
                var actual = MyExtensions.GetEnumDescription(this);
                Assert.Fail();
            }
            catch (Exception ex)
            {
                var actual = ex.Message;
                var expected = "Input type must be an enumerated type";
                Assert.AreEqual(actual, expected);
            }
        }
    }
}