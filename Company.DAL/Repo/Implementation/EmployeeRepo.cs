using Company.DAL.DataBase;
using Company.DAL.Entities;
using Company.DAL.Repo.Abstraction;
using Microsoft.EntityFrameworkCore;



namespace Company.DAL.Repo.Implementation
{
    public class EmployeeRepo : IEmployeeRepo
    {
        private readonly ApplicationDBcontext db;
        public EmployeeRepo() {
            db = new ApplicationDBcontext();
        }
        //public bool create(Employee employee)
        //{
        //    try
        //    {
        //        db.Employees.Add(employee);
        //        db.SaveChanges();
        //        return true;

        //    }
        //    catch (Exception)
        //    {
        //        return false;
        //    }
        //}

       
        //public bool edit(Employee employee)
        //{
        //   var result = db.Employees.FirstOrDefault(a=>a.ID==employee.ID);
        //    return result;
        //}

        //public Employee Get(Expression<Func<Employee, bool>> filter = null)
        //{
        //    throw new NotImplementedException();
        //}

        public List<Employee> GetAll()
        {
            using var transaction=db.Database.BeginTransaction();
            try
            {
                var employees = db.Employees.Where(a => a.ID > 0)
                .ToList();
                transaction.CreateSavepoint("one");
                var employee = db.Employees.FirstOrDefault();
                db.Entry(employee).Reference(d => d.Department).Load();
                transaction.Commit();
                return employees;
            }
            catch (Exception )
            {
                transaction.RollbackToSavepoint("one");
                transaction.Commit();
                throw;
            }
           
        }


    }
}
