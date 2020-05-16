using ApiToken.Models;
using ApiToken.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.ModelBinding;

namespace ApiToken.Controllers
{
    [Authorize]
    public class EmployeeController : ApiController
    {
        NorthwindEntities db = new NorthwindEntities();

        //public IEnumerable<Employee> GetEmployees()
        //{
        //    return db.Employees.ToList();
        //}

        //public HttpResponseMessage GetEmployees()
        //{
        //    return Request.CreateResponse(HttpStatusCode.OK, db.Employees.ToList());

        //}

        public IHttpActionResult GetEmployee()
        {
            var employees = db.Employees.Select(x => new EmployeeVM
            {
                EmployeeID = x.EmployeeID,
                FirstName = x.FirstName,
                LastName = x.LastName
            }).ToList();
            
            return Ok(employees);
        }
    }
}
