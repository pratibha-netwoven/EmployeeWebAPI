using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeesAPI.Repositories
{
    public class EmployeeRepository : IEmployeeRepo
    {
        public int DeleteEmployee(int EmployeeID)
        {
            int returnrows = -1;
            using (var context = new EmployeeDBEntities())
            {
                Employee _objEmpToDelete = context.Employees.Find(EmployeeID);
                context.Employees.Remove(_objEmpToDelete);
                returnrows = context.SaveChanges();
            }
            return returnrows;
        }

        public Employee GetEmployee(int EmployeeID)
        {
            Employee _objEmp = null;
            using (var context = new EmployeeDBEntities())
            {
                _objEmp = context.Employees.Find(EmployeeID);
            }
            return _objEmp;
        }

        public List<Employee> GetEmployees()
        {
            //List<Employee> _lstEmployee = new List<Employee>();
            //_lstEmployee.Add(new Employee { ID = 1, who = "Pratibha", phone = "9903944115", pic = "Pratibha.jpg", designation = "PE", bloodgrp = "B+" });
            //_lstEmployee.Add(new Employee { ID = 1, who = "Debopoma Chaudhury", phone = "9783491116", pic = "Pratibha.jpg", designation = "PE", bloodgrp = "B+" });
            //return _lstEmployee;
            List<Employee> _lstEmployee = new List<Employee>();
            using (var context = new EmployeeDBEntities())
            {
                _lstEmployee = context.Employees.ToList();
            }
            return _lstEmployee;
        }

        public int InsertEmployee(Employee emp)
        {
            int returnrows = -1;
            using (var context = new EmployeeDBEntities())
            {
                context.Employees.Add(new Employee
                {
                    who = emp.who,
                    bloodgrp = emp.bloodgrp,
                    designation = emp.designation,
                    phone = emp.phone,
                    pic = emp.pic
                });
                returnrows = context.SaveChanges();

            }
            return returnrows;
        }

        public int UpdateEmployee(Employee emp)
        {
            int returnrows = -1;
            using (var context = new EmployeeDBEntities())
            {
                Employee _objupdateEmp = context.Employees.Find(emp.ID);
                _objupdateEmp.who = emp.who;
                _objupdateEmp.phone = emp.phone;
                _objupdateEmp.designation = emp.designation;
                _objupdateEmp.pic = emp.pic;
                _objupdateEmp.bloodgrp = emp.bloodgrp;

                returnrows = context.SaveChanges();
            }
            return returnrows;
        }
    }
}