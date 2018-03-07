using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesAPI.Repositories
{
    interface IEmployeeRepo
    {
        List<Employee> GetEmployees();
        Employee GetEmployee(int EmployeeID);
        int InsertEmployee(Employee emp);
        int UpdateEmployee(Employee emp);

        int DeleteEmployee(int EmployeeID);
    }
}
