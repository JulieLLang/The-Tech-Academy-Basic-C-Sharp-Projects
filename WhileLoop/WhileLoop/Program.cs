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
            bool isGuessed = number == 47;

            while (!isGuessed)
            {
                switch (number)
                {
                    case 100:
                        Console.WriteLine("You guessed 100.  You are wrong!");
                        Console.WriteLine("Guess a number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 67:
                        Console.WriteLine("You guessed 67. Try again!");
                        Console.WriteLine("Guess a number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 47:
                        Console.WriteLine("Yeah! You know my favorite number!");
                        isGuessed = true;
                        break;
                    default:
                        Console.WriteLine("You are bad at this guessing thing!");
                        Console.WriteLine("Guess a number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
            
            Console.ReadLine();
        }
    }
}
