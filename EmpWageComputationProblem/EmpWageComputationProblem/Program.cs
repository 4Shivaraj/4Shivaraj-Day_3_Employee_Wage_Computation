using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//UC-12
//Refactor to have list of multiple companies to manage Employee Wage.
//- Note: Refactor to use ArrayList instead of array

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
//Monthly wage for TATA is 2080
//Monthly wage for MAHINDRA is 3120