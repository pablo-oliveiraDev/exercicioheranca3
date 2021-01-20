using System.Globalization;
using exercicoHeranca3.Entities;

namespace exercicoHeranca3.Entities
{
    class Individual : TaxPayer
    {
        public double HealthExpenditures { get; set; }

        public Individual()
        {

        }

        public Individual(string name, double anualIncome, double healthExpenditures) : base(name, anualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double Tax()
        {
            double value = 0.0;
            if (base.AnualIncome < 20000.00 )
            {
                value = (AnualIncome * 0.15) - (HealthExpenditures * 0.50 );
            }
            else 
            {
                value = (AnualIncome * 0.25) - (HealthExpenditures * 0.50);
            }
            return value;
        }
    }
}
