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
    }
}