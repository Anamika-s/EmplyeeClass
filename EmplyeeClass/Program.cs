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
        }
    }
}
