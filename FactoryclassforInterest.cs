using CalculateInterestDemo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateInterestDemo
{
  public  class FactoryclassforInterest

    {
        /* 
COPY RIGHT @AUGMENTO LABS 2020
Created By Alam
*/
        public static IInterestCalculator GetInetrestCalculation(Dictionary<string, double> value, InterestCalculation Select)
        {
            switch (Select)
            {
                case InterestCalculation.SimpleInterestCalculation:
                    return new   SimpleInterest(value);
                case InterestCalculation.CompoundInteresCalculation:
                    return new CompoundInterest(value);
                default:
                    throw new ApplicationException(string.Format(" Object Intrest cannot be created"));
            }

        }
    }
}

