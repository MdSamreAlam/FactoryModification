using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculateInterestDemo;


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
        
        public CompoundInterest(Dictionary<string, double> CiDictionary)
        {
            this.amount = ( CiDictionary["amount"]);
            this.years = Convert.ToInt32( CiDictionary["years"]);
            this.interest = (float)(CiDictionary["rateOfIntrest"]);
            this.annualfrequency = Convert.ToInt32( CiDictionary["annualfrequency"]);
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
