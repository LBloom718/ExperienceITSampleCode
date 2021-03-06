﻿namespace Abstraction_PayDay
{
    public class PaycheckCalculator : ICalculate
    {
        public string CalculateHourly()
        {
            //This would take the hours worked and mulitply by the pay rate
            return "$500.50";
        }

        public string CalculateSalary()
        {
            //This would take the annual salary and divide by the number of pay periods in a year 
            return "$700.00";
        }

        public string CalculateCommision()
        {
            var hourlyWage = CalculateHourly();

            //This would do something like take the hourly wages earned and calculate the Commission earned
            //and return the sum of those two together.
            return "$203.00";
        }
    }
}