using System;
using HRAdministrationAPI;
using System.Collections.Generic;
using System.Linq;

namespace SchoolHRadministration
{
    public enum EmployeeType
    {
        Teacher,
        HeadOfDepartment,
        DeputyOfDepartment,
        HeadMaster
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal totalSalaries = 0;
            List<IEmployee> employees = new List<IEmployee>();

            SeedData(employees);
            Console.WriteLine($"Total Annual Salaries (Including bonus) : {employees.Sum(e => e.Salary)} ");

            Console.ReadKey();
        }

        public static void SeedData(List<IEmployee> employees)
        {
            IEmployee teacher1 = EmployeeFactory.GetEmployeeInstance(EmployeeType.Teacher, 1, "Juan", "Perez", 40000);
            IEmployee teacher2 = EmployeeFactory.GetEmployeeInstance(EmployeeType.Teacher, 2, "Linda", "Rodriguez", 40000);
            IEmployee HeadOfDepartment = EmployeeFactory.GetEmployeeInstance(EmployeeType.HeadOfDepartment, 3, "Santo", "Robles", 50000);
            IEmployee DeputyOfDepartment = EmployeeFactory.GetEmployeeInstance(EmployeeType.DeputyOfDepartment, 4, "Angie", "Medina", 60000);
            IEmployee HeadMaster = EmployeeFactory.GetEmployeeInstance(EmployeeType.HeadMaster, 5, "Sergio", "Calvo", 80000);

            employees.Add(teacher1);
            employees.Add(teacher2);
            employees.Add(HeadOfDepartment);
            employees.Add(DeputyOfDepartment);
            employees.Add(HeadMaster);

        }
    }

    public class Teacher : EmployeeBase
    {
        public override decimal Salary { get => base.Salary + (base.Salary * 0.02m); }
    }
    public class HeadOfDepartment : EmployeeBase
    {
        public override decimal Salary { get => base.Salary + (base.Salary * 0.03m); }

    }
    public class DeputyOfDepartment : EmployeeBase
    {
        public override decimal Salary { get => base.Salary + (base.Salary * 0.04m); }

    }
    public class HeadMaster : EmployeeBase
    {
        public override decimal Salary { get => base.Salary + (base.Salary * 0.05m); }

    }
    public static class EmployeeFactory
    {
        public static IEmployee GetEmployeeInstance(EmployeeType employeeType, int id, string firstName, string secondName, decimal salary)
        {
            IEmployee employee = null;
            switch (employeeType)
            {
                case EmployeeType.Teacher:
                    employee = FactoryPattern<IEmployee, Teacher>.GetInstance();
                    break;
                case EmployeeType.HeadOfDepartment:
                    employee = FactoryPattern<IEmployee, HeadOfDepartment>.GetInstance();
                    break;
                case EmployeeType.DeputyOfDepartment:
                    employee = FactoryPattern<IEmployee, DeputyOfDepartment>.GetInstance();
                    break;
                case EmployeeType.HeadMaster:
                    employee = FactoryPattern<IEmployee, HeadMaster>.GetInstance();
                    break;
            }
            if (employee != null)
            {
                employee.Id = id;
                employee.FirstName = firstName;
                employee.LastName = secondName;
                employee.Salary = salary;
            }
            else
            {
                throw new NullReferenceException();
            }
            return employee;
        }

    }
}
