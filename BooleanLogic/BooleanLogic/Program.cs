using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            //// && Boolean logical AND operator are both of these true
            //Console.WriteLine(true && false);
            //Console.WriteLine(true && true);
            //Console.WriteLine(false && false);


            //// || Boolean logical OR operator 
            //Console.WriteLine(true || true);
            //Console.WriteLine(true || false);
            //Console.WriteLine(false || false);

            //// == Boolean logical EQUALS operator
            //Console.WriteLine(true == true);
            //Console.WriteLine(true == false);
            //Console.WriteLine(false == false);

            //// != Boolean logical DOES NOT EQUAL operator
            //Console.WriteLine(true != true);
            //Console.WriteLine(true != false);
            //Console.WriteLine(false != false);

            // ^ Boolean logical IF ONE IS TRUE BUT NOT THE OTHER [X OR] operator
            Console.WriteLine(true ^ true);
            Console.WriteLine(true ^ false);
            Console.WriteLine(false ^ false);

            Console.ReadLine();

        }
    }
}
