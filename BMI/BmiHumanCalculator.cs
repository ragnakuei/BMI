namespace BMI
{

    public sealed class BmiHumanCalculator : ABmiCalculator
    {
        private readonly Human _person;

        public BmiHumanCalculator(Human person)
        {
            this._person = person;
            DoCalc();
        }

        protected override void CalcBmi()
        {
            Bmi = this._person.Weight / (this._person.Height * this._person.Height / 10000);
        }

        protected override void SetBmiBoundary()
        {
            var bmiBoundary = BmiBoundaryAttribute.Get(this._person.Gender);
            this._upper = bmiBoundary.Upper;
            this._lower = bmiBoundary.Lower;
        }

        protected override void SetBmiResult()
        {
            Result = (Bmi > this._upper)
                ? MyExtensions.GetEnumDescription(BmiResult.Fat)
                : (Bmi > this._lower)
                    ? MyExtensions.GetEnumDescription(BmiResult.Just)
                    : MyExtensions.GetEnumDescription(BmiResult.Thin);
        }
    }
}