using System;

namespace BMI
{
    public abstract class ABmiCalculator
    {
        protected double _upper;
        protected double _lower;
        protected Enum _type;

        public double Bmi { get; protected set; }
        public string Result { get; protected set; }

        protected void DoCalc()
        {
            SetBmiBoundary();
            CalcBmi();
            SetBmiResult();
        }

        protected void SetBmiBoundary()
        {
            var bmiBoundary = BmiBoundaryAttribute.Get(this._type);
            this._upper = bmiBoundary.Upper;
            this._lower = bmiBoundary.Lower;
        }

        protected void SetBmiResult()
        {
            Result = (Bmi > this._upper)
                ? MyExtensions.GetEnumDescription(BmiResult.Fat)
                : (Bmi > this._lower)
                    ? MyExtensions.GetEnumDescription(BmiResult.Just)
                    : MyExtensions.GetEnumDescription(BmiResult.Thin);
        }

        protected abstract void CalcBmi();
    }
}