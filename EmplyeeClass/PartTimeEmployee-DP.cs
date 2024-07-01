using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmplyeeClass
{
    internal class PartTimeEmployee_DP : Employee_DP
    {
        string contractDuration;
        float chargesPerDay;
        //public void GetPartTimeEmployeeDetails()
        public override void GetDetails()
        { 
            base.GetDetails();
            Console.WriteLine("enter contractDuration");
            contractDuration = Console.ReadLine();
            Console.WriteLine("enter chargesPerDay");
            chargesPerDay= float.Parse(Console.ReadLine());
        }
        //public void DisplayPartTimeEmployeeDetails()
        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"contractDuration is {contractDuration}");
            Console.WriteLine($"chargesPerDay are {chargesPerDay}");
        }

        public PartTimeEmployee_DP()  : base() { }
        public PartTimeEmployee_DP(int id, string name, 
            string address, string contractDuration,  float chargesPerDay)
            : base (id, name , address)
        {
            this.contractDuration = contractDuration;
            this.chargesPerDay = chargesPerDay;
        }



    }
}
