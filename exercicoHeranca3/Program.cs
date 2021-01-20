using System;
using System.Globalization;
using System.Collections.Generic;
using exercicoHeranca3.Entities;


namespace exercicoHeranca3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TaxPayer> taxPayers = new List<TaxPayer>();


            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());



            for (int i = 1; i <= n; i++)
            {
                Console.Write($"Tax payer #{i} data: ");
                Console.Write("Individual or company (i/c)? ");
                char ch = char.Parse(Console.ReadLine().ToLower());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Anual income: ");
                double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (ch == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double healthExpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    taxPayers.Add(new Individual(name, anualIncome, healthExpenditures));
                }
                else 
                {
                    Console.Write("Number of employees: ");
                    int numberOfEmployees = int.Parse(Console.ReadLine());
                    taxPayers.Add(new Company(name, anualIncome, numberOfEmployees));
                }
               

               

            }
            double total = 0.0;
            Console.WriteLine();
            Console.WriteLine("TAXES PAID:");
            foreach (TaxPayer payer in taxPayers)
            {
                Console.WriteLine(payer.Name + " $ " + payer.Tax().ToString("F2", CultureInfo.InvariantCulture));
                 total += payer.Tax();
            }
            Console.WriteLine();
            Console.WriteLine("double total: "+ total.ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}
