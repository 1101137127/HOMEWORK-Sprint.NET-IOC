using KuasCore.Dao.Base;
using KuasCore.Dao.Mapper;
using KuasCore.Models;
using Spring.Data.Common;
using Spring.Data.Generic;
using System.Collections.Generic;
using System.Data;

namespace KuasCore.Dao.Impl
{
    public class NewEmployeeDao : IEmployeeDao
    {

        public IList<Employee> GetAllEmployees()
        {
            List<Employee> Employee = new List<Employee>();
            
            Employee employee1 = new Employee();
            employee1.Id = "lala";
            employee1.Name = "拉拉";
            employee1.Age = 25;
            Employee.Add(employee1);

            Employee employee2 = new Employee();
            employee1.Id = "Haohao";
            employee1.Name = "豪大哥";
            employee1.Age = 23;
            Employee.Add(employee2);

            return Employee;
        }

        public Employee GetEmployeeById(string id)
        {
            Employee Employee = new Employee();
            Employee.Id = "Haohao";
            Employee.Name = "豪大哥";
            Employee.Age = 23;

            return Employee;
        }

    }
}
