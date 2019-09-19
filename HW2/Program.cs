/*
Zach McGuire
Assignment 2
9/17/2019

*/

using System;

namespace HW_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //create date object
            tDate Mydate = new tDate();
            //set the earliest and latest valid dates
            Mydate.earliestDate(1,1,1900);
            Mydate.latestDate(12,31,2100);

            //begin testing
            Mydate.setDate(12,15,1990);
            PrintStuff(Mydate);

            Mydate.setDate("12/15/1990");
            PrintStuff(Mydate);

            Mydate.setDate("15/12/1990");
            PrintStuff(Mydate);

            Mydate.setDate("11/11/1811");
            PrintStuff(Mydate);


        }

        //prints and formats results for tests
        static void PrintStuff(tDate theDate)
        {   
            Console.WriteLine("US Date: ");
            theDate.ShowDate("U");
            Console.WriteLine("European Date: ");
            theDate.ShowDate("E");
            Console.WriteLine();
        }
    }
}
