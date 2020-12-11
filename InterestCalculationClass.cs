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
    public class InterestCalculationClass: calculateinterest
    {
       
            public float Interest(int P, int T, float R)
            {
                float s;
                // Formula used to calculate interest
                s = P * R * T / 100;
                return s;
            }

            public double CalculateCompoundInterest(double amount, double interest, int years, int annualfrequency)
            {
                double balance;

                // Formulae use to calculate compound interest
                balance = amount * Math.Pow((1 + interest / annualfrequency), years * annualfrequency);
                return balance;


            

        }
    }
}
