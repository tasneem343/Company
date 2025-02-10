

using Company.DAL.ComplexType;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Company.DAL.Entities
{
    public class Department
    {
       

        public Department(long id, string name)
        {
            Id = id;
            Name = name;
        }

        [Key]
        public long Id { get; private set; }
        public string Name { get; private set; }
        public Address Address { get; set; }= new Address();


        public virtual List<Employee>? Employees { get; set; }
    }
}
