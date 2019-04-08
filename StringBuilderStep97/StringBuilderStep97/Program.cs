using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilderStep97
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "The quick brown fox jumped over the lazy cat.";
            
            Console.Write(text);
            

            StringBuilder sb = new StringBuilder();
            sb.Append(" I mean the fox jumped over the dog.");
            sb.Append(" Why would a fox jump over a cat?");
            sb.Append(" That would be crazy.");
            sb.Append(" The cat and the fox would obviously have a tea party first.");
            sb.Append(" Because the dog would just be laying there because he is so lazy.");
            sb.Append(" Besides the dog doesn't like tea.");
            Console.Write(sb);
            Console.ReadLine();
        }

    }
}
