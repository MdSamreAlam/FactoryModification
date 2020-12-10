using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculateInterestDemo.Interfaceclass;

namespace CalculateInterestDemo
{
    /* 
COPY RIGHT @AUGMENTO LABS 2020
Created By Alam
*/
    public class CompoundInterest: IInterestCalculator
    {
        double amount;
        int years;
        float interest;
        int annualfrequency;
        public CompoundInterest(double amount,  float interest, int years, int annualfrequency)
        {
            this.amount = amount;
            this.years = years;
            this.interest = interest;
            this.annualfrequency = annualfrequency;
        }

        public double Interest()
        {
            double balance;

            // Formulae use to calculate compound interest
            balance = amount * Math.Pow((1 + interest / annualfrequency), years * annualfrequency);
            return balance;

        }
    }
}
