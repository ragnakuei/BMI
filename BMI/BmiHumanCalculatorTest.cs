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
            var expected = MyExtensions.GetEnumDescription(BmiResult.Thin);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Male_剛好()
        {
            var person = new Human(Gender.Male, 170, 70);
            var target = new BmiHumanCalculator(person);

            var actual = target.Result;
            var expected = MyExtensions.GetEnumDescription(BmiResult.Just);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Male_太胖()
        {
            var person = new Human(Gender.Male, 170, 73);
            var target = new BmiHumanCalculator(person);

            var actual = target.Result;
            var expected = MyExtensions.GetEnumDescription(BmiResult.Fat);

            Assert.AreEqual(expected, actual);
        }



        [TestMethod]
        public void Female_太瘦()
        {
            var person = new Human(Gender.Female, 165, 48);
            var target = new BmiHumanCalculator(person);

            var actual = target.Result;
            var expected = MyExtensions.GetEnumDescription(BmiResult.Thin);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Female_剛好()
        {
            var person = new Human(Gender.Female, 165, 55);
            var target = new BmiHumanCalculator(person);

            var actual = target.Result;
            var expected = MyExtensions.GetEnumDescription(BmiResult.Just);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Female_太胖()
        {
            var person = new Human(Gender.Female, 165, 61);
            var target = new BmiHumanCalculator(person);

            var actual = target.Result;
            var expected = MyExtensions.GetEnumDescription(BmiResult.Fat);

            Assert.AreEqual(expected, actual);
        }
    }
}