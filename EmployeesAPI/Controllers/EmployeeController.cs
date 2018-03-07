using EmployeesAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
//using System.Web.Mvc;
using Newtonsoft.Json;
using System.Web.Http.Cors;
using EmployeesAPI.Repositories;

namespace EmployeesAPI.Controllers
{
    //[EnableCors(origins: "*", headers: "*", methods: "*", exposedHeaders: "X-My-Header")]
    public class EmployeeController : BaseController
    {
        IEmployeeRepo EmployeeRepo = new EmployeeRepository();
        public List<Employee> GetEmployees()
        {
            return EmployeeRepo.GetEmployees();
        }

       
        // POST api/values
        public void Post(Employee data)
        {
            EmployeeRepo.InsertEmployee(data);
        }


        public void Put(Employee data)
        {
            EmployeeRepo.UpdateEmployee(data);
        }

        
        public void Delete(int id)
        {
            EmployeeRepo.DeleteEmployee(id);
            var response = new HttpResponseMessage();
            response.Headers.Add("DeleteMessage", "Succsessfuly Deleted!!!");
            //return response;
        }

        //public void Options() { }

    }
}
