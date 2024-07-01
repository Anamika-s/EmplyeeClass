using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmplyeeClass
{
    internal class Employee
    {
        int id;
        string name;
        string address;
        public void GetDetails()
        {
            Console.WriteLine("enter id");
            id = int.Parse(Console.ReadLine());
            Console.WriteLine("enter name");
            name = Console.ReadLine();
            Console.WriteLine("enter address");
            address = Console.ReadLine();
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"Id is {id}");
            Console.WriteLine($"Name is {name}");
            Console.WriteLine($"Address is {address}");
        }
        public Employee() { }
        public Employee(int id, string name, string address)
        {
            this.id = id;
            this.name = name;
            this.address = address;
        }
    }
}
