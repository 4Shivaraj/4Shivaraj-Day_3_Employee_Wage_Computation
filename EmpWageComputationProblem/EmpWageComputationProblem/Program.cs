using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//UC-13
//Store the Daily Wage along with the Total Wage

namespace EmployeewageComputation
{
    class Program
    {
        public static void Main(string[] args)
        {

            EmployeeWageComputation employeeComputation = new EmployeeWageComputation(2);
            employeeComputation.AddCompany("TATA", 20, 8, 4, 100, 20);
            employeeComputation.CalculateEmpWage("TATA");

            employeeComputation.AddCompany("MAHINDRA", 30, 8, 4, 100, 20);
            employeeComputation.CalculateEmpWage("MAHINDRA");

            employeeComputation.displayArray();
        }
    }
}

//Result
//Monthly wage for TATA with Daily wage = 160 is 2080

//Monthly wage for MAHINDRA with Daily wage = 240 is 3000