using System;
using System.Collections.Generic;
using System.Text;

namespace PayRollSystem
{
    class SalariedEmployee:Employee
    {
        private decimal weeklySalary;


        public SalariedEmployee(string firstname, string lastname, int empID, decimal weeksalary):base(firstname,lastname,empID)
        {
            WeeklySalary = weeksalary;
        }

        public decimal WeeklySalary 
        {
            get => weeklySalary;
            set { if (value > 0M)

                    weeklySalary = value;
                else
                    throw new System.ArgumentOutOfRangeException("Value out of range ");
            }
        }

       

        public override decimal Earnings()
        {
            return WeeklySalary;
        }

        public override string ToString()=> $"{base.ToString()}\n Salaried Employee";



    }
}
