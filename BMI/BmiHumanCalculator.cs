namespace BMI
{

    public sealed class BmiHumanCalculator : ABmiCalculator
    {
        private readonly Human _person;

        public BmiHumanCalculator(Human person)
        {
            this._person = person;
            this._type = person.Gender;
            DoCalc();
        }

        protected override void CalcBmi()
        {
            Bmi = this._person.Weight / (this._person.Height * this._person.Height / 10000);
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