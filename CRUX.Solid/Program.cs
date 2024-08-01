using CRUX.Solid;

namespace CRUX.SRP
{
    //SRP-->Single Responsibility Principle:A class should have a single purpose
    //Each class should contain functions related to that class and should not contain code which breaks this principle.

    internal class Program
    {
        //here Employee and Role are two separate entities, if we write AddRole() function in Employee class and the there is an issue in AddRole function it may be confusing for us or other programmers to identify the issue
        Employee employee = new Employee();
        Role Role = new Role();

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
            Console.WriteLine("3.Add Role");
            Console.WriteLine("4.Get Roles");
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
                    Role.AddRole();
                    DisplayOptions();
                    break;
                case "4":
                    Role.GetRoleDetails();
                    DisplayOptions();
                    break;
                case "5":
                    Environment.Exit(0);
                    break;
            }
        }
    }
}