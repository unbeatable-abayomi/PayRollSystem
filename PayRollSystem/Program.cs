using System;
using System.Collections.Generic;

namespace PayRollSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            SalariedEmployee salariedEmployee = new SalariedEmployee("james","stausrt",123,1000M);

            HourlyEmployee hourlyEmployee = new HourlyEmployee("Dami", "Hema", 123, 5,500m);

            CommissionEmployee commissionEmployee = new CommissionEmployee("Ruth", "houeman", 123, 0.07, 5000m);

            BasePlusCommissionEmployess basePlusCommissionEmployess = new BasePlusCommissionEmployess("gocie", "Martines", 234, 0.04, 700m, 2000m);

             Console.WriteLine(salariedEmployee);
            Console.WriteLine($"SalariedEmployee Earnings: {salariedEmployee.Earnings():C}\n");


            Console.WriteLine(hourlyEmployee);
            Console.WriteLine($"  HourlyEmployee Earnings: {hourlyEmployee.Earnings():C}\n");


            Console.WriteLine(commissionEmployee);
            Console.WriteLine($"CommissionEmployee Earnings: {commissionEmployee.Earnings():C}\n");



            Console.WriteLine(basePlusCommissionEmployess);
            Console.WriteLine($"BasePlusCommissionEmployess Earnings: {basePlusCommissionEmployess.Earnings():C}\n");
            List<Employee> employees = new List<Employee>() { salariedEmployee, hourlyEmployee, commissionEmployee, basePlusCommissionEmployess };

            Console.WriteLine("==============POLYMORPHICALLY ACCESSING METHODS OF OBJECTS FROM CONCRETE DERIVED-CLASSES FROM ABSTRACT BASE CLASS ");


            foreach (var employee in employees)
            {
                Console.WriteLine(employee);
                Console.WriteLine($"{employee.Earnings():C}");
                if (employee is BasePlusCommissionEmployess)
                {
                    var baseEmployee = (BasePlusCommissionEmployess)employee;
                    baseEmployee.BaseSalary *= 1.10M;
                    Console.WriteLine($"Salary incremented by : 10% - {baseEmployee.BaseSalary}");
                }

              
            }
         }



    }
}
