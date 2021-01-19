using System;
using System.Collections.Generic;
using System.Text;
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
            if (base.AnualIncome < 20000.00 && HealthExpenditures >= 0.00)
            {
                value = (AnualIncome * 0.15) - (HealthExpenditures * 0.50 );
            }
            else if (base.AnualIncome > 20000.00 && HealthExpenditures >=0.00)
            {
                value = (AnualIncome * 0.50) - (HealthExpenditures * 0.50);
            }
            return value;
        }
    }
}
