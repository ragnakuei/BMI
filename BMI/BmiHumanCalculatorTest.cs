using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BMI
{
    [TestClass]
    public class BmiHumanCalculatorTest
    {
        [TestMethod]
        public void Male_太瘦()
        {
            var person = new Human(Gender.Male, 170, 55);
            var target = new BmiHumanCalculator(person);

            var actual = target.Result;
            var expected = "太瘦";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Male_適中()
        {
            var person = new Human(Gender.Male, 170, 70);
            var target = new BmiHumanCalculator(person);

            var actual = target.Result;
            var expected = "適中";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Male_太胖()
        {
            var person = new Human(Gender.Male, 170, 73);
            var target = new BmiHumanCalculator(person);

            var actual = target.Result;
            var expected = "太胖";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Female_太瘦()
        {
            var person = new Human(Gender.Female, 165, 48);
            var target = new BmiHumanCalculator(person);

            var actual = target.Result;
            var expected = "太瘦";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Female_適中()
        {
            var person = new Human(Gender.Female, 165, 55);
            var target = new BmiHumanCalculator(person);

            var actual = target.Result;
            var expected = "適中";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Female_太胖()
        {
            var person = new Human(Gender.Female, 165, 61);
            var target = new BmiHumanCalculator(person);

            var actual = target.Result;
            var expected = "太胖";

            Assert.AreEqual(expected, actual);
        }
    }
}