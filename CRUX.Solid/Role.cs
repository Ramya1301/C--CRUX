using CRUX.SRP;
using CRUX.SRP.Models;

namespace CRUX.Solid
{
    public class Role
    {
        List<SRP.Models.Role> roles = new List<SRP.Models.Role>();

        public void AddRole()
        {
            SRP.Models.Role role = new SRP.Models.Role();
            Console.WriteLine("Please enter Id:");
            role.Id=int.Parse(Console.ReadLine()!);
            Console.WriteLine("Please enter Name");
            role.Name = Console.ReadLine()!;
            Console.WriteLine("Please enter description");
            role.Description = Console.ReadLine()!;
            roles.Add(role);
        }

        public void GetRoleDetails()
        {
            foreach (var item in roles)
            {
                Console.WriteLine($"Id:{item.Id}");
                Console.WriteLine($"Name:{item.Name}");
                Console.WriteLine($"Salary:{item.Description}");
                Console.WriteLine("==================================");
            }
        }
    }
}
