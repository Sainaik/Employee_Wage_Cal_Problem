﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Employee_Wage_calc_Problem
{
    class Company
    {
        public String comp_name;
        public int wage_per_hour;
        public int total_working_days;
        public int total_working_hours;


        public Company(String comp_name, int wage_per_hour, int total_working_days, int total_working_hours)
        {
            this.comp_name = comp_name;
            this.wage_per_hour = wage_per_hour;
            this.total_working_days = total_working_days;
            this.total_working_days = total_working_hours;

        }


    }
}
