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
    public class SimpleInterest: IInterestCalculator
    {
        public double amount;
        public float rateOfInterest;
        public int years;
        public SimpleInterest(Dictionary<string, double> SiDictionary)
        {
            this.amount = SiDictionary["amount"];
            this.rateOfInterest = (float)( SiDictionary ["rateOfInterest"]);
            this.years = Convert.ToInt32( SiDictionary["years"]);
        }

        public  double Interest()
        {
            double result;
            // Formula used to calculate interest
            result = amount * rateOfInterest * years;
            
            return result; 
        }
    }
}
