namespace EmplyeeClass
{
    internal class Program1
    {
        static void Main(string[] args)
        {
            Employee_DP employee = null ;
            Console.WriteLine("What type of employee");
            int ch = byte.Parse(Console.ReadLine());
            switch(ch)
            {
                case 1:
                    
                        { Console.WriteLine("Creating PartTime Emp");
                            employee = new PartTimeEmployee_DP(); break; }
                case 2:
                            {
                                Console.WriteLine("Creating FullTime Emp");
                                employee = new FullTimeEmployee_DP(); break;
                            }
            }
            employee.GetDetails();
            employee.DisplayDetails();

        }
    }
}
