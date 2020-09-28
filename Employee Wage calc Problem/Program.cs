using System;
using System.Collections.Generic;

namespace Employee_Wage_calc_Problem
{
    class Program
    {
        //constants

        const int IS_FULL_TIME = 1;
        const int IS_PART_TIME = 2;
        
 


        public static int CalculateWage(String comp_name, int wage_per_hour, int total_working_days, int total_working_hours)
        {
            Random rand = new Random();


            //variable

            int numberOfHours = 0;
            int workingDays = 1;
            int total_wage = 0;

            // run till the number of hours or workingdays reached in respective company

            while (numberOfHours <= total_working_hours && workingDays <= total_working_days)
            {
               
                int type = rand.Next(0, 3);
                int hours = 0;

                // switch to type of Employee

                switch (type)
                {
                    case IS_FULL_TIME:
                        hours = 8;
                        break;
                    case IS_PART_TIME:
                        hours = 4;
                        break;
                    default:
                        hours = 0;
                        break;

                }

                // add the hours to total hrs

                numberOfHours += hours;

                Console.Out.WriteLine(comp_name + " Day " + workingDays + " hours " + hours);

                workingDays++;

            }

            total_wage = numberOfHours * wage_per_hour;

            return total_wage;
        }
        static void Main(string[] args)
        {

            int total_wage = 0;


            Company Apple = new Company("Apple", 150, 20, 150);

            Company Google = new Company("Google", 125, 22, 150);

            IDictionary<Company, int> CompNames = new Dictionary< Company, int>();

            total_wage = CalculateWage(Apple.comp_name, Apple.wage_per_hour,Apple.total_working_days,  Apple.total_working_hours);
 
            CompNames.Add(Apple, total_wage); //adding a key/value using the Add() method
           
            total_wage = CalculateWage(Google.comp_name, Google.wage_per_hour, Google.total_working_days, Google.total_working_hours);

            CompNames.Add( Google ,total_wage);

            foreach (KeyValuePair<Company, int> comp in CompNames)
            {
                Console.WriteLine(comp.Key.comp_name +"'s wage per month is : "+ comp.Value);
            }

            

        }
    }
}
