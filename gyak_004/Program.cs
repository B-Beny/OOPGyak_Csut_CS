using System;

namespace gyak_004
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("valami");

            //employee.name = "Kiss Jozsef";
            //employee.salary = 200000;

            employee.SetName("Kiss Jozsef");
            employee.Name = "Kiss Ibolya";
            employee.SetSalary(100000);

            Console.WriteLine(employee);
            employee.IncreaseSalary(10000);
            Console.WriteLine(employee);

            Console.WriteLine(employee.IsSalaryInRange(100000, 120000));
            Console.WriteLine($"Tax: {employee.GetTax()}");

            Employee otherEmployee = new Employee("Nagy Jozsef",90000);

            Console.WriteLine(employee.HasHigherSalary(otherEmployee));
            Console.WriteLine(otherEmployee.HasHigherSalary(employee));

            Employee[] employeeArray = new Employee[5];

            for (int i = 0; i < employeeArray.Length; i++)
            {
                Console.Write("Add meg az alkalmazott nevet: ");
                string Name = Console.ReadLine();
                Console.Write("Add meg a fizeteset: ");
                long Salary = Convert.ToInt64(Console.ReadLine());
                employeeArray[i] = new Employee(Name,Salary);
            }

            ListArray(employeeArray);
            Console.WriteLine($"Legjobban fizetett: {employeeArray[BestPaid(employeeArray)].Name}");
            Console.WriteLine($"Darabszam: {CountSalaries(employeeArray, 50000, 80000)}");
            Console.WriteLine($"Atlag: {AverageSalary(employeeArray)}");
            Console.WriteLine($"Ado: {TaxSumma(employeeArray)}");

        }

        public static void ListArray(Employee[] employeeArray)
        {
            foreach (var item in employeeArray)
            {
                Console.WriteLine(item);
            }
        }

        public static int BestPaid(Employee[] employeeArray)
        {
            int max=0;

            for (int i = 1; i < employeeArray.Length; i++)
            {
                if (employeeArray[max].Salary < employeeArray[i].Salary)
                {
                    max = i;
                }
   
            }

            return max;
        }

        public static int CountSalaries(Employee[] employeeArray, long lower, long upper)
        {
            int counter=0;

            foreach (var item in employeeArray)
            {
                if (item.IsSalaryInRange(lower,upper))
                {
                    counter++;
                }
            }

            return counter;
        }

        public static double AverageSalary(Employee[] employees)
        {
            long szum=0;

            foreach (var item in employees)
            {
                szum += item.Salary;
            }

            return (double)szum / employees.Length;
        }

        public static long TaxSumma(Employee[] employees)
        {
            long szum=0;

            foreach (var item in employees)
            {
                szum += item.GetTax();
            }

            return szum;
        }
    }
}
