using Company.BLL.Service.Abstraction;
using Company.BLL.Service.Implementation;

namespace Company.PL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IEmployeeService _employeeService = new EmployeeService();
            var result=_employeeService.GetAll();
            foreach (var item in result) { 
                Console.WriteLine(item.Department.Name);
            }
            Console.WriteLine("Hello, World!");
        }
    }
}
