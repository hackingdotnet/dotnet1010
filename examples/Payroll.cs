// Copyright hackingdotnet All Rights Reserved 

using System;


namespace Payroll
{
    
    class Payroll
    {
        static void Main(string[] args)
        {

            int hours = 40;
            double grossPay;
            double payRate = 35.0;

            grossPay = hours * payRate;

            Console.WriteLine("Welcome to the Payroll App!");
            Console.WriteLine("Your gross apy is $ {0}", grossPay);
        }
    }
}