using System;
using System.Collections.Generic;
using System.Text;

namespace Aula146ExercicioProposto.Entities
{
    class Individual : TaxPayer
    {
        public double HealthExpenditures { get; set; }

        public Individual(string name, double anualIncome, double healthExpenditures) : base(name, anualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double Tax()
        {
            if (AnualIncome < 20000.0)
            {
                double tax = AnualIncome * 0.15;
                tax -= HealthExpenditures / 2;
                return tax;
            }
            else
            {
                double tax = AnualIncome * 0.25;
                tax -= HealthExpenditures / 2;
                return tax;
            }
        }
    }
}
