namespace exercise_abstract.Entities
{
    abstract public class Payer
    {
        public string Name { get; set; }
        public double Income { get; set; }

        public Payer(string name, double income)
        {
            Name = name;
            Income = income;
        }

        public abstract double Calculation();



    }
}