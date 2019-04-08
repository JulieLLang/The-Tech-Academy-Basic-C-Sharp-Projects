using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess my favorite number?");
            int number = Convert.ToInt32(Console.ReadLine());
            bool isGuessed = number == 47;

            do
            {
                switch (number)
                {
                    case 100:
                        Console.WriteLine("You guessed 100.  You are wrong!");
                        Console.WriteLine("Guess again!");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 67:
                        Console.WriteLine("You guessed 67. Try again!");
                        Console.WriteLine("Guess again!");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 47:
                        Console.WriteLine("Yeah! You know my favorite number!");
                        isGuessed = true;
                        break;
                    default:
                        Console.WriteLine("You are bad at this guessing thing!");
                        Console.WriteLine("Guess again!");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }

            while (!isGuessed);
            Console.ReadLine();
 
        }
    }
}
