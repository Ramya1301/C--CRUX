namespace CRUX.Solid
{
    //SRP-->Single Responsibility Principle:A class should have a single purpose
    //Each class should contain functions related to that class and should not contain code which breaks this principle.
    
    public class Employee
    { 
        List<Models.Employee> employees = new List<Models.Employee>();

        public void GetUserDetails()
        {
            Models.Employee employee = new Models.Employee();
            Console.WriteLine("Enter Id of employee");
            employee.Id = int.Parse(Console.ReadLine()!);
            Console.WriteLine("Enter Name of employee");
            employee.Name = Console.ReadLine()!;
            Console.WriteLine("Enter Salary of employee");
            employee.Salary = Console.ReadLine()!;
            employees.Add(employee);
        }

        public void DisplayUserDetails()
        {
            foreach (var item in employees)
            {
                Console.WriteLine($"Id:{item.Id}");
                Console.WriteLine($"Name:{item.Name}");
                Console.WriteLine($"Salary:{item.Salary}");
                Console.WriteLine("==================================");
            }
        }
    }
}
