using Microsoft.ILP2025.EmployeeCRUD.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.ILP2025.EmployeeCRUD.Repositores
{
    public class EmployeeRepository : IEmployeeRepository
    {
        static List<EmployeeEntity> employees = new List<EmployeeEntity>();

        public async Task<List<EmployeeEntity>> GetAllEmployees()
        {
            return await Task.FromResult(this.GetEmployees());
        }

        public async Task<EmployeeEntity> GetEmployee(int id)
        {
            var employees = this.GetEmployees();

            return await Task.FromResult(employees.FirstOrDefault(e => e.Id == id));
        }

        private List<EmployeeEntity> GetEmployees()
        {

            // employees.Add(new EmployeeEntity { Id = 1, Name = "Pradip" });
            // employees.Add(new EmployeeEntity { Id = 2, Name = "Shrikanth" });

            return employees;
        }
        public void Create(EmployeeEntity emp)
        {
            employees.Add(emp);
            Console.Write("Added Successfully");
        }

        public void Edit(EmployeeEntity emp)
        {
            var employee = employees.FirstOrDefault(e => e.Id == emp.Id);
            if (employee != null)
            {
                employee.Id = emp.Id;
                employee.Name = emp.Name;
                employee.Department = emp.Department;
                employee.Age = emp.Age;
                employee.Salary = emp.Salary;
                Console.Write("Updated Successfully");
            }
        }
        public void Delete(EmployeeEntity emp)
        {
            var del = employees.FirstOrDefault(e => e.Id == emp.Id);
            if (del != null)
            {
                employees.Remove(del);
            }
        }

    }
}
