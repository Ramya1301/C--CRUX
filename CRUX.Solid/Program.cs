namespace CRUX.Solid
{
    internal class Program
    {
        Employee employee = new Employee();

        static void Main(string[] args)
        {
            Program program = new Program();
            program.DisplayOptions();
            Console.ReadLine();
        }

        public void DisplayOptions()
        {
            Console.WriteLine("1.Add Employee");
            Console.WriteLine("2.Get Employee");
            switch (Console.ReadLine())
            {
                case "1":
                    employee.GetUserDetails();
                    DisplayOptions();
                    break;
                case "2":
                    employee.DisplayUserDetails();
                    DisplayOptions();
                    break;
                case "3":
                    Environment.Exit(0);
                    break;
            }
        }
    }
}