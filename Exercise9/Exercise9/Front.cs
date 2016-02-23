using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise9
{
    class Front
    {
        List<Employee> EmployeeList = new List<Employee>();
        Logger LoggBok = new Logger();
        public void fronten()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("        -- Menu --\n---------------------------------------");
                Console.WriteLine("1. Add employee \n2. Remove employee \n3. Print LoggBok \n4. Search\n5. exit\n---------------------------------------");
                ConsoleKeyInfo key;
                key = Console.ReadKey(true);
                switch (key.KeyChar)
                {
                    case '1':
                        addEmployee();
                        break;
                    case '2':
                        RemoveEmployee();
                        break;
                    case '3':
                        LoggBok.ReadLog();
                        break;
                    case '4':
                        AdvansedSearch();
                        break;
                    case '5':
                        Environment.Exit(-1);
                        return;
                    default:
                        break;
                }
                Console.ReadKey();
            }
        }
        public void addEmployee()
        {
            Console.Clear();
            Console.WriteLine("---Add Employee---\n");
            Console.Write("FirstName: ");
            string FirstName = ERROR.NameCheck();
            Console.Write("LastName: ");
            string LastName = ERROR.NameCheck();
            Console.Write("Social security number:(10 numbers)  :Example \"7803184069\" ");
            string Ssn = ERROR.CheckSsn();
            Console.Write("Hourly wage: ");
            string Wage = ERROR.NumberCheckString();
            Employee newEmployee = new Employee(FirstName, LastName, Ssn, Wage);
            EmployeeList.Add(newEmployee);
            Console.WriteLine("Employee added!");
            LoggBok.Logg($"New employee added!\n\nName: {FirstName} {LastName}\nSsn: {Ssn}\nWage: {Wage}\n----------------------------");
        }
        public void RemoveEmployee()
        {
            Console.Clear();
            Console.WriteLine("Employee Social security number :10 numbers Example \"7803184069\" ");
            string control = ERROR.CheckSsn();
            for(int i = 0;i< EmployeeList.Count;i++)
            {
                if (control == EmployeeList[i].Ssn)
                {
                    LoggBok.Logg($"Employee removed!\n\nName: {EmployeeList[i].FullName}\nSsn: {EmployeeList[i].Ssn}\nWage: {EmployeeList[i].Wage}\n----------------------------");
                    EmployeeList.Remove(EmployeeList[i]); Console.WriteLine("Employee removed!");
                                      
                    return;
                }
            }
        }
        public void ReadEmployeeList()
        {
            Console.Clear();
            Console.WriteLine("Employees\n\n----------------------------");
            foreach (var item in EmployeeList)
            {
                Console.WriteLine($"Name: {item.FullName}\nSsn: {item.Ssn}\nWage: {item.Wage}\n----------------------------");
            }
        }
        public void PutSomeEmployeeInList()
        {
            Employee Olle = new Employee("Olle", "Svensson", "0201175049", "112");
            Employee Sven = new Employee("Sven", "Paulander", "8506134342", "155");
            EmployeeList.Add(Olle);
            EmployeeList.Add(Sven);
        }
        public void AdvansedSearch()
        {
            Console.Clear();
            Console.WriteLine("AdvansedSearch Search\n\n----------------------------------\n1.See all Employees\n2.Search with age\n3.Back\n----------------------------------");
            ConsoleKeyInfo key;
            key = Console.ReadKey(true);
            switch (key.KeyChar)
            {
                case '1':
                    ReadEmployeeList();
                    break;
                case '2':
                    SearchWithAge();
                    break;
                case '3':
                    return;
                default:
                    AdvansedSearch();
                    break;
            }


        }
        public void SearchWithAge()
        {
            Console.Clear();
            Console.WriteLine("--Search with age--\n\nSearch with as manny numbers you want\nMore numbers = more precise example: 1984");
            int check;
            if (!int.TryParse(Console.ReadLine(), out check)) { Console.WriteLine("Write numbers!"); }
            int counter = 0;
            string stringcheck = Convert.ToString(check);
            foreach (var item in EmployeeList)
            {
                if (item.Ssn.StartsWith(stringcheck)) { Console.WriteLine($"Name: {item.FullName}\nSsn: {item.Ssn}\nWage: {item.Wage}\n----------------------------"); } 
                if((!item.Ssn.StartsWith(stringcheck))) { counter++; }
                if (counter == EmployeeList.Count) { Console.WriteLine("No Match!"); }
            }
        }
    }
}

