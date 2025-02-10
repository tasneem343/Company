

using Company.DAL.Entities;

namespace Company.BLL.Service.Abstraction
{
    public interface IEmployeeService
    {
        List<Employee> GetAll();
    }
}
