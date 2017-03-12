using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BMI
{
    [TestClass]
    public class BMITest
    {
        [TestMethod]
        public void Male_太瘦()
        {
            var target = new BmiCalculator();
            var person = new Person(Gender.Male, 170, 55);
            var actual = target.Person(person);

            var expected = "太瘦";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Male_剛好()
        {
            var target = new BmiCalculator();
            var person = new Person(Gender.Male, 170, 70);
            var actual = target.Person(person);

            var expected = "適中";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Male_太胖()
        {
            var target = new BmiCalculator();
            var person = new Person(Gender.Male, 170, 73);
            var actual = target.Person(person);

            var expected = "太胖";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Female_太瘦()
        {
            var target = new BmiCalculator();
            var person = new Person(Gender.Female, 165, 48);
            var actual = target.Person(person);

            var expected = "太瘦";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Female_剛好()
        {
            var target = new BmiCalculator();
            var person = new Person(Gender.Female, 165, 55);
            var actual = target.Person(person);

            var expected = "適中";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Female_太胖()
        {
            var target = new BmiCalculator();
            var person = new Person(Gender.Female, 165, 61);
            var actual = target.Person(person);

            var expected = "太胖";

            Assert.AreEqual(expected, actual);
        }
    }
}