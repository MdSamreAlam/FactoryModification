using System;
using System.Collections.Generic;
using CalculateInterestDemo;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Xunit;

namespace CompoundInterestTest
{
    /* 
COPY RIGHT @AUGMENTO LABS 2020
Created By Alam
*/
    [TestClass]
    public class CompoundInterestTest
    {
        [Fact]
        public void CompoundInterestUnit_Test()
        {
            double amount=1000;
            int years = 5; ;
            float interest=0.12f;
            int annualfrequency=1;
            Dictionary<string, double> Valuespair = new Dictionary<string, double>();
            Valuespair.Add("amount", amount);
            Valuespair.Add("years", years);
            Valuespair.Add("rateOfIntrest", interest);
            Valuespair.Add("annualfrequency", annualfrequency);
            double expected = 1500;

            //act

            IInterestCalculator CompoundInterest = FactoryclassforInterest.GetInetrestCalculation(Valuespair, InterestCalculation.CompoundInteresCalculation);
            var actual = CompoundInterest.Interest();
            //Assert
            if (actual == expected)
            {
                Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(actual, expected);
            }
            else
            {
                Microsoft.VisualStudio.TestTools.UnitTesting.Assert.Fail(" No matching value between actual and expected");
            }

        }
    }
}
