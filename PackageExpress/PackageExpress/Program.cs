using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackageExpress
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("Enter the weight of your package:");
            decimal packageWeight = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Your package weighs: " + " "  + packageWeight + " " + "lbs");

            //// if else if 
            string result = packageWeight <= 50 ? "" : "";
            if (packageWeight >=50)
            {
                Console.WriteLine("Your package too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
                Environment.Exit(0);
            }

            Console.WriteLine(result);
           
            //Box Area: A (area) = W (width) x H (height) x L(length) / 100
            Console.Write("Please enter the width of your package: ");
            decimal widthSide = decimal.Parse(Console.ReadLine());
            Console.Write("Please enter the height of your package: ");
            decimal heightSide = decimal.Parse(Console.ReadLine());
            Console.Write("Please enter the length of your package: ");
            decimal lengthSide = decimal.Parse(Console.ReadLine());
            Console.Write("Your package is:" + " " + widthSide + "W x " + heightSide + "H x " + lengthSide + "L");
            //Console.ReadLine();
            decimal area = (lengthSide * heightSide * lengthSide) / 100;
            //Console.WriteLine("The sum total of your dimensions is: {0}", area);

            // if else if
            string result2 = area < 50 ? "" : "";
            if (area >= 50)
            {
                Console.WriteLine(", Your package too big to be shipped via Package Express.");
                Console.ReadLine();
                Environment.Exit(0);
            }

            Console.WriteLine(result2);

            //The sum total of dimensions are then multiplied by the weight and divided by 100
            decimal value = 0.00M;
            value = Convert.ToDecimal((area * packageWeight) / 100);
            Console.WriteLine("The shipping quote for your package is: " + value.ToString("C"));
            Console.WriteLine("Thank you for your business.");
            Console.ReadLine();

        }
    }
}