using DependecyInjectorExample;

//Внедрение зависимости через конструктор
EmployeeBL employeeBL = new EmployeeBL(new EmployeeDAL());

List<Employee> listEmployees = employeeBL.GetAllEmployees();


//Внедрение зависимости через свойство
/*EmployeeBL employeeBL = new EmployeeBL();
employeeBL.employeeDataObject = new EmployeeDAL();

List<Employee> listEmployees = employeeBL.GetAllEmployees();*/


//Внедрение зависимости через класс
/*EmployeeBL employeeBL = new EmployeeBL();

List<Employee> listEmployees = employeeBL.GetAllEmployees(new EmployeeDAL());*/


foreach (Employee emp in listEmployees)
{
    Console.WriteLine("ID = {0}, Name = {1}, Department = {2}",
        emp.ID, emp.Name, emp.Department);
}


/*
    Unity
    Castle Windsor
    StructureMap
    Spring.NET
*/