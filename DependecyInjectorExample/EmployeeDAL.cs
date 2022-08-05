using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependecyInjectorExample
{
    interface IEmployeeDAL
    {
        List<Employee> SelectAllEmployee();
    }

    class EmployeeDAL : IEmployeeDAL
    {
        public List<Employee> SelectAllEmployee()
        {
            List<Employee> employees = new List<Employee>();

            employees.Add(new Employee()
            {
                ID = 1,
                Name = "Petr",
                Department = "IT"
            });
            employees.Add(new Employee()
            {
                ID = 2,
                Name = "Ivan",
                Department = "HR"
            });
            employees.Add(new Employee()
            {
                ID = 3,
                Name = "Oleg",
                Department = "Cassier"
            });

            return employees;
        }
    }
}
