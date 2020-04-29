using System;
using System.Collections.Generic;
using System.Text;

namespace PayRollSystem
{
    public abstract class Employee:IPayment
    {
        protected string FirstName { get; set; }
        protected string LastName { get; set; }
        protected int EmployeeID { get; set; }


        public Employee (string firstname, string lastname, int empID)
        {
            FirstName = firstname;
            LastName = lastname;
            EmployeeID = empID;
        }

      
       

        public override string ToString()
        {
            return $"{FirstName} {LastName}\n Employee ID: {EmployeeID}";
        }

        public abstract decimal Earnings();

        public decimal GetPaymentAmount()
        {
            return Earnings();
        }
    }
}
