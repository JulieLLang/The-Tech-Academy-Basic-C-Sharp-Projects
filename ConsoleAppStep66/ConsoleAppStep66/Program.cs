using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppStep66
{
    class Program
    {
        static void Main(string[] args)
        {
            //input multiplied by 50
            Console.WriteLine("Enter a Number:");
            string favoriteNumber = Console.ReadLine();
            int favNum = Convert.ToInt32(favoriteNumber);
            int product = favNum * 50;
            Console.WriteLine("Your First number times 50 is: " + product);
            Console.WriteLine("Press Enter for Next Function!");
            Console.ReadLine();

            //input plus 25
            Console.WriteLine("Enter Another Number:");
            string favoriteNumber1 = Console.ReadLine();
            int favNum1 = Convert.ToInt32(favoriteNumber1);
            int total = favNum1 + 25;
            Console.WriteLine("Your Second Number plus 25 is: " + total);
            Console.WriteLine("Press Enter for Next Function!");
            Console.ReadLine();

            //input divided by 12.5
            Console.WriteLine("Enter a Third Number:");
            string favoritenumber2 = Console.ReadLine();
            int favnum2 = Convert.ToInt32(favoritenumber2);
            double quotient = favnum2 / 12.5;
            Console.WriteLine("your number divided by 12.5 is: " + quotient);
            Console.WriteLine("Press Enter for Next Function!");
            Console.ReadLine();

            //input greater than or less than 50
            Console.WriteLine("Enter Fourth Number:");
            string favoritenumber3 = Console.ReadLine();
            int favnum3 = Convert.ToInt32(favoritenumber3);
            bool trueOrFalse = favnum3 > 50;
            Console.WriteLine("if your number is > than 50 it is true, if your number is < 50 it is false.  your number is: " + trueOrFalse.ToString());
            Console.WriteLine("Press Enter for Next Function!");
            Console.ReadLine();

            //input divided by 7 leaves reamainer of...
            Console.WriteLine("Enter a Final Number");
            string favoriteNumber4 = Console.ReadLine();
            int favNum4 = Convert.ToInt32(favoriteNumber4);
            int remainder = favNum4 % 7;
            Console.WriteLine("Your Number Divided by 7 Leaves a Remainder of: " + remainder);
            Console.ReadLine();




            
        }
    }
}
