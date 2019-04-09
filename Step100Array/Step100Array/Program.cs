using System;
using System.Collections.Generic;

class Program
    {
    static void Main(string[] args)
    {
        string[] strArray = new string[5];
        strArray[0] = "Julie";
        strArray[1] = "Isaac";
        strArray[2] = "Clarence";
        strArray[3] = "Olive";
        strArray[4] = "Tweezer";

        Console.WriteLine("Please Choose an index number in the array: ");

        Console.WriteLine(strArray[4]);
        Console.ReadLine();

        //Console.WriteLine("Please Choose an index number in the array: ");
        //string yourNum = Console.ReadLine();
        //int Index = Convert.ToInt32(yourNum);
        //Console.WriteLine("You chose: " + Index);

        ////Console.WriteLine("You choose ")
        ////Console.WriteLine(strArray[3]);
        //Console.ReadLine();

        //Console.WriteLine("Please Enter your age:");
        //string yourAge = Console.ReadLine();
        //int Age = Convert.ToInt32(yourAge);
        //Console.WriteLine("You are:" + " " + Age);
    }
    }

