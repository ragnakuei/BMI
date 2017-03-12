using System;
using System.Collections.Generic;

namespace BMI
{
    public class BmiCalculator
    {
        private static readonly double MaleLower = 20;
        private static readonly double MaleUpper = 25;
        private static readonly double FemaleLower = 18;
        private static readonly double FemaleUpper = 22;
        private static readonly string ResultFat = "太胖";
        private static readonly string ResultJust = "適中";
        private static readonly string ResultThin = "太瘦";

        private readonly Dictionary<Gender, Func<Person, string>> BmiGenderCalc =
            new Dictionary<Gender, Func<Person, string>>();

        public BmiCalculator()
        {
            BmiGenderCalc.Add(Gender.Male, CalcMale);
            BmiGenderCalc.Add(Gender.Female, CalcFemale);
        }

        public string Person(Person person)
        {
            return BmiGenderCalc[person.Gender].Invoke(person);
        }

        private double BmiCalc(double height, double weight)
        {
            return weight / (height * height / 10000);
        }

        private string CalcFemale(Person person)
        {
            var bmi = BmiCalc(person.Height, person.Weight);
            if (bmi > FemaleUpper) return ResultFat;
            return bmi > FemaleLower ? ResultJust : ResultThin;
        }

        private string CalcMale(Person person)
        {
            var bmi = BmiCalc(person.Height, person.Weight);
            if (bmi > MaleUpper) return ResultFat;
            return bmi > MaleLower ? ResultJust : ResultThin;
        }
    }
}