using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceElgibility
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter your age:");
            string yourAge = Console.ReadLine();
            int Age = Convert.ToInt32(yourAge);
            Console.WriteLine("You are:" + " " + Age);
            Console.WriteLine("Please continue to next question.");

            Console.ReadLine();
            Console.WriteLine("Have you ever had a DUI? Please answer \"true\" or \"false\":");
            string yourDui = Console.ReadLine();
            bool Dui = bool.Parse(yourDui);
            Console.WriteLine("Have you ever had a DUI?" + " " + Dui);
            Console.WriteLine("Please continue to next question.");
            
            Console.ReadLine();
            Console.WriteLine("How many speeding tickets do you have?");
            string yourTickets = Console.ReadLine();
            int Tickets = Convert.ToInt32(yourTickets);
            
            Console.ReadLine();
            Console.WriteLine("Do you qualify for insurance? True or False:");
            bool trueOrFalse = Age >= 15 && Dui != true && Tickets <=3;
            Console.WriteLine(trueOrFalse.ToString());
            Console.ReadLine();











        }
    }
}
