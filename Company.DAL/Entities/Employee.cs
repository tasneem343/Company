
using Company.DAL.ComplexType;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Company.DAL.Entities
{
    public class Employee
    {

        [Key]
        public long ID { get; set; }
        public string FullName { get; private set; }
        public decimal Salary { get; private set; }
        public decimal SalaryAfterBonus { get; private set; }

       public Address Address { get; set; }=new Address();
        public Employee(long iD, string fullName, decimal salary, decimal salaryAfterBonus)
        {
            ID = iD;
            FullName = fullName;
            Salary = salary;
            SalaryAfterBonus = salaryAfterBonus;
           
        }
        [ForeignKey("Department")]
        public long? DeptID {  get; set; }
        public virtual Department? Department { get; set; }


    }
}
