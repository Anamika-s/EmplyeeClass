using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmplyeeClass
{
    internal class PartTimeEmployee : Employee
    {
        string contractDuration;
        float chargesPerDay;
        //public void GetPartTimeEmployeeDetails()
        public void GetDetails()
        {
            base.GetDetails();
            Console.WriteLine("enter contractDuration");
            contractDuration = Console.ReadLine();
            Console.WriteLine("enter chargesPerDay");
            chargesPerDay= float.Parse(Console.ReadLine());
        }
        //public void DisplayPartTimeEmployeeDetails()
        public void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"contractDuration is {contractDuration}");
            Console.WriteLine($"chargesPerDay are {chargesPerDay}");
        }

    }
}
