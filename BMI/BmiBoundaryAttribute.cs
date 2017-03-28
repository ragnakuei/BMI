using System;
using System.Reflection;

namespace BMI
{
    internal class BmiBoundaryAttribute : Attribute
    {
        public double Lower { get; private set; }
        public double Upper { get; private set; }

        public BmiBoundaryAttribute(double lower, double upper)
        {
            Upper = upper;
            Lower = lower;
        }

        public static BmiBoundaryAttribute Get(Gender value)
        {
            FieldInfo fi = value.GetType().GetField(value.ToString());

            return (BmiBoundaryAttribute)fi.GetCustomAttribute(typeof(BmiBoundaryAttribute), false);
        }
    }
}