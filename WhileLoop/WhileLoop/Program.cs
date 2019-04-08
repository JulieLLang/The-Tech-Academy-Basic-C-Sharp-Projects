using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess my favorite number?");
            int number = Convert.ToInt32(Console.ReadLine());

            switch (number)
            {
                case 100:
                    Console.WriteLine("You guessed 100.  You are wrong!");
                    break;
                case 67:
                    Console.WriteLine("You guessed 67. Try again!");
                    break;
                case 47:
                    Console.WriteLine("Yeah! You know my favorite number!");
                    break;
                default:
                    Console.WriteLine("You are bad at this guessing thing!");
                    break;
            }
            Console.ReadLine();
        }
    }
}
