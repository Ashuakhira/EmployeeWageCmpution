using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    public class EmpSalary
    {
        public static void EmployeeSalary()
        {
            int EMP_RATE_PER_HOUR = 20;
            int IS_FULL_TIME = 1;
            int empHour = 0;
            int empWage = 0;
            Random rdm = new Random();
            int empchk = rdm.Next(2);
            if (empchk == IS_FULL_TIME)
            {
                //Console.WriteLine("Employee is Present");
                empHour = 8;
            }
            else
            {
                //Console.WriteLine("Employee Is Absent");
                empHour = 0;
            }
            empWage = empHour * EMP_RATE_PER_HOUR;
            Console.WriteLine("EmployeeWage:" + empWage);
        }
    }
}
