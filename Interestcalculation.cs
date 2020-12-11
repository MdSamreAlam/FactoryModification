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
    class Interestcalculation
    {
       
        static void Main(string[] args)
        {
            Console.WriteLine("Choose which Intrest to Calculate");
            Console.WriteLine("i)SimpleIntrest-->1");
            Console.WriteLine("ii)CompoundIntrest-->2");

            // Concretefactory CalculateSi = new Concretefactory();
            //FactoryclassforInterest factoryclassforInterest = new FactoryclassforInterest();

            var selection = int.Parse(Console.ReadLine());
            if (selection == 1)
            {
                int years;
                float rateOfInterest;
                double amount;

                Console.WriteLine("Enter principal Amount:");
                amount = double.Parse(Console.ReadLine());

                Console.Write("Enter the rate of interest : ");
                rateOfInterest = float.Parse(Console.ReadLine()) / 100;

                Console.Write("Enter the total number of years : ");
                years = int.Parse(Console.ReadLine());
                Dictionary<string, double> Valuespair = new Dictionary<string, double>();
                Valuespair.Add("amount", amount);
                Valuespair.Add("years", years);
                Valuespair.Add("rateOfInterest", rateOfInterest);
                IInterestCalculator SimpleIntrest = FactoryclassforInterest.GetInetrestCalculation(Valuespair, InterestCalculation.SimpleInterestCalculation);
                var Result = SimpleIntrest.Interest();
                Console.Write("Simple Intrest is " + Result);
            }
            else if (selection == 2)
             {
                double amount; 
                float interest;
                int years;
                int annualfrequency;
                Console.WriteLine("Enter principal Amount:");
                amount = double.Parse(Console.ReadLine());

                Console.Write("Enter the rate of interest : ");
                interest = float.Parse(Console.ReadLine()) / 100;

                Console.Write("Enter the total number of years : ");
                years = int.Parse(Console.ReadLine());

                Console.Write("Compounding frequency quarterly or monthly : ");
                annualfrequency = int.Parse(Console.ReadLine());
                Dictionary<string, double> Valuespair = new Dictionary<string, double>();
                Valuespair.Add("amount", amount);
                Valuespair.Add("years", years);
                Valuespair.Add("rateOfIntrest", interest);
                Valuespair.Add("annualfrequency",annualfrequency);
                IInterestCalculator CalculateCi = FactoryclassforInterest.GetInetrestCalculation(Valuespair,InterestCalculation.CompoundInteresCalculation);
                var Result = CalculateCi.Interest();
                Console.Write("After " + years + " years there will be a " + Result + " in the Account");

            }
            
            Console.ReadKey();


        }
    }
    //public  class FactoryClass
    //{
    //    public  IInterestCalculator GetSiCi(int Id)
    //    {
    //        switch (Id)
    //        {
    //            case 0:
    //                return new SimpleInterest();
    //            case 1:
    //                return new CompoundInterest();

    //            default:
    //                return null;
    //        }
    //    }
    //}


}
