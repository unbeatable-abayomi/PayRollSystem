using System;
using System.Collections.Generic;
using System.Text;

namespace PayRollSystem
{
    class CommissionEmployee:Employee
    {
        private double commRate;
        private decimal totalSales;


        public CommissionEmployee(string firstname, string lastname, int empID, double comm, decimal sales): base(firstname,lastname,empID)
        {
            CommissionRate = comm;
            TotalSales  = sales;
        }






        public double CommissionRate 
        {
            get => commRate;
            set
            {
                if(value > 0 && value <= 1)
                {
                    commRate = value;

                }
                else
                {
                    throw new ArgumentOutOfRangeException("Commission must be");
                }
            }
        }

        public decimal TotalSales
        {
            get => totalSales;
            set
            {
                if (value > 0M)
                {
                    totalSales = value;

                }
                else
                {
                    throw new ArgumentOutOfRangeException("Commission must be");
                }
            }
        }


        public override decimal Earnings()
        {
            return (decimal)CommissionRate * TotalSales;
        }

        public override string ToString()
        {
            return $"{ base.ToString()}\n Total Sale {TotalSales}\n Commission Rate{CommissionRate * 100:C}%";
        }

    }
}
