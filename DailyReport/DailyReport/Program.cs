using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyReport
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Tech Academy,");
            Console.WriteLine("Student Daily Report");
            Console.WriteLine("Press \"Enter\" to continue");
            Console.ReadLine();
            Console.WriteLine("what course are you on?");
            string yourCourse = Console.ReadLine();
            Console.WriteLine("You are currently working on: " + yourCourse);
            Console.WriteLine("What page number are you on?");
            string yourNumber = Console.ReadLine();
            Console.WriteLine("Your on page: " + yourNumber);
            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\".");
            string needHelp = Console.ReadLine();
            Console.WriteLine("Your answer to whether you need help is: " + needHelp);
            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
            string expereinceSpecifics = Console.ReadLine();
            Console.WriteLine("Your experience was: " + expereinceSpecifics);
            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
            string feedBack = Console.ReadLine();
            Console.WriteLine("Your feedback was: " + feedBack);
            Console.WriteLine("How many hours did you study today?");
            string studyHours = Console.ReadLine();
            Console.WriteLine("You studyed for: " + studyHours + " " + "hours today!");
            Console.WriteLine();
            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();


        }

    }
}