using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise9
{
    public class Employee
    {
        private string firstName;
        public string FirstName
        {
            get { return this.firstName; }
            set { this.firstName = value; }
        }
        private string lastrName;
        public string LastName
        {
            get { return this.lastrName; }
            set { this.lastrName = value; }
        }
        private string ssn;
        public string Ssn
        {
            get { return this.ssn; }
            set { this.ssn = value; }
        }

        private string wage;
        public string Wage
        {
            get { return this.wage; }
            set { this.wage = value; }
        }

        public string FullName
        {
            get { return FirstName + " " + LastName; }
        }
        public Employee(string FirstName, string LastName, string Ssn, string Wage)
        {
            this.firstName = FirstName;
            this.lastrName = LastName;
            this.ssn = Ssn;
            this.wage = Wage;

        }
        public Employee(string Ssn)
        {
            this.ssn = Ssn;
        }
        public void addEmployee(List<Employee> EmployeeList)
        {
            Console.WriteLine("Add Employee\n");
            Console.WriteLine("FirstName: ");
            FirstName = Console.ReadLine();
            Console.WriteLine("LastName: ");
            LastName = Console.ReadLine();
            Console.WriteLine("Social security number: ");
            Ssn = Console.ReadLine();
            Console.WriteLine("Hourly wage: ");
            Wage = Console.ReadLine();
            Employee newEmployee = new Employee(FirstName, LastName, Ssn, Wage);
            EmployeeList.Add(newEmployee);
            Console.WriteLine("Employee added!");
        }
        public void WriteEmployee(List<Employee> EmployeeList)
        {
            Console.Write("Employee name: ");
            string EmployeeName = Console.ReadLine();

            EmployeeName.ToLower().Replace(" ", "");

            foreach (Employee item in EmployeeList)
            {


                string check = item.FirstName.ToLower() + item.LastName.ToLower();

                if (check == EmployeeName.Replace(" ", ""))
                {
                    Console.WriteLine("Employee\n");
                    Console.WriteLine("Name: {0} {1}", item.FirstName, item.LastName);
                    Console.WriteLine("Social security number: {0}", item.Ssn);
                    Console.WriteLine("Hourly wage: {0}\n\n", item.Wage);
                    return;
                }
            }
            Console.WriteLine("User dont exists!");
            Console.WriteLine("Press a key. . .");
            Console.ReadLine();
        }
        public void PutSomeEmployeeInList(List<Employee> EmployeeList)
        {
            Employee Olle = new Employee("Olle", "Svensson", "20020117-5049", "112");
            Employee Sven = new Employee("Sven", "Paulander", "19780920-4036", "155");
            EmployeeList.Add(Olle);
            EmployeeList.Add(Sven);
        }

    }
}
