using System;
using System.Collections.Generic;

class Program
    {
    static void Main()
    {
        ////Lists can be created with any data type
        //List<int> intList = new List<int>();
        //intList.Add(4);
        //intList.Add(10);
        //Console.WriteLine(intList[1]);
        //Console.ReadLine();
        List<string> intList = new List<string>();
        intList.Add("Hello");
        intList.Add("Julie");
        intList.Remove("Hello");

        Console.WriteLine(intList[0]);
        Console.ReadLine();

        ////image into database
        ////initalize with image to decalre size
        ////byte[] byteArray = new byte[];

        //declare an array of integers // must define length of array first
        //created a new instance of an array called an object and printed to the console
        //int[] numArray = new int[5];
        //numArray[0] = 5;
        //numArray[1] = 2;
        //numArray[2] = 10;
        //numArray[3] = 200;
        //numArray[4] = 5000;

        //Console.WriteLine(numArray[4]);
        //Console.ReadLine();


        ////same as above just less code!!! More flexable
        ////because youn can add addtional numbers
        //int[] numArray1 = new int[] { 5, 2, 10, 200, 5000 };

        //Console.WriteLine(numArray1[4]);
        //Console.ReadLine();


        ////even better way
        //int[] numArray2 = { 5, 2, 10, 200, 5000, 600, 2300 };
        
        ////change a number in the array
        //numArray2[5] = 650;
        //Console.WriteLine(numArray2[5]);
        //Console.ReadLine();

        }
    }

