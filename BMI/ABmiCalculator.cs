namespace BMI
{
public abstract class ABmiCalculator
{
    protected double _upper;
    protected double _lower;

    public double Bmi { get; protected set; }
    public string Result { get; protected set; }

    protected void DoCalc()
    {
        SetBmiBoundary();
        CalcBmi();
        SetBmiResult();
    }

    protected abstract void CalcBmi();
    protected abstract void SetBmiBoundary();
    protected abstract void SetBmiResult();
}
}