namespace exercise_abstract.Entities
{
    public class Company : Payer
    {
        public double NumberOfEmployees { get; set; }

        public Company(string name, double income, double numberOfEmployees) : base(name, income)
        {
            NumberOfEmployees = numberOfEmployees;
        }

        public override double Calculation()
        {
            if (NumberOfEmployees > 10)
            {

                return Income * 14 / 100;
            }
            else
            {
                return Income * 16 / 100;
            }

        }
    }
}