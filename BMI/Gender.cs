namespace BMI
{
    public enum Gender
    {
        [BmiBoundary(20, 25)]
        Male,

        [BmiBoundary(18, 22)]
        Female
    }
}