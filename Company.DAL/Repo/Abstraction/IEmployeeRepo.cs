using Company.DAL.Entities;


namespace Company.DAL.Repo.Abstraction
{
    public interface IEmployeeRepo
    {

        //bool create(Employee employee);
        //bool edit(Employee employee);
        List<Employee> GetAll();
        //bool GetById(long id);
        //Employee Get(Expression<Func<Employee, bool>> filter =null);
    }
}
