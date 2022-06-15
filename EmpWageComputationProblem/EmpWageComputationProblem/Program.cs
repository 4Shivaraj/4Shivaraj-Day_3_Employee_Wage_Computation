//Console.WriteLine("Welcome To Employee Wage Computation Problem");
namespace oopsday2
{ 
    class Program
    {
        public static void Main(string[] args)
        {



            EmployeeWageComputation employeeWageComputation = new EmployeeWageComputation(2);
            employeeWageComputation.AddCompany("TATA", 20, 8, 4, 100, 20);
            employeeWageComputation.CalculateEmpWage("TATA");
            employeeWageComputation.AddCompany("MAHINDRA", 30, 8, 4, 100, 20);
            employeeWageComputation.CalculateEmpWage("MAHINDRA");
            employeeWageComputation.displayArray();


        }
    }
}