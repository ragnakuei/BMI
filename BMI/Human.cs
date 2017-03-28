namespace BMI
{
    public class Human
    {
        public Human(Gender gender, double height, double weight)
        {
            Height = height;
            Weight = weight;
            Gender = gender;
        }

        public Gender Gender { get; set; }
        public double Weight { get; set; }
        public double Height { get; set; }
    }
}