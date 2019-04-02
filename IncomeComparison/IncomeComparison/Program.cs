using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine(" ");

            //input hourly rate Person 1
            Console.WriteLine("Input hourly Rate Person 1");
            decimal person1Rate = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Hourly Rate" + " " + person1Rate);

            // input hours worked per week Person 1
            Console.WriteLine("Input Hours Worked Per Week by Person 1");
            decimal person1Hours = Convert.ToDecimal(Console.ReadLine());
            decimal product = person1Hours * person1Rate;
            Console.WriteLine("Weekly Wage of Person 1 = " + " " + product);

            Console.WriteLine(" ");

            //input hourly rate Person 2
            Console.WriteLine("Input hourly Rate Person 2");
            decimal person2Rate = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Hourly Rate" + " " + person2Rate);

            Console.WriteLine(" ");

            // input hours worked per week Person 2
            Console.WriteLine("Input Hours Worked Per Week by Person 2");
            decimal person2Hours = Convert.ToDecimal(Console.ReadLine());
            decimal product2 = person2Hours * person2Rate;
            Console.WriteLine("Weekly Wage of Person 2 = " + " " + product2);

            Console.WriteLine(" ");

            //bool trueOrFalse = does person 1 make more than person 2
            Console.WriteLine("Does Person 1 make more than Person 2? True or False:");
            bool trueOrFalse = person1Hours * person1Rate > person2Hours * person2Rate;
            Console.WriteLine(trueOrFalse.ToString());

            Console.ReadLine();

        }
    }
}
