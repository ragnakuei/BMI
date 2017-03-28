using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BMI
{

    [TestClass]
    public class BmiBoundaryAttributeTest
    {
        [TestMethod]
        public void Get_GenderLower_ShouldBe_20()
        {
            var target = BmiBoundaryAttribute.Get(Gender.Male);

            var actual = target.Lower;
            var expected = 20;

            Assert.AreEqual(actual, expected);
        }
    }
}