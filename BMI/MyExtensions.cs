using System;
using System.ComponentModel;
using System.Reflection;

namespace BMI
{
    public static class MyExtensions
    {
        internal static string GetEnumDescription(dynamic input)
        {
            if (!input.GetType().IsEnum)
            {
                throw new ArgumentException("Input type must be an enumerated type");
            }

            FieldInfo data = input.GetType().GetField(input.ToString());
            DescriptionAttribute attribute = (DescriptionAttribute)Attribute.GetCustomAttribute(data, typeof(DescriptionAttribute));
            return attribute.Description;
        }
    }
}