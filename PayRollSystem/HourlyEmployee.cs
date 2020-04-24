using System;
using System.Collections.Generic;
using System.Text;

namespace PayRollSystem
{
    class HourlyEmployee:Employee
    {
        private int hoursWorked;
        private decimal hourlyWage;

        public HourlyEmployee(string firstname, string lastname, int empID, int hoursworked, decimal hourswage):base(firstname,lastname,empID)
        {
            HoursWorked = hoursworked;
            HourlyWage = hourswage;

        }


        public int HoursWorked
        {
            get { return hoursWorked; }
            set
            {
                if((value > 0) && (value <= 120))
                {
                    hoursWorked = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Argument out of Range should be Hoursworked ");
                }

            }
        }

        public decimal HourlyWage
        {
            get { return hourlyWage; }
            set
            {
                if(value > 0)
                {
                    hourlyWage = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Hour wage Shloud be greater than zero");
                }
            }
        }


        public override decimal Earnings()
        {
            if(HoursWorked > 40)
            {
                return ((40 * HourlyWage) + ((HoursWorked - 40) * (HourlyWage * 1.5m)));
            }
            else
            {
                return HoursWorked * HourlyWage;
            }
        }

        public override string ToString()
        {
            return $"{base.ToString()}\n Hourly Employee :\n Hourly Wage:hi {HourlyWage}\n Hours Worked: {HoursWorked}";
        }
    }
}
