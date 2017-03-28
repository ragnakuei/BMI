using System;
using System.ComponentModel;
using System.Reflection;

namespace BMI
{
    public static class MyExtensions
    {
        internal static string GetEnumDescription(Enum input)
        {
            FieldInfo data = input.GetType().GetField(input.ToString());
            DescriptionAttribute attribute = (DescriptionAttribute)Attribute.GetCustomAttribute(data, typeof(DescriptionAttribute));
            return attribute?.Description;
        }
    }
}