using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependecyInjectorExample
{
    internal class EmployeeBL
    {
        public IEmployeeDAL employeeDAL;

        public EmployeeBL(IEmployeeDAL employeeDAL)
        {
            this.employeeDAL = employeeDAL;
        }

        public List<Employee> GetAllEmployees()
        {
            employeeDAL = new EmployeeDAL();

            return employeeDAL.SelectAllEmployee();
        }
    }

    /*class EmployeeBL
    {
        private IEmployeeDAL employeeDAL;

        public IEmployeeDAL employeeDataObject
        {
            set
            {
                this.employeeDAL = value;
            }
            get
            {
                if(employeeDataObject == null)
                {
                    throw new Exception("Employees is not initialized");
                }
                else
                {
                    return employeeDAL;
                }
            }
        }

        public List<Employee> GetAllEmployees()
        {
            return employeeDAL.SelectAllEmployee();
        }
    }*/

    /*class EmployeeBL
    {
        public IEmployeeDAL employeeDAL;

        public List<Employee> GetAllEmployees (IEmployeeDAL _employeeDAL)
        {
            employeeDAL = _employeeDAL;
            return employeeDAL.SelectAllEmployee();
        }
    }*/
}
