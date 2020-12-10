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
    public class SimpleInterest: IInterestCalculator
    {
        public double amount;
        public float rateOfInteresrt;
        public int years;
        public SimpleInterest(double amount, float rateOfInteresrt, int years)
        {
            this.amount = amount;
            this.rateOfInteresrt = rateOfInteresrt;
            this.years = years;
        }

        public  double Interest()
        {
            double result;
            // Formula used to calculate interest
            result = amount * rateOfInteresrt * years;
            
            return result; 
        }
    }
}
