namespace exercise_abstract.Entities
{
    public class Individual : Payer
    {
        public double HealthExpenditures { get; set; }

        public Individual(string name, double income, double healthExpenditures) : base(name, income)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double Calculation()
        {
            if (Income < 20000 && HealthExpenditures == 0)
            {
                return Income * 15 / 100;
            }
            else if (Income < 20000 && HealthExpenditures > 0)
            {
                return Income * 15 / 100 - (HealthExpenditures * 50 / 100);
            }
            else if (Income > 20000 && HealthExpenditures > 0)
            {
                return Income * 25 / 100 - (HealthExpenditures * 50 / 100);
            }
            else
            {
                return Income * 25 / 100;
            }
        }
    }
}