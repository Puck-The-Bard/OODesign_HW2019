/*
Zach McGuire
Assignment 2
9/17/2019

*/

using System;

namespace HW_2
{
    class tDate
    {
        // Saving Dates
        static int mon = 1;
        static int day = 1;
        static int year = 1900;   

        static string earliestDate = "1/1/1900";
        static string latestDate = "12/31/2100";
        static string usrDate = "1/1/1900";
        
        //takes and saves user date input
        public tDate(int day, int month, int usrYear)
        {
            if(DateValidation(day, month,usrYear))
           {
            mon = day;
            day = month;
            year = usrYear;
           }
           else
           {
               mon = 1;
               day = 1;
               year = 1900;
           }
        }

        //saves user date input with strings in US format
        public tDate (string UsrDate)
        {
            string[] dateArry = UsrDate.Split('/');

            if(DateValidation(Convert.ToInt32(dateArry[0]),Convert.ToInt32(dateArry[1]),Convert.ToInt32(dateArry[2])))
            {
            mon = Convert.ToInt32(dateArry[0]);
            day = Convert.ToInt32(dateArry[1]);
            year = Convert.ToInt32(dateArry[2]);
            }
            else
            {
               mon = 1;
               day = 1;
               year = 1900;
            }
        }


        //verify valid date input and output a bool value
        static bool DateValidation(int d, int mon, int year)
        {
            if(d > 0 && d <= 31 && mon > 0 && mon <= 12 && year >= 1900 && year <= 2100)
            {
              return true;  
            }
            else
            {
                return false;
            }
        }


        //print date to screen
        static void ShowDate(string selec)
        {
            switch(selec)
            {
                case "U":
                    Console.WriteLine($"{0}/{1}/{2}",mon,day,year);
                    break;
                case "E":
                    Console.WriteLine($"{1}/{0}/{2}",mon,day,year);
                    break;
                default:
                    break;
            }
        }



        



        
    }
}
