using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step100Array
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Create an array of strings. Ask the user to select an index of the Array and then display the string at that index on the screen.
            Console.WriteLine("Select an index of an array 0-6");
            string[] stringArray;

            stringArray = new string[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            int number = Convert.ToInt32(Console.ReadLine());

            switch (number)
            {
                case 0:
                    Console.WriteLine("This is Monday.");
                    number = Convert.ToInt32(Console.ReadLine());
                    break;
                case 1:
                    Console.WriteLine("This is Tuesday.");
                    number = Convert.ToInt32(Console.ReadLine());
                    break;
                case 2:
                    Console.WriteLine("This is Wednesday.");
                    number = Convert.ToInt32(Console.ReadLine());
                    break;
                case 3:
                    Console.WriteLine("This is Thursday.");
                    number = Convert.ToInt32(Console.ReadLine());
                    break;
                case 4:
                    Console.WriteLine("This is Friday.");
                    number = Convert.ToInt32(Console.ReadLine());
                    break;
                case 5:
                    Console.WriteLine("This is Saturaday.");
                    number = Convert.ToInt32(Console.ReadLine());
                    break;
                case 6:
                    Console.WriteLine("This is Sunday. \"Are you ready for Game of Thrones\"!");
                    number = Convert.ToInt32(Console.ReadLine());
                    break;
            }


            ////2.Create an array of integers. Ask the user to select an index of the Array and then display the integer at that index on the screen.
            ///AND 
            ////3.Add in a message that displays when the user selects an index that doesn’t exist.

            Console.WriteLine("Select an index of the array 0-4:");
            int[] intArray1 = new int[] { 5, 2, 10, 200, 5000 };
            int number = Convert.ToInt32(Console.ReadLine());

            switch (number)
            {
                case 0:
                    Console.WriteLine("The number 5 is at index 0");
                    number = Convert.ToInt32(Console.ReadLine());
                    break;
                case 1:
                    Console.WriteLine("The number 2 is at index 1.");
                    number = Convert.ToInt32(Console.ReadLine());
                    break;
                case 2:
                    Console.WriteLine("The number 10 is at index 2.");
                    number = Convert.ToInt32(Console.ReadLine());
                    break;
                case 3:
                    Console.WriteLine("The number 200 is at index 3.");
                    number = Convert.ToInt32(Console.ReadLine());
                    break;
                case 4:
                    Console.WriteLine("The number 5000 is at index 4.");
                    number = Convert.ToInt32(Console.ReadLine());
                    break;
                default:
                    Console.WriteLine("I'm sorry that index number does not exist in this array");
                    number = Convert.ToInt32(Console.ReadLine());
                    break;
            }

            Console.ReadLine();

            //4.Create a List of strings. Ask the user to select an index of the List and then display the content at that index on the screen.

            Console.WriteLine("Please select an index of the following list...chose from the numbers 0 - 4");
            List<string> intList = new List<string>();
            intList.Add("Hello");
            intList.Add("Guten Tag");
            intList.Add("Good Day");
            intList.Add("Bonjour");
            intList.Add("Howdy Partner!");
           
            int number = Convert.ToInt32(Console.ReadLine());

            switch (number)
            {
                case 0:
                    Console.WriteLine(intList[0]);
                    number = Convert.ToInt32(Console.ReadLine());
                    break;
                case 1:
                    Console.WriteLine(intList[1]);
                    number = Convert.ToInt32(Console.ReadLine());
                    break;
                case 2:
                    Console.WriteLine(intList[2]);
                    number = Convert.ToInt32(Console.ReadLine());
                    break;
                case 3:
                    Console.WriteLine(intList[3]);
                    number = Convert.ToInt32(Console.ReadLine());
                    break;
                case 4:
                    Console.WriteLine(intList[4]);
                    number = Convert.ToInt32(Console.ReadLine());
                    break;
                default:
                    Console.WriteLine("I'm sorry that index number does not exist in this list.");
                    number = Convert.ToInt32(Console.ReadLine());
                    break;

            }

            Console.ReadLine();
        }
    }
}
