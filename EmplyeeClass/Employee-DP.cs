using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmplyeeClass
{
    internal class Employee_DP
    {
        int id;
        string name;
        string address;
        public virtual void GetDetails()
        {
            Console.WriteLine("enter id");
            id = int.Parse(Console.ReadLine());
            Console.WriteLine("enter name");
            name = Console.ReadLine();
            Console.WriteLine("enter address");
            address = Console.ReadLine();
        }

        public virtual void DisplayDetails()
        {
            Console.WriteLine($"Id is {id}");
            Console.WriteLine($"Name is {name}");
            Console.WriteLine($"Address is {address}");
        }
        public Employee_DP() { }
        public Employee_DP(int id, string name, string address)
        {
            this.id = id;
            this.name = name;
            this.address = address;
        }
        
    }
}
