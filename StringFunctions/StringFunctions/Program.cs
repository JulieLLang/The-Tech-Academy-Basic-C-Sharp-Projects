using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            //string name = "Julie";
            //string quote = "The man said, \"Hello\" Julie.";
            ////backslash is used as an escape character it is not part of the string 

            //Console.WriteLine(quote);
            //Console.ReadLine();

            //string name = "Julie";
            //string quote = "The man said, \"Hello\" Julie. \n Hello on a new line \n \t hello on a tab";
            ////new line character \n \t is tabbed out 
            //// double backslash \\shows one backslash must do \\for file names in C#

            //bool trueOrFalse = name.Contains("J");
            //trueOrFalse = name.EndsWith("u");

            //int length = name.Length;

            //name = name.ToUpper();

            //name = name.ToLower();


            //Console.WriteLine(name);
            //Console.ReadLine();

            //strings can not be changed they create a new one each change


            //string name = "jesse";
            //name = "joe";

            //Console.WriteLine(name);
            //Console.ReadLine();

            //string builder

            StringBuilder sb = new StringBuilder();
            sb.Append("My name is Jesse");
            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}
