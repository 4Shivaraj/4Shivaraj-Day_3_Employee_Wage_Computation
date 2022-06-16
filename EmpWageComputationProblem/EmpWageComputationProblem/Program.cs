using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//UC-13
//Ability to get the Total Wage when queried by Company
//- Create Method in EmpWageBuilder to get total wage by Company

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

            //employeeComputation.displayArray();

            Console.WriteLine("Enter the name of the company you want to see the total wage of: ");
            string Name = Console.ReadLine();
            employeeComputation.displayArray(Name);
        }
    }
}

//Result
//Enter the name of the company you want to see the total wage of:
//TATA

//Monthly wage for TATA with
//Daily wage = 160 is 2080

//------------------------------------------------------------------

//Enter the name of the company you want to see the total wage of:
//MAHINDRA

//Monthly wage for MAHINDRA with
//Daily wage = 240 is 3120