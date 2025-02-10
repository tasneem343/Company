using Company.BLL.Service.Abstraction;
using Company.DAL.Entities;
using Company.DAL.Repo.Abstraction;
using Company.DAL.Repo.Implementation;

namespace Company.BLL.Service.Implementation
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepo repo;
        public EmployeeService() 
        {
            repo=new EmployeeRepo();
        }
        public List<Employee> GetAll()
        {
            var result=repo.GetAll();
            return result;
        }
    }
}
