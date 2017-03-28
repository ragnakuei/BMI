using System.ComponentModel;

namespace BMI
{
    enum BmiResult
    {
        [Description("太胖")]
        Fat,

        [Description("適中")]
        Just,

        [Description("太瘦")]
        Thin
    }
}