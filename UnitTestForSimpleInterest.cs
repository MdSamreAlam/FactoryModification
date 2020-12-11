using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Xunit;
using CalculateInterestDemo;
using System.Collections.Generic;

namespace CalculateInterestUnitTest
{
    /* 
COPY RIGHT @AUGMENTO LABS 2020
Created By Alam
*/
    [TestClass]
    public class TestInterestcalculation
    {
        [Fact]
        public void Interest_Calculation_Test()
        {

            //arrange
            double amount=1000;            
            float rateOfInterest=0.05f;           
            int years=3;          
            Dictionary<string, double> Valuespair = new Dictionary<string, double>();
            Valuespair.Add("amount", amount);
            Valuespair.Add("years", years);
            Valuespair.Add("rateOfInterest", rateOfInterest);
            
          double expected =  150.00000223517418;
            
            //act

            IInterestCalculator SimpleInterest =  FactoryclassforInterest.GetInetrestCalculation(Valuespair, InterestCalculation.SimpleInterestCalculation);
            var actual = SimpleInterest.Interest();
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
