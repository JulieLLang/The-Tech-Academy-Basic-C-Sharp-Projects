using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertToUppercase
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "julie";
            name = name.ToUpper();
            Console.WriteLine(name);
            Console.ReadLine();
        }
    }
}
