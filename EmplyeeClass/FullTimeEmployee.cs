using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmplyeeClass
{
    internal class FullTimeEmployee : Employee
    {
        string dept;
        string manager;
        float salary;
            public void GetDetails()
        //public void GetFullTimeEmployeeDetails()
        {
            base.GetDetails();
            Console.WriteLine("enter dept");
            dept = Console.ReadLine();

            Console.WriteLine("enter manager");
            manager = Console.ReadLine(); 
            Console.WriteLine("enter salary");
            salary = float.Parse(Console.ReadLine());
        }
        //public void DisplayFullTimeEmployeeDetails()
        public void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"dept is {dept}");
            Console.WriteLine($"manager is {manager}");
            Console.WriteLine($"salary is {salary}");
        }


    }
}
