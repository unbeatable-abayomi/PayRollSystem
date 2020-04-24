using System;
using System.Collections.Generic;
using System.Text;

namespace PayRollSystem
{
    class BasePlusCommissionEmployess: CommissionEmployee
    {

        

        public decimal BaseSalary { get; set; }

        public BasePlusCommissionEmployess(string firstname, string lastname, int empId, double rate, decimal totalsales, decimal basesalary) : base(firstname, lastname, empId, rate, totalsales)
        {
            BaseSalary = basesalary;
        }



        public override decimal Earnings()
        {
            return base.Earnings() + BaseSalary;
        }

        public override string ToString()
        {
            return $"Base Plus Commission Employess: {base.ToString()}\nWeekly Base Salary : {BaseSalary}";
        }
    }
}
