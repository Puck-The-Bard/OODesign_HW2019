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
        int mon = 1;
        int day = 1;
        int year = 1900;   

       //earliest date int values
        static int eDay = 0;
        static int eMonth = 0;
        static int eYear = 0;

        //latest date int values
        static int lDay = 0;
        static int lMonth = 0;
        static int lYear = 0;
        
        //takes and saves user date input
        public tDate()
        {
            mon = 1;
            day = 1;
            year = 1900;
        }
        public void setDate(int usrMonth, int usrDay, int usrYear)
        {
            if(DateValidation(usrMonth, usrDay,usrYear))
           {
            day = usrDay;
            mon = usrMonth;
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
        public void setDate (string UsrDate)
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

        //set earliest date
        public void earliestDate(int usrDay, int usrMonth, int usrYear)
        {
            eDay = usrDay;
            eMonth = usrMonth;
            eYear = usrYear;
        }
        public void earliestDate(string usrDate)
        {
            string[] dateArry = usrDate.Split('/');
            earliestDate(Convert.ToInt32(dateArry[0]),Convert.ToInt32(dateArry[1]),Convert.ToInt32(dateArry[2]));

        }

        //set latest date
        public void latestDate(int usrDay, int usrMonth, int usrYear)
        {
            lDay = usrDay;
            lMonth = usrMonth;
            lYear = usrYear;
        }
        public void latestDate(string usrDate)
        {
            string[] dateArry = usrDate.Split('/');
            latestDate(Convert.ToInt32(dateArry[0]),Convert.ToInt32(dateArry[1]),Convert.ToInt32(dateArry[2]));

        }

 


        //verify valid date input and output a bool value
        static bool DateValidation(int day, int mon, int year)
        {
            if(day >= eDay && day <= lDay && mon >= eMonth && mon <= lMonth && year >= eYear && year <= lYear)
            {
                return true;  
            }
            else
            {
                return false;
            }
        }


        //print date to screen
        public void ShowDate(string selec)
        {
            //Console.WriteLine("\nMonth: " + mon + "\nDay:" + day + "\nyear: " + year);
            //select format and print date in correct format
            switch(selec)
            {
                case "U":
                    Console.WriteLine($"{mon}/{day}/{year}");
                    break;
                case "E":
                    Console.WriteLine($"{day}/{mon}/{year}");
                    break;
                default:
                    Console.WriteLine("\nMonth: " + mon + "\nDay:" + day + "\nyear: " + year);
                    break;
            }
        }



        



        
    }
}
