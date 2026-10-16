using Domain.Models;
using Infrastructure.Services;

EmployeeService employeeService = new EmployeeService(); 
Employee employee = new Employee();
Department department = new Department();
DepartmentServise departmentServise = new DepartmentServise();


employee.Firstname = "Bilol";
employee.Lastname = "Azizov";
employee.BirthDate = new DateTime(2009, 05, 15);
employee.Salary = 1000;
employee.department = department;

employeeService.AddEmployees(employee);
departmentServise.AddDeparments(department);

foreach (var item in employeeService.GetEmployees())
{
System.Console.WriteLine(
item.Firstname + " " +
item.Lastname + " " +
item.BirthDate.ToShortDateString() + " " +
item.Salary + " " +
item.department
);
}


