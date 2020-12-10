using CalculateInterestDemo.Interfaceclass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateInterestDemo
{
  public  class FactoryclassforInterest
    {
        public static IInterestCalculator getInetrestCalculation(double amount, float rateOfInteresrt, int years, int annualfrequency = 0)
        {
            if (annualfrequency == 0)
            {
                return new SimpleInterest(amount,rateOfInteresrt,years);
            }
            else
            {
                return new CompoundInterest(amount, rateOfInteresrt, years, annualfrequency);
            }
            
        }
    }
}

