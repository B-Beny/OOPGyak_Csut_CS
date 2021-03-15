using System;
using System.Collections.Generic;
using System.Text;

namespace gyak_004
{
    class Employee
    {
        //private string name;
        //private long salary;

        private string name;
        private long salary;

        public Employee(string name, long salary)
        {
            this.name = name;
            this.salary = salary;
        }

        public Employee(string name) : this(name,250000) { }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public long Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        public string GetName()
        { 
            return name; 
        }

        public void SetName(string value)
        { 
            name = value; 
        }

        public long GetSalary()
        {
            return salary;
        }

        public void SetSalary(long value)
        {
            salary = value;
        }

        public void IncreaseSalary(long salary)
        {
            this.salary += salary;
        }

        public override string ToString()
        {
            return "Name: " + Name + ", salary: " + Salary + " Ft";
        }

        public bool IsSalaryInRange(long lower, long upper)
        {
            if (salary >= lower && salary <= upper)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public long GetTax()
        {
            return (long)(salary * 0.16);
        }

        /// <summary>
        /// Has higher salary?
        /// </summary>
        /// <param name="HasHigherSalary"></param>
        /// <returns>boolean value</returns>

        public bool HasHigherSalary(Employee otherEmployee)
        {
            if (salary > otherEmployee.salary)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
