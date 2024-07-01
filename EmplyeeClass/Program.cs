namespace EmplyeeClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ParTime Employee ");
            PartTimeEmployee partTimeEmployee = new PartTimeEmployee();
            partTimeEmployee.GetDetails();
            //partTimeEmployee.GetPartTimeEmployeeDetails();
            partTimeEmployee.DisplayDetails();
            //partTimeEmployee.DisplayPartTimeEmployeeDetails();

            Console.WriteLine("FullTime Employee");
            FullTimeEmployee fullTimeEmployee = new FullTimeEmployee();
            fullTimeEmployee.GetDetails();
            //fullTimeEmployee.GetFullTimeEmployeeDetails();
            fullTimeEmployee.DisplayDetails();
            //fullTimeEmployee.DisplayFullTimeEmployeeDetails();

            PartTimeEmployee partTimeEmployee1 =
                 new PartTimeEmployee(90, "ajay", "New Delhi",
                 "90 Days", 9000f);

            partTimeEmployee1.DisplayDetails();

            FullTimeEmployee fullTimeEmployee1 = new FullTimeEmployee
                (id: 102, name: "deepak", address: "delhi",
                dept: "hr", manager: "deepak", salary: 9090f);
            fullTimeEmployee1.DisplayDetails ();

        }
    }
}
