using System;
using System.Collections.Generic;
using System.Text;

namespace Employee_Wage_calc_Problem
{
    class Company
    {
        public String comp_name;
        public int wage_per_hour;
        public int total_working_days;
#pragma warning disable CS0649 // Field 'Company.total_working_hours' is never assigned to, and will always have its default value 0
        public int total_working_hours;
#pragma warning restore CS0649 // Field 'Company.total_working_hours' is never assigned to, and will always have its default value 0


        public Company(String comp_name, int wage_per_hour, int total_working_days, int total_working_hours)
        {
            this.comp_name = comp_name;
            this.wage_per_hour = wage_per_hour;
            this.total_working_days = total_working_days;
            this.total_working_days = total_working_hours;

        }


    }
}
