using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Julie";
            string date =DateTime.Today.ToShortDateString();
            string quote = "Be awesome today";

            string str = "Hello " + name + ". Today is " + date + ". Don't forget to..." + quote + "!";
            Console.WriteLine(str);
            Console.ReadLine();

        }
    }
}
