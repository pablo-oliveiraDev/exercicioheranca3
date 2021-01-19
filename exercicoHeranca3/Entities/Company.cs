using exercicoHeranca3.Entities;

namespace exercicoHeranca3.Entities
{
    class Company : TaxPayer
    {
        public int NumberOfEmployees { get; set; }

        public Company()
        {

        }

        public Company(string name, double anualIncome, int numberOfEmployees) : base(name, anualIncome)
        {
            NumberOfEmployees = numberOfEmployees;
        }
        public override double Tax()
        {
            double value = 0.0;
            if (NumberOfEmployees > 10)
            {
                value = AnualIncome * 0.14;
            }
            else
            {
                value = AnualIncome * 0.16;
            }
            return value;
        }
    }
}
