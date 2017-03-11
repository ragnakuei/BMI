using System;
using System.Collections.Generic;

namespace BMI
{
    public static class BmiCalculator
    {
        private static readonly double MaleLower = 20;
        private static readonly double MaleUpper = 25;
        private static readonly double FemaleLower = 18;
        private static readonly double FemaleUpper = 22;

        private static readonly Dictionary<int, string> BmiResult =
            new Dictionary<int, string>();

        private static readonly Dictionary<Gender, Func<Person, string>> BmiGenderCalc =
            new Dictionary<Gender, Func<Person, string>>();

        static BmiCalculator()
        {
            BmiGenderCalc.Add(Gender.Male, BmiCalcMale);
            BmiGenderCalc.Add(Gender.Female, BmiCalcFemale);

            BmiResult.Add(1, "太胖");
            BmiResult.Add(0, "太瘦");
            BmiResult.Add(-1, "太瘦");
        }

        public static string BMI(this Person person)
        {
            return BmiGenderCalc[person.Gender].Invoke(person);
        }

        private static double BmiCalc(double height, double weight)
        {
            return weight / (height * height / 10000);
        }

        private static string BmiCalcFemale(Person person)
        {
            var bmi = BmiCalc(person.Height, person.Weight);
            if (bmi > FemaleUpper) return BmiResult[1];
            if (bmi > FemaleLower) return BmiResult[0];
            return BmiResult[-1];
        }

        private static string BmiCalcMale(Person person)
        {
            var bmi = BmiCalc(person.Height, person.Weight);
            if (bmi > MaleUpper) return BmiResult[1];
            if (bmi > MaleLower) return BmiResult[0];
            return BmiResult[-1];
        }
    }
}